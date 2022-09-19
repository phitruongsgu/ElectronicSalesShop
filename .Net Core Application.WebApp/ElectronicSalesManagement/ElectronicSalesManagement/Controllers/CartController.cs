
using Core.Entities;
using ElectronicSalesManagement.AjaxModels;
using ElectronicSalesManagement.Models;
using ElectronicSalesManagement.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ElectronicSalesManagement.Controllers
{
    public class CartController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ISaleRepository saleRepository;
        private readonly IProductRepository productRepository;
        private readonly IProvinceRepository provinceRepository;
        private readonly IDistrictRepository districtRepository;
        private readonly IWardRepository wardRepository;
        private readonly IAccountRepository accountRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IDetailOrderRepository detailOrderRepository;

        public CartController(ICategoryRepository categoryRepository, ISaleRepository saleRepository,
            IProductRepository productRepository, IProvinceRepository provinceRepository,
            IDistrictRepository districtRepository, IWardRepository wardRepository,
            IAccountRepository accountRepository, ICustomerRepository customerRepository,
            IOrderRepository orderRepository, IDetailOrderRepository detailOrderRepository)
        {
            this.categoryRepository = categoryRepository;
            this.saleRepository = saleRepository;
            this.productRepository = productRepository;
            this.provinceRepository = provinceRepository;
            this.districtRepository = districtRepository;
            this.wardRepository = wardRepository;
            this.accountRepository = accountRepository;
            this.customerRepository = customerRepository;
            this.orderRepository = orderRepository;
            this.detailOrderRepository = detailOrderRepository;
        }
        public IActionResult Index()
        {
            ViewData["Categories"] = categoryRepository.Categories();
            var SESSION_CART = HttpContext.Session.GetString("cart");
            List<Cart> list_cart = new List<Cart>();
            if (SESSION_CART != null)
            {
                list_cart = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);
            }
            ModelView MV = new ModelView
            {
                list_cart = list_cart,
                Sales = saleRepository.Sales()
            };
            return View(MV);
        }

        #region .
        //[Route("nam-mo-moi-biet-duoc-link-nay")]
        #endregion

        public IActionResult Checkout()
        {
            ViewData["Categories"] = categoryRepository.Categories();
            var username = HttpContext.Session.GetString("login");
            if(username == null)
            {
                Response.Redirect("/Login/Index");
            }

            ModelView MV = new ModelView
            {
                Provinces = provinceRepository.Provinces()
            };

            return View(MV);
        }

        [HttpPost]
        public JsonResult GetTotalMoney_ForCheck()
        {
            var SESSION_CART = HttpContext.Session.GetString("cart");
            var money = "Total: 0 VNĐ";
            double totalMoney = 0;
            if (SESSION_CART != null)
            {
                List<Cart> list = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);
                foreach (var i in list)
                {
                    totalMoney += double.Parse(i.IntoMoney);
                }

                money = "Total: " + totalMoney.ToString("#,##0").Replace(",", ".") + " VNĐ";
            }
            return Json(money);
        }

        [HttpPost]
        public JsonResult removeProductFromCart([FromBody] RemoveProductFromCart model)
        {
            var idProduct = int.Parse(model.IDProduct);
            var message = "Remove successed.!!!";

            var SESSION_CART = HttpContext.Session.GetString("cart");
            List<Cart> list = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);
            foreach (var item in list)
            {
                if (item.Product_ID == idProduct)
                {
                    list.Remove(item);
                    break;
                }
            }
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list));

            return Json(message);
        }

        [HttpPost]
        public JsonResult UpdateCart([FromBody] UpdateCart model)
        {
            var idProduct = int.Parse(model.IDProduct);
            var quantity = model.Quantity;

            Product p = productRepository.FindByID(idProduct);

            int percentSale = int.Parse(saleRepository.Sales().Where(s => int.Parse(s.ID_SaleParent) == p.ID_Sale).FirstOrDefault().Percent_sale);
            double saleMoney = double.Parse(p.Price) - (double.Parse(p.Price) * double.Parse(percentSale.ToString()) / 100);

            var SESSION_CART = HttpContext.Session.GetString("cart");

            List<Cart> list = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);

            if (int.Parse(quantity) < p.Amount)
            {
                foreach (var item in list)
                {
                    if (item.Product_ID == idProduct)
                    {
                        item.Amount = int.Parse(quantity);
                        item.IntoMoney = ((double.Parse(quantity) * saleMoney)).ToString();
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.Product_ID == idProduct)
                    {
                        item.Amount = p.Amount;
                        item.IntoMoney = ((double.Parse((p.Amount).ToString()) * saleMoney)).ToString();
                        break;
                    }
                }
            }

            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list));

            return Json("ok");
        }

        [HttpPost]
        public JsonResult GetDistrict([FromBody] GetDataNational model)
        {
            var idProvince = int.Parse(model.IDProvince);

            IEnumerable<District> districts = districtRepository.Districts().Where(d => d.ID_Province == idProvince);
            var html = "";
            foreach (var i in districts)
            {
                html += "<option value='" + i.ID_District + "'>" + i.Name + "</option>";
            }

            return Json(html);
        }

        [HttpPost]
        public JsonResult GetWard([FromBody] GetDataNational model)
        {
            var idDistrict = int.Parse(model.IDDistrict);

            IEnumerable<Ward> wards = wardRepository.Wards().Where(w => w.ID_District == idDistrict);
            var html = "";
            foreach (var i in wards)
            {
                html += "<option value='" + i.ID_Ward + "'>" + i.Name + "</option>";
            }

            return Json(html);
        }

        [HttpPost]
        public JsonResult CheckoutHandler([FromBody] Checkout model)
        {
            var firstName = model.FirstName;
            var lastName = model.LastName;
            var email = model.Email;
            var phone = model.Phone;
            var IDProvince = model.IDProvince;
            var IDDistrict = model.IDDistrict;
            var IDWard = model.IDWard;
            var address = model.Address;
            var note = model.Note;

            var SESSION_LOGIN = HttpContext.Session.GetString("login");
            var username = JsonConvert.DeserializeObject<String>(SESSION_LOGIN);

            var SESSION_CART = HttpContext.Session.GetString("cart");
            List<Cart> list = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);

            // get ID Account
            var IDAccount = accountRepository.Accounts().Where(a => a.Username == username).FirstOrDefault().ID_Account;

            // get data national
            var provinceName = provinceRepository.FindByID(int.Parse(IDProvince)).Name;
            var districtName = districtRepository.FindByID(int.Parse(IDDistrict)).Name;
            var wardName = wardRepository.FindByID(int.Parse(IDWard)).Name;

            var fullName = firstName + " " + lastName;
            var fullAdress = address + ", " + wardName + " Ward, " + districtName + " District, " + provinceName + " Province";

            // check exist customer
            Customer c = customerRepository.Customers().Where(c => c.FullName.ToLower() == fullName.ToLower() 
                                                                        && c.Address == fullAdress)
                                                        .FirstOrDefault();
            var IDCustomer = 0;
            if (c == null)
            {
                customerRepository.createCustomer(new Customer
                {
                    FullName = fullName,
                    Address = fullAdress,
                    Phone = phone,
                    ID_Account = IDAccount
                });
                IDCustomer = customerRepository.Customers().LastOrDefault().ID_Customer;
            }
            else
            {
                IDCustomer = c.ID_Customer;
            }

            // get Total Money Cart
            var totalMoney = list.Sum(p => double.Parse(p.IntoMoney));

            // create order
            orderRepository.createOrder(new Order
            {
                ID_Customer = IDCustomer,
                Receiver = fullName,
                Address = fullAdress,
                Phone = phone,
                TotalMoney = totalMoney.ToString(),
                DateOrder = DateTime.Now.ToString(),
                Status = "Waitting for confirmation",
                StatusPay = "Unpaid",
                Note = note
            });

            // get the last IDOrder
            var IDOrder = orderRepository.Orders().LastOrDefault().ID_Order;

            // create detail order
            foreach(var item in list)
            {
                detailOrderRepository.createDetailOrder(new DetailOrder {
                    ID_Order = IDOrder,
                    ID_Product = item.Product_ID,
                    AmountOrder = item.Amount,
                    IntoMoney = item.IntoMoney
                });

                // update amount product
                Product p = productRepository.FindByID(item.Product_ID);
                if(item.Amount == p.Amount)
                {
                    p.Amount = 0;
                    p.Status = "Out of Stock";
                }
                else
                {
                    p.Amount -= item.Amount;
                }
                productRepository.editProduct(p);
            }

            // remove session cart
            HttpContext.Session.Remove("cart");

            return Json("Thank you for your order.!!!");
        }
    }
}
