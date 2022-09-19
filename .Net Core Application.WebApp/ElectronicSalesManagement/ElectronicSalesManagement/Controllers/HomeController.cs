using Core.Entities;
using ElectronicSalesManagement.Models;
using ElectronicSalesManagement.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ElectronicSalesManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ISaleRepository saleRepository;
        private readonly ICategoryRepository categoryRepository;

        private readonly IAccountRepository accountRepository;
        public HomeController(IProductRepository productRepository, ISaleRepository saleRepository,
            ICategoryRepository categoryRepository, IAccountRepository _accountRepository)
        {
            this.productRepository = productRepository;
            this.saleRepository = saleRepository;
            this.categoryRepository = categoryRepository;
            this.accountRepository = _accountRepository;
        }

        public IActionResult Index()
        {
            //String user = HttpContext.Session.GetString("login");
            //Account acc = accountRepository.Accounts().Where(p => p.ID_Account == int.Parse(user)).FirstOrDefault();
            IEnumerable<Product> products = productRepository.Products();
            IEnumerable<Sale> sales = saleRepository.Sales();
            ViewData["Categories"] = categoryRepository.Categories();
            ModelView VM = new ModelView
            {
                Products = products,
                Sales = sales,
            };
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
        #region Không dùng đến
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
