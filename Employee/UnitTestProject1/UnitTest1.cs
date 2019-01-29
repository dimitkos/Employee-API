using System;
using System.Collections.Generic;
using EmployeeAPI.Implementation;
using EmployeeAPI.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void GetEmployees()
        {
            MainImplementation service = new MainImplementation();
            List<MyEmployee> employees = service.GetEmployees();

            Xunit.Assert.NotNull(employees);
            Xunit.Assert.True(employees.Count > 0);
        }

        [TestMethod]
        public void GetEmployeeByID()
        {
            MainImplementation service = new MainImplementation();
            MyEmployee employee = service.GetEmployeeByID(1);

            Xunit.Assert.NotNull(employee);
            Xunit.Assert.True(employee.Id == 1);
            //Xunit.Assert.True(employee.Count == 1);
            //Xunit.Assert.True(employee.Exists(x => x.Id == 1));

        }

        [TestMethod]
        public void CreateEmployee()
        {
            MainImplementation service = new MainImplementation();
            MyEmployee newtbl = new MyEmployee()
            {
                Name = "nikos",
                Salary = 9999,
                Birthday = new DateTime(1998, 04, 30, 13, 14, 19),
                Job = "Hr"

            };

            int result = service.CreateEmployee(newtbl);

            Xunit.Assert.Equal(result, newtbl.Id);
        }

        [TestMethod]
        public void UpdateEmployee()
        {
            MainImplementation service = new MainImplementation();
            MyEmployee newtbl = new MyEmployee()
            {
                Id = 18,
                Name = "Marios",
                Salary = 7777,
                Birthday = new DateTime(1998, 04, 30, 13, 14, 19),
                Job = "HR"
            };

            int result = service.UpdateEmployee(newtbl);

            //Xunit.Assert.True(result == newtbl.Id);

            //to kainoyrio tbl tha to kanw getemployeei by id 
            //MyTasktbl getbyidtbl = new MyTasktbl();
            //MyTasktbl employee = service.GetEmployeeByID(1);
            //Xunit.Assert.True(employee.Exists(x => x.Id == 2));
            //Xunit.Assert.True(employee.Exists(x => x.Name.Equals("Panos")));
            //Xunit.Assert.True(employee.Exists(x => x.Salary == 7777));
            //Xunit.Assert.True(employee.Exists(x => x.Birthday ==new DateTime(1998, 04, 30, 13, 14, 19)));
            //Xunit.Assert.True(employee.Exists(x => x.Job.Equals("HR")));

        }

        [TestMethod]
        public void DeleteEmployee()
        {
            MainImplementation service = new MainImplementation();

            service.DeleteEmployee(17);

            MyEmployee employee = service.GetEmployeeByID(17);

            Xunit.Assert.Null(employee);
            //Xunit.Assert.True(employee.Count == 0);
        }

        [TestMethod]
        public void CreateOrUpdate()
        {
            MainImplementation service = new MainImplementation();
            var tasktbl = new MyEmployee()
            {
                Id = 20,
                Name = "manos",
                Salary = 4444,
                Birthday = new DateTime(1998, 04, 30, 13, 14, 19),
                Job = "HRrrrrrr"
            };
            service.CreateOrUpdate(tasktbl);

        }

    }
}
