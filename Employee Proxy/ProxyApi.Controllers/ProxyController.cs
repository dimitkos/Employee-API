using ProxyApi.Interfaces;
using ProxyApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        //[HttpGet]
        //[ActionName("getProxy")]
        //public List<ProxyEmployee> GetEmployees()
        //{
        //    return MyProxyService.GetEmployees();

        //}

        [HttpGet]
        [ActionName("getProxy")]
        public HttpResponseMessage GetEmployees()
        {
            List<ProxyEmployee> proxylist = MyProxyService.GetEmployees();
            if(proxylist !=null)
            {
                return Request.CreateResponse<List<ProxyEmployee>>(HttpStatusCode.OK, proxylist);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Employees");
            }
        }

        //[HttpGet]
        //[ActionName("getProxyID")]
        //public ProxyEmployee GetEmployeeByID(int id)
        //{
        //    return MyProxyService.GetEmployeeByID(id);

        //}

        [HttpGet]
        [ActionName("getProxyID")]
        public HttpResponseMessage GetEmployeeByID(int id)
        {
            ProxyEmployee pe = MyProxyService.GetEmployeeByID(id);

            if(pe != null)
            {
                return Request.CreateResponse<ProxyEmployee>(HttpStatusCode.OK, pe);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Not Found");
            }
        }

        //[HttpPost]
        //[ActionName("createProxy")]
        //public void CreateEmployee([FromBody] ProxyEmployee employee)
        //{
        //    MyProxyService.CreateEmployee(employee);

        //}

        [HttpPost]
        [ActionName("createProxy")]
        public HttpResponseMessage CreateEmployee([FromBody] ProxyEmployee employee)
        {
            if(employee !=null)
            {
                MyProxyService.CreateEmployee(employee);
                return Request.CreateResponse<ProxyEmployee>(HttpStatusCode.Created, employee);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The employee is null");
            }
        }


        //[HttpPut]
        //[ActionName("updateProxy")]
        //public void UpdateEmployee([FromUri]int id, [FromBody] ProxyEmployee employee)
        //{
        //    MyProxyService.UpdateEmployee(id,employee);
        //}

        [HttpPut]
        [ActionName("updateProxy")]
        public HttpResponseMessage UpdateEmployee([FromUri]int id, [FromBody] ProxyEmployee employee)
        {
            //kalw thn get id na dw an yparxei 
            ProxyEmployee proxy = MyProxyService.GetEmployeeByID(id);
            if (proxy != null && employee != null)
            {
                MyProxyService.UpdateEmployee(id, employee);
                return Request.CreateResponse<ProxyEmployee>(HttpStatusCode.OK, employee);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Not Found");
            }
            
        }

        //[HttpDelete]
        //[ActionName("deleteProxy")]
        //public void DeleteEmployee([FromUri]int id)
        //{
        //    MyProxyService.DeleteEmployee(id);
        //}

        [HttpDelete]
        [ActionName("deleteProxy")]
        public HttpResponseMessage DeleteEmployee([FromUri]int id)
        {
            //ProxyEmployee proxy = MyProxyService.GetEmployeeByID(id);
            //deyteros tropos elegxoy
            ProxyEmployee request = MyProxyService.GetEmployees().Where(x => x.Id == id).FirstOrDefault();

            if(request != null)
            {
                MyProxyService.DeleteEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK,"Employee Succesfull Deleted");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Not Found");
            }

        }

    }
}
