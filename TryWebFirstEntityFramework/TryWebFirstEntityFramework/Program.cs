using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryWebFirstEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            insertempdata();
            //insertdeptdata();
        }

        private static void insertempdata()
        {
            EmpDepartContext edcx = new EmpDepartContext();

            Console.WriteLine("Enter Emp ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Emp Designation");
            string desgination = Console.ReadLine();
            Console.WriteLine("Enter Emp Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Emp Department ID");
            int Depid = Convert.ToInt32(Console.ReadLine());
           
            Employee emp = new Employee { EId = id, EName = name, EDesignation = desgination, ESalary = salary, DId = Depid };
            edcx.employees.Add(emp);
           edcx.SaveChanges();


          
        }

        private static void insertdeptdata()
        {
            EmpDepartContext edc = new EmpDepartContext();

           
            Console.WriteLine("Enter Emp Department ID");
            int Depid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp Department Name");
            string department_name = Console.ReadLine();
            Console.WriteLine("Enter Emp Department Address");
            string address = Console.ReadLine();

          

            Department dept = new Department { DId = Depid, DName = department_name, DAddress = address };
            edc.Departments.Add(dept);
            edc.SaveChanges();
        }
    }
}
