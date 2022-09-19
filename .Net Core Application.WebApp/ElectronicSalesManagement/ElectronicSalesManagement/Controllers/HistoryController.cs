using Core.Entities;
using ElectronicSalesManagement.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IDetailOrderRepository detailOrderRepository;
        private readonly IProductRepository productRepository;
        private readonly IAccountRepository accountRepository;
        public HistoryController(IAccountRepository accountRepository,ICategoryRepository categoryRepository,
            ICustomerRepository customerRepository,IOrderRepository orderRepository,
            IDetailOrderRepository detailOrderRepository,IProductRepository productRepository)
        {
            this.categoryRepository = categoryRepository;
            this.customerRepository = customerRepository;
            this.orderRepository = orderRepository;
            this.detailOrderRepository = detailOrderRepository;
            this.productRepository = productRepository;
            this.accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            ViewData["Categories"] = categoryRepository.Categories();
            if (!checkSession())
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                var user = HttpContext.Session.GetString("login");
                user = JsonConvert.DeserializeObject<String>(user);
                Account acc = accountRepository.Accounts().Where(m => m.Username == user).FirstOrDefault();
                ModelView VM = new ModelView
                {
                    Orders = orderRepository.Orders(),
                    Categories = categoryRepository.Categories(),
                    Customers = customerRepository.Customers(),
                    account = acc
                };
                return View(VM);
            }
        }

        public IActionResult DetailOrder(int id)
        {
            String user = HttpContext.Session.GetString("login");
            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            var order = orderRepository.FindByID(id);
            var lstorderDetail = new List<DetailOrder>();
            foreach (var i in detailOrderRepository.DetailOrders())
            {
                if (i.ID_Order == order.ID_Order)
                {
                    lstorderDetail.Add(i);
                }
            }
            ModelView VM = new ModelView
            {
                Products = productRepository.Products(),
                Categories = categoryRepository.Categories(),
                Orders = orderRepository.Orders(),
                DetailOrders = lstorderDetail,
                order = order
            };
            ViewData["Categories"] = categoryRepository.Categories();
            return View(VM);
        }

        public Boolean checkSession()
        {
            String user = HttpContext.Session.GetString("login");
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
