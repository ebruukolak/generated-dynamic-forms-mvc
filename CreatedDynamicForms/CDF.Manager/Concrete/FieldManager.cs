using CDF.DAL.Abstract;
using CDF.Entities;
using CDF.Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Concrete
{
   public class FieldManager : IFieldManager
   {
      IFieldDAL fieldDAL;
      public FieldManager(IFieldDAL fieldDAL)
      {
         this.fieldDAL = fieldDAL;
      }
      public void AddField(Field field)
      {
         fieldDAL.AddField(field);

      }

      public List<Field> GetByFormId(int id)
      {
         return fieldDAL.GetByFormId(id);
      }
   }
}
