using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudEntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            insertdata();
        }

        private static void insertdata()
        {
            StudContext stdcx = new StudContext();
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("enter fees");
            double fee = Convert.ToDouble(Console.ReadLine());

            student std = new student { Sid = id, SName = name, Sfees = fee };
            stdcx.student.Add(std);
            stdcx.SaveChanges();
        }
    }
}
