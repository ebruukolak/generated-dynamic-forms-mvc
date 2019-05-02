using CDF.Entities;
using CDF.Manager.Abstract;
using CDF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CDF.Web.Controllers
{
   public class FormsController : Controller
   {
      IFormManager formManager;
      IFieldManager fieldManager;
      IUserManager userManager;
      public FormsController(IFormManager manager, IFieldManager fieldManager, IUserManager userManager)
      {
         formManager = manager;
         this.fieldManager = fieldManager;
         this.userManager = userManager;
      }

      public ActionResult FormList()
      {
         if (Session["UserID"] != null)
         {
            var forms = formManager.GetForms();
            List<FormViewModel> formViewModels = new List<FormViewModel>();

            foreach (var item in forms)
            {
               var user = userManager.GetUserById(item.createdBy);
               formViewModels.Add(
                  new FormViewModel
                  {
                     description = item.description,
                     name = item.name,
                     createdAt = item.createdAt,
                     createdBy = user.name
                  });
            }
            return View(formViewModels);
         }
         return RedirectToAction("Login", "Account");
      }

      public ActionResult CreateForm()
      {
         if (Session["UserID"] != null)
         {
            return View();
         }
         return RedirectToAction("Login", "Account");
      }
      [HttpPost]
      public ActionResult CreateForm(FormViewModel formViewModel)
      {
        
            var form = new Form
            {
               name = formViewModel.name,
               description = formViewModel.description,
               createdBy = (int)Session["UserID"],
               createdAt = DateTime.Now
            };
            var user = userManager.GetUserById((int)Session["UserID"]);
            var newForm = formManager.AddForm(form);
            return RedirectToAction("FormList");  
      }

      public ActionResult GetFormByName(string name)
      {
         if (name != null)
         {
            var form = formManager.GetByName(name);
            return View(form);
         }
         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      public ActionResult GetForm(int? id)
      {
         if (id != null)
         {
            var form = formManager.GetById((int)id);
            var formFields = fieldManager.GetByFromId((int)id);
            var user = userManager.GetUserById(form.createdBy);
            return View(new FormViewModel
            {
               name = form.name,
               description = form.description,
               createdAt = form.createdAt,
               createdBy = user.name
            });
         }
         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
   }
}