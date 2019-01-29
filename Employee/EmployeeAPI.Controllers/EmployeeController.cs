using EmployeeAPI.Interfaces;
using EmployeeAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmployeeAPI.Controllers
{
    //[RoutePrefix("employee")]
    public class EmployeeController : ApiController
    {
        private readonly IMainService MymainService;

        public EmployeeController(IMainService Mymainservice)
        {
            this.MymainService = Mymainservice;
        }

        
        [HttpGet]
        [ActionName("getEmployees")]
        public List<MyEmployee> GetEmployees()
        {
            return MymainService.GetEmployees();

        }

        [HttpGet]
        [ActionName("getEmployeeByID")]
        public MyEmployee GetEmployeeByID(int id)
        {
            return MymainService.GetEmployeeByID(id);

        }

        [HttpPost]
        [ActionName("createEmployee")]
        public void CreateEmployee([FromBody] MyEmployee employee)
        {
            MymainService.CreateEmployee(employee);
        }

        [HttpPut]
        [ActionName("updateEmployee")]
        public void UpdateEmployee([FromUri]int id, [FromBody] MyEmployee employee)
        {
            
            MymainService.UpdateEmployee(employee);
        }

        [HttpDelete]
        [ActionName("deleteEmployee")]
        public void DeleteEmployee([FromUri] int id)
        {
            MymainService.DeleteEmployee(id);
        }

        [HttpPost]
        [ActionName("createorupdate")]
        public void CreateOrUpdate([FromUri]int id,[FromBody] MyEmployee employee)
        {
            MymainService.CreateOrUpdate(employee);
        }

    }
}
