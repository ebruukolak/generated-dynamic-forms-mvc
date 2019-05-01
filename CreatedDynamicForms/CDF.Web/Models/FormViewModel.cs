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
      [Display(Name = "Name")]
      public string name { get; set; }
      [Display(Name = "Description")]
      public string description { get; set; }
      [Display(Name = "Created Date")]
      public DateTime createdAt { get; set; }
      [Display(Name = "Created User")]
      public string createdBy { get; set; }
      public List<Field> fields { get; set; }
   }
}