using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CDF.DAL.Concrete
{
   public class EFContext : DbContext
   {
      public DbSet<User> Users { get; set; }
      public DbSet<Form> Forms { get; set; }
      public DbSet<Field> Fields { get; set; }
   }
}
