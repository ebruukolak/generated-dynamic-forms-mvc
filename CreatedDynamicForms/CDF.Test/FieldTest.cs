using System;
using CDF.DAL.Abstract;
using CDF.DAL.Concrete;
using CDF.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDF.Test
{
   [TestClass]
   public class FieldTest
   {
      IFieldDAL fieldDAL=new FieldDAL();
      [TestMethod]
      public void shoul_add_field()
      {
         var field = new Field
         {
            name = "surname",
            required = true,
            dataType = "STRING"
         };
         var f=fieldDAL.AddField(field);
         Assert.IsNotNull(f);
      }
   }
}
