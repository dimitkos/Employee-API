using EmployeeAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Dispatcher;

namespace Employee.Models
{
    public class MyCustomAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            Type myType = typeof(EmployeeController);
            var controllersAssembly = Assembly.GetAssembly(myType);
            baseAssemblies.Add(controllersAssembly);
            return assemblies;
        }
    }
}