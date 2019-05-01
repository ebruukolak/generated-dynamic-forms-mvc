using CDF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CDF.DAL.Concrete
{
   public class EFContext : DbContext
   {
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         Database.SetInitializer<EFContext>(null);
         base.OnModelCreating(modelBuilder);
      }
      public DbSet<User> Users { get; set; }
      public DbSet<Form> Forms { get; set; }
      public DbSet<Field> Fields { get; set; }
   }
}
