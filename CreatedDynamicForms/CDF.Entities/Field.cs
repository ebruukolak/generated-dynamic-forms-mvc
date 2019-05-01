using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Entities
{
   public class Field
   {
      public int Id { get; set; }
      public bool required { get; set; }
      public string name { get; set; }
      public string dataType { get; set; }
      public int formId { get; set; }
   }
}
