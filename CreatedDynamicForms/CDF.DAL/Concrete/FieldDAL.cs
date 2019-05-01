using CDF.DAL.Abstract;
using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.DAL.Concrete
{
   public class FieldDAL : IFieldDAL
   {
      public Field AddField(Field field)
      {
         using(var context=new EFContext())
         {
            var f=context.Fields.Add(field);
            context.SaveChanges();
            return f;
         }
      }
   }
}
