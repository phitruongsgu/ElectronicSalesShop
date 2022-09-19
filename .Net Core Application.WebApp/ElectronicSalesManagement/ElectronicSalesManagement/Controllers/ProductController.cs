using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectronicSalesManagement.ViewModels;
using Infrastructure.Persistance.IRepository;
using System.Linq;
using System.Threading.Tasks;
using ElectronicSalesManagement.AjaxModels;
using Microsoft.AspNetCore.Http;
using ElectronicSalesManagement.Models;
using Newtonsoft.Json;

namespace ElectronicSalesManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ISaleRepository saleRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductController(IProductRepository productRepository, ISaleRepository saleRepository,
            ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.saleRepository = saleRepository;
            this.categoryRepository = categoryRepository;
        }

        [Route("/Product/Index/{idCategory}")]
        [HttpGet]
        public IActionResult Index(int idCategory)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            if (idCategory == 0)
            {
                ModelView VM = new ModelView
                {
                    Products = productRepository.Products().Where(p => p.Amount != 0),
                    Categories = categoryRepository.Categories(),
                    Sales = saleRepository.Sales()
                };
                return View(VM);
            }
            else
            {
                ModelView VM = new ModelView
                {
                    Products = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == idCategory).ToList(),
                    Categories = categoryRepository.Categories(),
                    Sales = saleRepository.Sales()
                };
                return View(VM);
            }
        }

        #region Bộ lọc (ko đc chỉnh sửa bất kì gì trong này khi chưa được cho phép từ nhóm)

        //1
        [Route("/Product/Index/{filter_0}/{filter_1}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            #region Filter

            var category = categoryRepository.Categories().Where(p => p.Name.ToLower().Equals(filter_1.ToLower())).FirstOrDefault();

            #endregion Filter

            ModelView VM = new ModelView
            {
                Products = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == category.ID_Category),
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales(),
                filter_0 = filter_0,
                filter_1 = filter_1
            };
            return View(VM);
        }

        //1-2
        [Route("/Product/Index/{filter_0}/{filter_1}/{filter_2}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1, string filter_2)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            #region Filter

            // lấy ra loại sp theo filter 1
            var category = categoryRepository.Categories().Where(p => p.Name.ToLower().Equals(filter_1.ToLower())).FirstOrDefault();

            // lấy các sp thuộc loại sp vừa tìm bên trên
            var product_of_cate = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == category.ID_Category).ToList();

            // duyệt tìm các sp có filter2 tương ứng khớp vs thông số đầu tiên  trong description
            List<Product> resultProduct = new List<Product>();
            foreach (var i in product_of_cate)
            {
                var parameter_first = i.Description.Split(";")[0].ToString();
                if (parameter_first.ToLower().Equals(filter_2.ToLower()))
                {
                    resultProduct.Add(i);
                }
            }

            #endregion Filter

            ModelView VM = new ModelView
            {
                Products = resultProduct,
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales(),
                filter_0 = filter_0,
                filter_1 = filter_1,
                filter_2 = filter_2
            };
            return View(VM);
        }

        //1-2-3
        [Route("/Product/Index/{filter_0}/{filter_1}/{filter_2}/{filter_3}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1, string filter_2, string filter_3)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            #region Filter

            // lấy ra loại sp theo filter 1
            var category = categoryRepository.Categories().Where(p => p.Name.ToLower().Equals(filter_1.ToLower())).FirstOrDefault();

            // lấy các sp thuộc loại sp vừa tìm bên trên
            var product_of_cate = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == category.ID_Category).ToList();

            // duyệt tìm các sp có filter2 tương ứng khớp vs thông số đầu tiên  trong description
            List<Product> resultProduct = new List<Product>();

            // TH1: Laptop
            if (category.Name.Equals("Laptop"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_3 = i.Description.Split(";")[3].ToString();
                    if (parameter_3.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH2: PC
            if (category.Name.Equals("PC"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();
                    if (parameter_2.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH3: Screen
            if (category.Name.Equals("Screen"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_5 = i.Description.Split(";")[5].ToString();
                    if (parameter_5.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH4: Hard drive
            if (category.Name.Equals("Hard Drive"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_1 = i.Description.Split(";")[1].ToString();
                    if (parameter_1.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH5: Ram
            if (category.Name.Equals("Ram"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_first = i.Description.Split(";")[1].ToString();
                    if (parameter_first.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            #endregion Filter

            ModelView VM = new ModelView
            {
                Products = resultProduct,
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales(),
                filter_0 = filter_0,
                filter_1 = filter_1,
                filter_2 = filter_2,
                filter_3 = filter_3
            };
            return View(VM);
        }

        //1-2-3-4
        [Route("/Product/Index/{filter_0}/{filter_1}/{filter_2}/{filter_3}/{filter_4}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1, string filter_2, string filter_3, string filter_4)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            #region Filter

            // lấy ra loại sp theo filter 1
            var category = categoryRepository.Categories().Where(p => p.Name.ToLower().Equals(filter_1.ToLower())).FirstOrDefault();

            // lấy các sp thuộc loại sp vừa tìm bên trên
            var product_of_cate = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == category.ID_Category).ToList();

            // duyệt tìm các sp có filter2 tương ứng khớp vs thông số đầu tiên  trong description
            List<Product> resultProduct = new List<Product>();

            // TH1: Laptop
            if (category.Name.Equals("Laptop"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_3 = i.Description.Split(";")[3].ToString();
                    var parameter_5 = i.Description.Split(";")[5].ToString();
                    if (parameter_3.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_5.ToLower().Contains(filter_4.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH2: PC
            if (category.Name.Equals("PC"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();
                    var parameter_4 = i.Description.Split(";")[4].ToString();
                    if (parameter_2.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_4.ToLower().Contains(filter_4.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH3: Screen
            if (category.Name.Equals("Screen"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_5 = i.Description.Split(";")[5].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();

                    if (parameter_5.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_2.ToLower().Contains(filter_4.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH4: Hard drive
            if (category.Name.Equals("Hard Drive"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_1 = i.Description.Split(";")[1].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();

                    if (parameter_1.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_2.ToLower().Contains(filter_4.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH5: Ram
            if (category.Name.Equals("Ram"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_first = i.Description.Split(";")[1].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();

                    if (parameter_first.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_2.ToLower().Contains(filter_4.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            #endregion Filter

            ModelView VM = new ModelView
            {
                Products = resultProduct,
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales(),
                filter_0 = filter_0,
                filter_1 = filter_1,
                filter_2 = filter_2,
                filter_3 = filter_3,
                filter_4 = filter_4
            };
            return View(VM);
        }

        //1-2-3-4-5
        [Route("/Product/Index/{filter_0}/{filter_1}/{filter_2}/{filter_3}/{filter_4}/{filter_5}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1, string filter_2, string filter_3, string filter_4, string filter_5)
        {
            ViewData["Categories"] = categoryRepository.Categories();

            #region Filter

            // lấy ra loại sp theo filter 1
            var category = categoryRepository.Categories().Where(p => p.Name.ToLower().Equals(filter_1.ToLower())).FirstOrDefault();

            // lấy các sp thuộc loại sp vừa tìm bên trên
            var product_of_cate = productRepository.Products().Where(p => p.Amount != 0 && p.ID_Category == category.ID_Category).ToList();

            // duyệt tìm các sp có filter2 tương ứng khớp vs thông số đầu tiên  trong description
            List<Product> resultProduct = new List<Product>();

            // TH1: Laptop
            if (category.Name.Equals("Laptop"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_3 = i.Description.Split(";")[3].ToString();
                    var parameter_5 = i.Description.Split(";")[5].ToString();
                    var parameter_4 = i.Description.Split(";")[4].ToString();

                    if (parameter_3.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_5.ToLower().Contains(filter_4.ToLower())
                        && parameter_4.ToLower().Contains(filter_5.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH2: PC
            if (category.Name.Equals("PC"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();
                    var parameter_4 = i.Description.Split(";")[4].ToString();
                    var parameter_3 = i.Description.Split(";")[3].ToString();

                    if (parameter_2.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_4.ToLower().Contains(filter_4.ToLower())
                        && parameter_3.ToLower().Contains(filter_5.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH3: Screen
            if (category.Name.Equals("Screen"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_5 = i.Description.Split(";")[5].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();
                    var parameter_1 = i.Description.Split(";")[1].ToString();

                    if (parameter_5.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_2.ToLower().Contains(filter_4.ToLower())
                        && parameter_1.ToLower().Contains(filter_5.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            // TH4: Hard drive
            if (category.Name.Equals("Hard Drive"))
            {
                foreach (var i in product_of_cate)
                {
                    var parameter_0 = i.Description.Split(";")[0].ToString();
                    var parameter_1 = i.Description.Split(";")[1].ToString();
                    var parameter_2 = i.Description.Split(";")[2].ToString();
                    var parameter_4 = i.Description.Split(";")[4].ToString();

                    if (parameter_1.ToLower().Contains(filter_3.ToLower())
                        && parameter_0.ToLower().Equals(filter_2.ToLower())
                        && parameter_2.ToLower().Contains(filter_4.ToLower())
                        && parameter_4.ToLower().Contains(filter_5.ToLower()))
                    {
                        resultProduct.Add(i);
                    }
                }
            }

            #endregion Filter

            ModelView VM = new ModelView
            {
                Products = resultProduct,
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales(),
                filter_0 = filter_0,
                filter_1 = filter_1,
                filter_2 = filter_2,
                filter_3 = filter_3,
                filter_4 = filter_4,
                filter_5 = filter_5
            };
            return View(VM);
        }

        //1-2-3-4-5-sortprice
        [Route("/Product/Index/{filter_0}/{filter_1}/{filter_2}/{filter_3}/{filter_4}/{filter_5}/{sortPrice}")]
        [HttpGet]
        public IActionResult Index(string filter_0, string filter_1, string filter_2,
            string filter_3, string filter_4, string filter_5, string sortPrice)
        {
            ViewData["Categories"] = categoryRepository.Categories();
            if (sortPrice == "up")
            {
                // tăng
                ModelView VM = new ModelView
                {
                    Products = productRepository.Products().Where(p => p.Amount != 0).OrderBy(p => int.Parse(p.Price)),
                    Categories = categoryRepository.Categories(),
                    Sales = saleRepository.Sales()
                };
                return View(VM);
            }
            else
            {
                // giảm
                ModelView VM = new ModelView
                {
                    Products = productRepository.Products().Where(p => p.Amount != 0).OrderByDescending(p => int.Parse(p.Price)),
                    Categories = categoryRepository.Categories(),
                    Sales = saleRepository.Sales()
                };
                return View(VM);
            }
        }

        // Lọc theo giá trong khoảng
        [HttpGet]
        public IActionResult FindByPrice(string fromPrice, string toPrice)
        {
            ViewData["Categories"] = categoryRepository.Categories();
            ModelView VM = new ModelView
            {
                Products = productRepository.Products()
                                            .Where(p => p.Amount != 0 &&
                                                (int.Parse(p.Price) >= int.Parse(fromPrice) && int.Parse(p.Price) <= int.Parse(toPrice))),
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales()
            };
            return View("Index", VM);
        }

        [HttpGet]
        public IActionResult SearchByName(string valueSearch)
        {
            ViewData["Categories"] = categoryRepository.Categories();
            ModelView VM = new ModelView
            {
                Products = productRepository.Products()
                                            .Where(p => p.Amount != 0 && p.Name.ToLower().Contains(valueSearch.ToLower())),
                Categories = categoryRepository.Categories(),
                Sales = saleRepository.Sales()
            };
            return View("Index", VM);
        }

        #endregion Bộ lọc (ko đc chỉnh sửa bất kì gì trong này khi chưa được cho phép từ nhóm)

        public IActionResult Detail(int id)
        {
            ViewData["Categories"] = categoryRepository.Categories();
            Product product = productRepository.Products().Where(p => p.ID_Product == id).FirstOrDefault();
            Sale sale = saleRepository.Sales().Where(m => int.Parse(m.ID_SaleParent) == product.ID_Sale).FirstOrDefault();
            String categoryName = categoryRepository.Categories().Where(p => p.ID_Category == product.ID_Category).FirstOrDefault().Name;
            ModelView VM = new ModelView
            {
                product = product,
                sale = sale,
                categoryName = categoryName
            };
            return View(VM);
        }

        [HttpPost]
        public JsonResult AddToCart_OnlyOne([FromBody] AddToCart model)
        {
            var idProduct = model.IDProduct;
            var message = "Add to cart success.!!!";
            Product p = productRepository.FindByID(idProduct);

            int percentSale = int.Parse(saleRepository.Sales().Where(s => int.Parse(s.ID_SaleParent) == p.ID_Sale).FirstOrDefault().Percent_sale);
            double saleMoney = double.Parse(p.Price) - (double.Parse(p.Price) * double.Parse(percentSale.ToString()) / 100);

            if (p.Amount > 0)
            {
                var SESSION_CART = HttpContext.Session.GetString("cart");
                if (SESSION_CART == null)
                {
                    List<Cart> list_cart = new List<Cart>{
                    new Cart{
                        Product_ID = p.ID_Product,
                        Product_Name = p.Name,
                        Image = p.ImagePath,
                        Amount = 1,
                        ParrentSale = p.ID_Sale,
                        Price = p.Price,
                        IntoMoney = saleMoney.ToString()
                    }};
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                }
                else
                {
                    List<Cart> list_cart = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);

                    // get product in cart
                    Cart c = list_cart.Where(i => i.Product_ID == p.ID_Product).FirstOrDefault();

                    if (c != null)
                    {
                        var updateAmount = c.Amount + 1;

                        // check amount add
                        if (updateAmount <= p.Amount)
                        {
                            c.Amount = updateAmount;
                            c.IntoMoney = (double.Parse(updateAmount.ToString()) * saleMoney).ToString();
                            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                        }
                        else
                        {
                            message = "The product you added has exceeded the specified amount.!!!";
                        }
                    }
                    else
                    {
                        list_cart.Add(new Cart
                        {
                            Product_ID = p.ID_Product,
                            Product_Name = p.Name,
                            Image = p.ImagePath,
                            Amount = 1,
                            ParrentSale = p.ID_Sale,
                            Price = p.Price,
                            IntoMoney = saleMoney.ToString()
                        });
                        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                    }
                }
            }
            else
            {
                message = "Temporarily out of stock.!!!";
            }
            return Json(message);
        }

        [HttpPost]
        public JsonResult AddToCart([FromBody] AddToCart model)
        {
            var idProduct = model.IDProduct;
            var amount = int.Parse(model.Amount);
            var message = "Add to cart success.!!!";

            Product p = productRepository.FindByID(idProduct);

            int percentSale = int.Parse(saleRepository.Sales().Where(s => int.Parse(s.ID_SaleParent) == p.ID_Sale).FirstOrDefault().Percent_sale);
            double saleMoney = double.Parse(p.Price) - (double.Parse(p.Price) * double.Parse(percentSale.ToString()) / 100);

            if (p.Amount > 0)
            {
                var SESSION_CART = HttpContext.Session.GetString("cart");
                if (SESSION_CART == null)
                {
                    List<Cart> list_cart = new List<Cart>{
                    new Cart{
                        Product_ID = p.ID_Product,
                        Product_Name = p.Name,
                        Image = p.ImagePath,
                        Amount = amount,
                        ParrentSale = p.ID_Sale,
                        Price = p.Price,
                        IntoMoney = (double.Parse(amount.ToString()) * saleMoney).ToString()
                }};
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                }
                else
                {
                    List<Cart> list_cart = JsonConvert.DeserializeObject<List<Cart>>(SESSION_CART);

                    // get product in cart
                    Cart c = list_cart.Where(i => i.Product_ID == p.ID_Product).FirstOrDefault();

                    if (c != null)
                    {
                        var updateAmount = c.Amount + amount;

                        // check amount add
                        if (updateAmount <= p.Amount)
                        {
                            c.Amount = updateAmount;
                            c.IntoMoney = (double.Parse(updateAmount.ToString()) * saleMoney).ToString();
                            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                        }
                        else
                        {
                            message = "The product you added has exceeded the specified amount.!!!";
                        }
                    }
                    else
                    {
                        list_cart.Add(new Cart
                        {
                            Product_ID = p.ID_Product,
                            Product_Name = p.Name,
                            Image = p.ImagePath,
                            Amount = amount,
                            ParrentSale = p.ID_Sale,
                            Price = p.Price,
                            IntoMoney = (double.Parse(amount.ToString()) * saleMoney).ToString()
                        });
                        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(list_cart));
                    }
                }
            }
            else
            {
                message = "Temporarily out of stock.!!!";
            }
            return Json(message);
        }
    }
}