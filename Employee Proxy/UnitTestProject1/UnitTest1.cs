using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyApi.Implementation;
using ProxyApi.Types;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetEmployees()
        {
            ProxyImplementation service = new ProxyImplementation();

            List<ProxyEmployee> proxylist = service.GetEmployees();

            Xunit.Assert.NotNull(proxylist);
            Xunit.Assert.True(proxylist.Count > 0);
        }

        [TestMethod]
        public void GetEmployeeByID()
        {
            ProxyImplementation service = new ProxyImplementation();
            ProxyEmployee employee = service.GetEmployeeByID(1);

            Xunit.Assert.NotNull(employee);
            Xunit.Assert.True(employee.Id == 1);

        }

        [TestMethod]
        public void CreateEmployee()
        {


            ProxyImplementation service = new ProxyImplementation();

            ProxyEmployee employee = new ProxyEmployee()
            {
                Id=1041,
                Name = "Dimitris K. Kosmas",
                Salary = 25000,
                Birthday = new DateTime(1998, 04, 30, 13, 14, 19),
                Job = "ProxyEmployee"

            };
            service.CreateEmployee(employee);
            List<ProxyEmployee> proxylist = service.GetEmployees();

            Xunit.Assert.True(proxylist.Exists(x=> x.Name == "Dimitris K. Kosmas" && x.Salary ==25000));

        }

        [TestMethod]
        public void UpdateEmployee()
        {
            ProxyImplementation service = new ProxyImplementation();
            ProxyEmployee employee = new ProxyEmployee()
            {
                Id = 1054,
                Name = "Dimitris Kosmas",
                Salary = 130000,
                Birthday = new DateTime(1998, 04, 30, 13, 14, 19),
                Job = ".net developer"

            };
            service.UpdateEmployee(1054,employee);
            List<ProxyEmployee> proxylist = service.GetEmployees();
            Xunit.Assert.True(proxylist.Exists(x => x.Id == 1054 && x.Name == "Dimitris Kosmas" && x.Salary == 130000 && x.Id == 1054 ));

        }

        [TestMethod]
        public void DeleteteEmployee()
        {
            ProxyImplementation service = new ProxyImplementation();
            service.DeleteEmployee(1053);
            List<ProxyEmployee> proxylist = service.GetEmployees();
            Xunit.Assert.False(proxylist.Exists(x => x.Id == 1053));
                
        }


    }
}
