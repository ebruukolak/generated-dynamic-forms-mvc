using CDF.DAL.Abstract;
using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

      public List<Field> GetByFromId(int id)
      {
         using (var context = new EFContext())
         {
           return context.Fields.Where(x=>x.formId==id).ToList();           
         }
      }
   }
}
