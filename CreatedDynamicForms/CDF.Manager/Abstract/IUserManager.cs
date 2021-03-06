﻿using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Abstract
{
   public interface IUserManager
   {
      User GetUser(string username,string password);
      User GetUserById(int id);
   }
}
