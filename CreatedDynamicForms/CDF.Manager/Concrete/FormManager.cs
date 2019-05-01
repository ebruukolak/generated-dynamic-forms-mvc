using CDF.DAL.Abstract;
using CDF.Entities;
using CDF.Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Concrete
{
   public class FormManager : IFormManager
   {
      IFormDAL formDAL;
      public FormManager(IFormDAL formDAL)
      {
         this.formDAL = formDAL;
      }
      public Form AddForm(Form form)
      {
        return formDAL.AddForm(form);
      }

      public Form GetById(int id)
      {
         return formDAL.GetById(id);
      }

      public Form GetByName(string name)
      {
         return formDAL.GetByName(name);
      }

      public List<Form> GetForms()
      {
         return formDAL.GetForms();
      }
   }
}
