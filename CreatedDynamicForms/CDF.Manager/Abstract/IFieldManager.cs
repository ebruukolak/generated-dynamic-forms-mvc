using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Abstract
{
   public interface  IFieldManager
   {
      void AddField(Field field);
      List<Field> GetByFormId(int id);
   }
}
