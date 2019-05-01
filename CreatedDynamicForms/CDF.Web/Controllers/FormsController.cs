using CDF.Manager.Abstract;
using CDF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDF.Web.Controllers
{
   public class FormsController : Controller
   {
      IFormManager formManager;
      public FormsController(IFormManager manager)
      {
         formManager = manager;
      }
      // GET: Form
      public ActionResult FormList()
      {
         return View(formManager.GetForms());
      }
   }
}