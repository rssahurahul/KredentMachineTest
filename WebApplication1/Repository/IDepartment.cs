using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    interface IDepartment
    {
        void InsertDepartment(Department Department); 

        IEnumerable<Department> GetDepartments();

        Department GetDeptByID(int EmployeeId); 

        void Save();
    }
}
