using ProxyApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyApi.Types;
using RestSharp;

namespace ProxyApi.Implementation
{
    public class ProxyImplementation : IProxyService
    {

        public List<ProxyEmployee> GetEmployees()
        {
            var client = new RestClient("http://localhost:50428/");
            var request = new RestRequest("api/employee/getEmployees", Method.GET);
            //var queryResult = client.Execute<List<ProxyEmployee>>(request).Data;
            var queryResult = client.Get<List<ProxyEmployee>>(request).Data;
            return queryResult;
        }


        public ProxyEmployee GetEmployeeByID(int employeeid)
        {
            var client = new RestClient("http://localhost:50428/");
            var request = new RestRequest("api/employee/getEmployeeByID/{id}", Method.GET);
            //request.AddUrlSegment("id", employeeid);
            request.AddParameter("id", employeeid);
            //var queryResult = client.Execute <List <ProxyEmployee>> (request).Data;
            var queryResult = client.Get<ProxyEmployee>(request).Data;

            return queryResult;

        }


        public void CreateEmployee(ProxyEmployee employee)
        {
            var client = new RestClient("http://localhost:50428/");
            var request = new RestRequest("api/employee/createEmployee", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new ProxyEmployee
            {
                Id = employee.Id,
                Name = employee.Name,
                Salary = employee.Salary,
                Job = employee.Job,
                Birthday = employee.Birthday

            });
            client.Post(request);
        }

        public void UpdateEmployee(int employeeid,ProxyEmployee employee)
        {
            var client = new RestClient("http://localhost:50428/");
            var request = new RestRequest("api/employee/updateEmployee/"+employeeid, Method.PUT);
            //request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(employee);
            //request.AddBody(new ProxyEmployee
            //{
            //    Id = employee.Id,
            //    Name = employee.Name,
            //    Salary = employee.Salary,
            //    Job = employee.Job,
            //    Birthday = employee.Birthday

            //});
            client.Put(request);
        }

        public void DeleteEmployee(int employeeid)
        {
            var client = new RestClient("http://localhost:50428/");
            var request = new RestRequest("api/employee/deleteEmployee/" + employeeid, Method.DELETE);
            client.Delete(request);
        }
    }
}
