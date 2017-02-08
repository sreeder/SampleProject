using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entitities;
using Domain.Concrete;
using Moq;
using Ninject;

namespace WebUI.Infrastructure
{
   
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //put bindings here
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m=>m.Products).Returns(new List<Product>{
            //    new Product() { Name = "Football", Price =25},
            //    new Product() { Name = "SurfBoard", Price = 179},
            //    new Product() {Name = "Running Shoes", Price = 95}
            //    });

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            kernel.Bind<IProductRepository>().To<EFProductRepository>();

        }
    }
}