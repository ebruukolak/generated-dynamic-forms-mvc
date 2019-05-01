using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CDF.Web.Models
{
   public class UserViewModel
   {
      [Required(ErrorMessage ="Please,enter username")]
      [Display(Name = "User Name")]
      public string username { get; set; }
      [Required(ErrorMessage = "Please,enter password")]
      [DataType(DataType.Password)]
      [Display(Name = "Password")]
      public string password { get; set; }
   }
}