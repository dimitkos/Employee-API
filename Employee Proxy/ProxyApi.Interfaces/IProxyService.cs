using ProxyApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyApi.Interfaces
{
    public interface IProxyService
    {
        List<ProxyEmployee> GetEmployees();

        ProxyEmployee GetEmployeeByID(int employeeid);

        void CreateEmployee(ProxyEmployee employee);

        void UpdateEmployee(int employeeid, ProxyEmployee employee);

        void DeleteEmployee(int employeeid);
    }
}
