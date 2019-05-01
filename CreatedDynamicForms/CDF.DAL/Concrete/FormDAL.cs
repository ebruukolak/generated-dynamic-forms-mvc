using CDF.DAL.Abstract;
using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDF.DAL.Concrete
{
   public class FormDAL : IFormDAL
   {
      public Form AddForm(Form form)
      {
         using (var context = new EFContext())
         {
            var newFrom = context.Forms.Add(form);
            context.SaveChanges();
            return newFrom;
         }
      }

      public Form GetById(int id)
      {
         using (var context = new EFContext())
         {
            return context.Forms.FirstOrDefault(x => x.Id == id);
         }
      }

      public Form GetByName(string name)
      {
         using (var context = new EFContext())
         {
            return context.Forms.FirstOrDefault(x => x.name == name);
         }
      }

      public List<Form> GetForms()
      {
         using (var context = new EFContext())
         {
            return context.Forms.ToList();
         }
      }
   }
}
