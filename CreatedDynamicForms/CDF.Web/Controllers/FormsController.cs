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
            return View(formManager.GetForms());
         }
         return RedirectToAction("Login", "Account");

      }

      public ActionResult CreateForm()
      {
         return View();
      }
      [HttpPost]
      public ActionResult CreateForm(FormViewModel formViewModel)
      {
         if (ModelState.IsValid)
         {
            var form = new Form
            {
               name = formViewModel.name,
               description = formViewModel.description,
               createdBy = (int)Session["UserID"],
               createdAt = DateTime.Now
            };
            var newForm = formManager.AddForm(form);
            if (newForm != null)
            {
               foreach (var item in formViewModel.fields)
               {
                  fieldManager.AddField(new Field
                  {
                     name = item.name,
                     dataType = item.dataType,
                     formId = newForm.Id
                  });
               }
            }

         }
         else
         {
            TempData["error"] = "There is some error";
         }

         return View(formViewModel);

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
            return View(new FormViewModel {
               name=form.name,
               description=form.description,
               createdAt=form.createdAt,
               createdBy=user.name,
               fields= formFields
            });
         }
         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
   }
}