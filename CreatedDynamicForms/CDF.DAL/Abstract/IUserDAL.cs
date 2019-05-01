using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.DAL.Abstract
{
   public interface IUserDAL
   {
      User GetUser(string username, string password);
   }
}
