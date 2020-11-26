using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class EmployeeRepository : IEmployee

    {

        private OrgEntities DBcontext;

        public EmployeeRepository(OrgEntities objempcontext)
        {
            this.DBcontext = objempcontext;
        }

        public void InsertEmployee(Employee employee)

        {

            DBcontext.Employees.Add(employee);

            DBcontext.SaveChanges();

        }

        public IEnumerable<Models.Employee> GetEmployees()

        {

            return DBcontext.Employees.ToList();

        }

        public Models.Employee GetEmployeeByID(int EmployeeId)
        {

            return DBcontext.Employees.Find(EmployeeId);

        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}