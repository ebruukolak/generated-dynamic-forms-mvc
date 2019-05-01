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
      public User GetUser(User user)
      {
         return userDAL.GetUser(user);
      }
   }
}
