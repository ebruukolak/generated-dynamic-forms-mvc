using CDF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CDF.Web.Models
{
   public class FormViewModel
   {
      public int Id { get; set; }
      public string name { get; set; }
   
      public string description { get; set; }
     
      public DateTime createdAt { get; set; }
      
      public string createdBy { get; set; }
      //public List<Field> fields { get; set; }
   }
}