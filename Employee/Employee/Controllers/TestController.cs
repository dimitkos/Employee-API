using EmployeeAPI.Interfaces;
using EmployeeAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.Controllers
{
    public class TestController : ApiController
    {
        private readonly IMainService MymainService;


        public TestController(IMainService Mymainservice)
        {
            this.MymainService = Mymainservice;
        }
        // GET: api/Test
        public List<MyEmployee> GetEmployees()
        {
            return MymainService.GetEmployees();
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
