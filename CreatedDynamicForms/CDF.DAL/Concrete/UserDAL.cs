using CDF.DAL.Abstract;
using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDF.DAL.Concrete
{
   public class UserDAL : IUserDAL
   {
      public User GetUser(string username, string password)
      {
         using(var context=new EFContext())
         {
            return context.Users.FirstOrDefault(x => x.username == username && x.password==password);
         }
      }
   }
}
