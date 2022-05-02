using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfrelearnMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace InfrelearnMVC.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // validationAntiForgerToken >> validate token taken by post method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginInfo loginInfo)
        {
            string message = string.Empty;
            
            if (ModelState.IsValid)
            {
                // create temporary id & password for the test
                const string userId = "richie";
                const string password = "123456";

                if (loginInfo.UserId.Equals(userId) && loginInfo.Password.Equals(password))
                {
                    TempData["Message"] = "Successful";
                    return RedirectToAction("Index", "Membership");
                }
                else
                {
                    message = "login failure!";
                }


            }
            else
            {
                message = "Please check your login details";
            }
            ModelState.AddModelError(string.Empty, message);
            return View(loginInfo);
        }
    }
}