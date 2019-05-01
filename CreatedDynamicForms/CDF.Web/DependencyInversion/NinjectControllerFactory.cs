using CDF.DAL.Concrete;
using CDF.Manager.Abstract;
using CDF.Manager.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDF.Web.DependencyInversion
{
   public class NinjectControllerFactory:DefaultControllerFactory
   {
      private IKernel kernel;
      public NinjectControllerFactory()
      {
         kernel = new StandardKernel();

      }

      private void AddManagerBindings()
      {
         kernel.Bind<IUserManager>().To<UserManager>().WithConstructorArgument("userDal", new UserDAL());
         kernel.Bind<IFormManager>().To<FormManager>().WithConstructorArgument("formDal", new FormDAL());
         kernel.Bind<IFieldManager>().To<FieldManager>().WithConstructorArgument("fielDal", new FieldDAL());


      }
   }
}