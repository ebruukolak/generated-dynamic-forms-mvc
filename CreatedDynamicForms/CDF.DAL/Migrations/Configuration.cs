namespace CDF.DAL.Migrations
{
   using System;
   using System.Data.Entity;
   using System.Data.Entity.Migrations;
   using System.Linq;

   internal sealed class Configuration : DbMigrationsConfiguration<CDF.DAL.Concrete.EFContext>
   {
      public Configuration()
      {
         AutomaticMigrationsEnabled = true;
         ContextKey = "CDF.DAL.Concrete.EFContext";
         //AutomaticMigrationDataLossAllowed = true;

      }

      protected override void Seed(CDF.DAL.Concrete.EFContext context)
      {
         //  This method will be called after migrating to the latest version.

         //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
         //  to avoid creating duplicate seed data.
      }
   }
}
