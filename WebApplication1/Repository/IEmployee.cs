using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    interface IEmployee
    {
        void InsertEmployee(Employee Employee); 

        IEnumerable<Employee> GetEmployees(); 

        Employee GetEmployeeByID(int EmployeeId); 

        void Save();
    }
}
