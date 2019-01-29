using ProxyApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Dispatcher;

namespace Employee_Proxy.Models
{
    public class MyCustomAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            Type newType = typeof(ProxyController);
            var newcontrollersAssembly = Assembly.GetAssembly(newType);
            baseAssemblies.Add(newcontrollersAssembly);
            return assemblies;
        }
    }
}