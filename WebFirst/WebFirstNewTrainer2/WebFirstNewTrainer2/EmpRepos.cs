using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFirstNewTrainer2
{
    public class EmpRepos
    {
        public List<Department> GetDepartments()
        {
            EmpDeptContext edc = new EmpDeptContext();
          //  return edc.Departments.Include("Employees").ToList();
         // return edc.Departments.Include("Employees").Where(emp=> emp.D_Location.Equals("Shirdi")).ToList();

            var qry = from dep in edc.Departments.Include("Employees") where dep.D_Location.Equals("kop")select dep;
            return qry.ToList();
        }
    }
}