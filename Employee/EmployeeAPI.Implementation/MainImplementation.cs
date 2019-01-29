using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAPI.Interfaces;
using EmployeeAPI.Types;
using Dapper;
using System.Configuration;

namespace EmployeeAPI.Implementation
{
    public class MainImplementation : IMainService
    {
        public List<MyEmployee> GetEmployees()
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Query<MyEmployee>("select * from MyTasktbl").ToList();
            }

        }

        public MyEmployee GetEmployeeByID(int employeeid)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Query<MyEmployee>("select * from MyTasktbl where Id=@Id", new { Id = employeeid }).FirstOrDefault();
            }
        }

        public int CreateEmployee(MyEmployee tasktbl)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                //den xreiazetai to id?
                string insertquery = @"INSERT INTO MyTasktbl (Name,Salary,Birthday,Job) VALUES (@Name,@Salary,@Birthday,@Job) ";
                //db.Execute(insertquery,new { tasktbl.Name,tasktbl.Salary,tasktbl.Birthday,tasktbl.Job});
                var parameters = new { tasktbl.Id, tasktbl.Name, tasktbl.Salary, tasktbl.Birthday, tasktbl.Job };
                int id = db.QuerySingleOrDefault<int>(insertquery, parameters);

                return id;
            }
        }

        public int UpdateEmployee(MyEmployee tasktbl)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                //tasktbl.Id = employeeid;
                string updatequery = @"UPDATE MyTasktbl SET Name=@Name,Salary=@Salary,Birthday=@Birthday,Job=@Job WHERE Id=@Id ";
                //db.Execute(updatequery, new { tasktbl.Id, tasktbl.Name, tasktbl.Salary, tasktbl.Birthday, tasktbl.Job });
                int id = db.QuerySingleOrDefault<int>(updatequery, new { tasktbl.Id, tasktbl.Name, tasktbl.Salary, tasktbl.Birthday, tasktbl.Job });
                return id;
            }
        }

        public void DeleteEmployee(int employeeid)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                string deletequery = @"DELETE FROM  MyTasktbl WHERE Id=@Id ";
                db.Execute(deletequery, new { Id = employeeid });
            }
        }

        public void CreateOrUpdate(MyEmployee tasktbl)
        {

            if (GetEmployeeByID(tasktbl.Id) == null)
            {
                CreateEmployee(tasktbl);
            }
            else
            {
                UpdateEmployee(tasktbl);
            }
        }

        public string GetConnectionString()
        {
            string con = ConfigurationManager.AppSettings["myConnectionString"];
            return con;
        }

    }
}
