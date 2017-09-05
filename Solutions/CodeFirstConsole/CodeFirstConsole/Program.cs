using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstLibrary;

namespace CodeFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DeptContext())
            {
                var deptObj = new Department { DeptId = 1, DeptName = "HR",location="Pune" };
                dept.Depts.Add(deptObj);
                dept.SaveChanges();
                Console.WriteLine("Inserted!");

                Console.ReadLine();
            }
        }
    }
}
