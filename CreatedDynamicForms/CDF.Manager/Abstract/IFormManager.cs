using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Manager.Abstract
{
   public interface IFormManager
   {
      Form AddForm(Form form);
      List<Form> GetForms();
      Form GetById(int id);
      Form GetByName(string name);
   }
}
