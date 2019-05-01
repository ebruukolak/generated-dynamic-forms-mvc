using CDF.Manager.Abstract;
using CDF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDF.Web.Controllers
{
   public class AccountController : Controller
   {
      IUserManager userManager;
      public AccountController(IUserManager manager)
      {
         userManager = manager;
      }

      [AllowAnonymous]
      public ActionResult Login()
      {
         return View();
      }
      [HttpPost]
      public ActionResult Login(UserViewModel userViewModel)
      {
         if (ModelState.IsValid)
         {
            var user = userManager.GetUser(userViewModel.username, userViewModel.password);
            if (user == null)
            {
               TempData["invalidLogin"] = "User name or password is not correct.";
               return View(userViewModel);
            }
            else
            {
               Session["UserID"] = user.Id;
               Session["Username"] = user.username;
               return RedirectToAction("FormList", "Forms");
            }
         }
         return View(userViewModel);
      }

   }
}