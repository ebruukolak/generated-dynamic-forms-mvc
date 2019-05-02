using CDF.Entities;
using CDF.Manager.Abstract;
using CDF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDF.Web.Controllers
{
   public class FieldController : Controller
   {
      IFieldManager fieldManager;
      public FieldController(IFieldManager fieldManager)
      {
         this.fieldManager = fieldManager;
      }

      public ActionResult AddField(int? formId)
      {
         if (Session["UserID"] != null)
         {
            return View(formId);
         }
         return RedirectToAction("Login", "Account");
      }

      [HttpPost]
      public ActionResult AddField(FieldViewModel field)
      {
         if (!ModelState.IsValid)
            return View(field);
         field.formId = Convert.ToInt32(Request.QueryString["id"]); 
         fieldManager.AddField(new Field {
            name=field.name,
            dataType=field.dataType,
            required=field.required,
            formId=field.formId
         });
         return RedirectToAction("FormList", "Forms");
      }
   }
}