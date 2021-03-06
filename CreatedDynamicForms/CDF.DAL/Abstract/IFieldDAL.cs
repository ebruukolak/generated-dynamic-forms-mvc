﻿using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.DAL.Abstract
{
   public interface IFieldDAL
   {
      Field AddField(Field field);
      List<Field> GetByFormId(int id);
   }
}
