using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CDF.Web.Models
{
   public class FieldViewModel
   {
      public bool required { get; set; }
      [Required(ErrorMessage = "Please,enter field's name")]
      public string name { get; set; }
      [Required(ErrorMessage = "Please,select field's data type")]
      public string dataType { get; set; }
      public int formId { get; set; }
   }
}