using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class DepartmentRepository : IDepartment

    {

        private OrgEntities DBcontext;

        public DepartmentRepository(OrgEntities objempcontext)
        {
            this.DBcontext = objempcontext;
        }

        public void InsertDepartment(Department department)

        {

            DBcontext.Departments.Add(department);

            DBcontext.SaveChanges();

        }

        public IEnumerable<Models.Department> GetDepartments()

        {

            return DBcontext.Departments.ToList();

        }

        public Models.Department GetDeptByID(int DepartmentId)
        {

            return DBcontext.Departments.Find(DepartmentId);

        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}