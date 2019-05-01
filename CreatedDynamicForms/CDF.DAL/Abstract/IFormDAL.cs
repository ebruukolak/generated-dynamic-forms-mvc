using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.DAL.Abstract
{
   public interface IFormDAL
   {
      Form AddForm(Form form);
      List<Form> GetForms();
      Form GetById(int id);
      Form GetByName(string name);
   }
}
