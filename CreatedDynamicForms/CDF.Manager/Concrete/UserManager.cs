using CDF.DAL.Abstract;
using CDF.Entities;
using CDF.Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Concrete
{
   public class UserManager : IUserManager
   {
      IUserDAL userDAL;
      public UserManager(IUserDAL userDAL)
      {
         this.userDAL = userDAL;
      }
      public User GetUser(string username, string password)
      {
         return userDAL.GetUser( username,  password);
      }
   }
}
