using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFirstApproach;

namespace ado.net_application
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeeEntities1())
            {
                //var emp = new EmployeeTable();

                //emp.EmpId = 1;
                //emp.EmpName = "Ammar";
                //emp.Salary = 100000;

                //EmpObj.EmployeeTables.Add(emp);




                EmployeeTable empObj = EmpObj.EmployeeTables.First(i => i.EmpId==2);
                empObj.EmpName = "Mrs Ammar";
                empObj.EmpId = 2;
                empObj.Salary = 1000000;
                

                EmpObj.SaveChanges();
                
                Console.WriteLine("Updated!");

                Console.ReadLine();
            }
        }
    }
}
