using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Entities
{
   public class Form
   {
      public int ID { get; set; }
      public string name { get; set; }
      public string description { get; set; }
      public DateTime createdAt { get; set; }
      public int createdBy { get; set; }
   }
}
