using ProxyApi.Interfaces;
using ProxyApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProxyApi.Controllers
{
    public class ProxyController : ApiController
    {
        private readonly IProxyService MyProxyService;

        public ProxyController(IProxyService MyProxyService)
        {
            this.MyProxyService = MyProxyService;
        }

        [HttpGet]
        [ActionName("getProxy")]
        public List<ProxyEmployee> GetEmployees()
        {
            return MyProxyService.GetEmployees();

        }

        [HttpGet]
        [ActionName("getProxyID")]
        public ProxyEmployee GetEmployeeByID(int id)
        {
            return MyProxyService.GetEmployeeByID(id);

        }

        [HttpPost]
        [ActionName("createProxy")]
        public void CreateEmployee([FromBody] ProxyEmployee employee)
        {
            MyProxyService.CreateEmployee(employee);

        }

        [HttpPut]
        [ActionName("updateProxy")]
        public void UpdateEmployee([FromUri]int id, [FromBody] ProxyEmployee employee)
        {
            MyProxyService.UpdateEmployee(id,employee);
        }

        [HttpDelete]
        [ActionName("deleteProxy")]
        public void DeleteEmployee([FromUri]int id)
        {
            MyProxyService.DeleteEmployee(id);
        }

    }
}
