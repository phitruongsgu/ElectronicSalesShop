using Core.Entities;
using ElectronicSalesManagement.Models;
using Infrastructure.Persistance.DBcontext;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAccountRepository accountRepository;

        public LoginController(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }

        public IActionResult Index()
        {
            String user = HttpContext.Session.GetString("login");

            if (checkSession())
            {
                Response.Redirect("/Home/Index");
            }
            return View(new LoginModel());
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                String user = model.Username;
                String pass = SeedData.ToMD5(model.Password);

                Account acc = accountRepository.Accounts().Where(p => p.Username == user && p.Password == pass).FirstOrDefault();

                if (acc != null)
                {
                    HttpContext.Session.SetString("login", JsonConvert.SerializeObject(acc.Username));
                    Response.Redirect("/Home/Index");
                }
                else
                {
                    Response.Redirect("/Login/Index");
                }

            }
            return View();
        }

        public void Logout()
        {
            HttpContext.Session.Remove("login");
            Response.Redirect("/Home/Index");
        }

        public IActionResult Register()
        {
            if (checkSession())
            {
                Response.Redirect("/Home/Index");
            }
            return View(new RegisterModel());
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

        [HttpPost]
        public IActionResult Register(RegisterModel rm)
        {

            if (ModelState.IsValid) 
            {          

                var a = new Account();
                a.Username = rm.Username;
                a.Password = ToMD5(rm.Password);
                a.Email = rm.Email;
                a.Status = "Hoạt động";
                a.DateActive = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                accountRepository.createAccount(a);
                return RedirectToAction("Index");
            }
            return View();
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
