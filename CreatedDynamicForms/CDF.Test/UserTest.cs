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
      public void get_user()
      {
         User u = new User
         {
            Id=1,
            username = "ebru",
            password = "12345"
         };
         User user = userDAL.GetUser(u);
         Assert.IsTrue(user != null);
      }
   }
}
