using System;
using CDF.DAL.Abstract;
using CDF.DAL.Concrete;
using CDF.Entities;
using CDF.Manager.Abstract;
using CDF.Manager.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDF.Test
{
   [TestClass]
   public class UserTest
   {
      IUserDAL userDAL = new UserDAL();
      [TestMethod]
      public void should_get_user()
      {
         User user = userDAL.GetUser("ebru", "12345");
         Assert.IsTrue(user != null);
      }
      public void should_get_user_by_id()
      {
         User user = userDAL.GetUser(1);
         Assert.IsTrue(user != null);
      }
   }
}
