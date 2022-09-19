using Core.Entities;
using ElectronicSalesManagement.Models;
using ElectronicSalesManagement.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository accountRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICustomerRepository customerRepository;

        public AccountController(IAccountRepository _accountRepository, ICategoryRepository _categoryRepository,ICustomerRepository _customerRepository)
        {
            accountRepository = _accountRepository;
            categoryRepository = _categoryRepository;
            customerRepository = _customerRepository;
        }

        public IActionResult Index()
        {
            String user = HttpContext.Session.GetString("login");

            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            ViewData["Categories"] = categoryRepository.Categories();
            return View();
        }

        public IActionResult Detail(int id)
        {           
            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            Account AC = accountRepository.FindByID(id);
            String user = HttpContext.Session.GetString("login");
            ModelView VM = new ModelView
            {
                account = AC,
                Accounts = accountRepository.Accounts(),
                Categories = categoryRepository.Categories(),
                Customers = customerRepository.Customers()
            };
            ViewData["Categories"] = categoryRepository.Categories();
            return View(VM);
        }

        public static string ToMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }
            return sbHash.ToString();

        }

        public IActionResult Edit(int id)
        {
            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            ModelView m = new ModelView
            {
                account = accountRepository.FindByID(id),
                Customers = customerRepository.Customers()
            };
            ViewData["Categories"] = categoryRepository.Categories();
            return View(m);
        }

        [HttpPost]
        public void Edit(AccountModel am)
        {
            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            if (ModelState.IsValid)
            {
                if (am.ID_Account != 0)
                {
                    Account ac = accountRepository.FindByID(am.ID_Account);
                    ac.Username = am.Username;
                    ac.Password = ToMD5(am.Password);                  
                    ac.Email = am.Email;
                    ac.Status = "Hoạt động";
                    ac.DateActive = am.DateActive;
                    accountRepository.editAccount(ac);
                }
            }
            ViewData["Categories"] = categoryRepository.Categories();
            Response.Redirect("/Account/Detail");
        }

        public void Delete(int id)
        {
            if (!checkSession())
            {
                Response.Redirect("/Login/Index");
            }
            accountRepository.removeAccount(id);
            HttpContext.Session.Remove("login");
            Response.Redirect("/Home/Index");
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
