using System;
using CDF.DAL.Abstract;
using CDF.DAL.Concrete;
using CDF.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDF.Test
{
   [TestClass]
   public class FormTest
   {
      IFormDAL formDAL = new FormDAL();
      [TestMethod]
      public void should_add_form()
      {
         var form = new Form {
            name = "Deneme",
            description = "deneme form",
            createdBy = 1,
            createdAt = DateTime.Now
         };
        var f= formDAL.AddForm(form);
         Assert.IsNotNull(f);
      }
      [TestMethod]
      public void should_get_form_id()
      {
         var f = formDAL.GetById(1);
         Assert.IsNotNull(f);
      }
      [TestMethod]
      public void shoul_get_form_name()
      {
         var f = formDAL.GetByName("deneme");
         Assert.IsNotNull(f);
      }
      [TestMethod]
      public void shoul_get_all_forms()
      {
         var f = formDAL.GetForms();
         Assert.IsNotNull(f);
      }
   }
}
