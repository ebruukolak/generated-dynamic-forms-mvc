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
      public User GetUser(User user)
      {
         using(var context=new EFContext())
         {
            return context.Users.FirstOrDefault(x => x.username == user.username && x.password==user.password);
         }
      }
   }
}
