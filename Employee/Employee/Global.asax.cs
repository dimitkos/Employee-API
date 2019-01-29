using Employee.Models;
using EmployeeAPI.Controllers;
using EmployeeAPI.Implementation;
using EmployeeAPI.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;


namespace Employee
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var acontainer = new Container();

            acontainer.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            acontainer.Register<IMainService, MainImplementation>(Lifestyle.Scoped);
            acontainer.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            acontainer.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =new SimpleInjectorWebApiDependencyResolver(acontainer);
            //ControllerBuilder.Current.DefaultNamespaces.Add("EmployeeAPI.Controllers");
            //ControllerBuilder.Current.SetControllerFactory(new EmployeeController());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IAssembliesResolver), new MyCustomAssemblyResolver());

        }
    }
}
