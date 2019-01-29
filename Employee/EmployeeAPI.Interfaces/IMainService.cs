using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAPI.Types;

namespace EmployeeAPI.Interfaces
{
    public interface IMainService
    {
        List<MyEmployee> GetEmployees();

        MyEmployee GetEmployeeByID(int employeeid);

        int CreateEmployee(MyEmployee tasktbl);

        int UpdateEmployee(MyEmployee tasktbl);

        void DeleteEmployee(int employeeid);

        void CreateOrUpdate(MyEmployee tasktbl);

    }
}
