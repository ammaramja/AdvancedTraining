using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_august
{
    class Employee
    {
        public int ID;
        public string Name, DepartmentName, ProjectName;

        public Employee()
        {

        }
        Employee(int id,string name,string department, string project)
        {

            ID = id;
            Name = name;
            DepartmentName = department;
            ProjectName = project;
        }

        public List<Employee> EmployeeCollection = new List<Employee>();

        public void addEmployees()
        {
            EmployeeCollection.Add(new Employee(203456876, "John", "Delivery","Elli mae 1"));

            EmployeeCollection.Add(new Employee(203456876, "Ammar", "CEO", "Elli mae 2"));

            EmployeeCollection.Add(new Employee(203456876, "Anusha", "Manager", "Elli mae 3"));

            EmployeeCollection.Add(new Employee(203456876, "Arwa", "CFO", "Elli mae 2"));

            EmployeeCollection.Add(new Employee(203456876, "C1", "Clerk", "Elli mae 1"));

            EmployeeCollection.Add(new Employee(203456876, "C2", "Delivery", "Elli mae 3"));

            EmployeeCollection.Add(new Employee(203456876, "D1", "Delivery", "Elli mae 3"));

            EmployeeCollection.Add(new Employee(203456876, "D2", "Production", "Elli mae 1"));

            EmployeeCollection.Add(new Employee(203456876, "Karant", "CTO", "Elli mae 2"));

        }
    }
    class Program
    {
        public delegate int  CalculateSimpleInterest(int rate, int year, int principal);

        public int getTotalInterest(int rate, int year, int principal)
        {
            return (int)((principal * rate * year)/100);
        }

        public int getRate(int interest, int year, int principal)
        {
            return (int)(interest * 100)/(principal * year);
        }

        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.addEmployees();

            var l = e.EmployeeCollection.Where(item => item.Name == "Anusha");

            foreach(var i in l)
            {
                Console.WriteLine(i.Name + " is the "+ i.DepartmentName);
            }

            if(!e.EmployeeCollection.Any(item => item.Name=="Basit"))
            {
                Console.WriteLine("Basit doesnt exist!");
            }
            Console.ReadLine();

            var ll = e.EmployeeCollection.Select(item => item.DepartmentName = "delivery");

            //foreach (var i in ll)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //var ld = e.EmployeeCollection.GroupBy(i => i).Select(i => i.Name == "Anusha");
            //foreach (var id in ld)
            //{
            //    Console.WriteLine(id.);
            //}
            Console.ReadLine();

            //Program p = new Program();
            //callDelegate(p);

            //iznt i2 = 0;
            //try
            //{
            //    int ten = 10;
            //    i2 =checked(2147483647 + ten);
            //}
            //catch(SystemException)
            //{
            //    Console.WriteLine((i2));
            //}
            //Console.ReadLine();

            //if (i2 is float)
            //{
            //    Console.WriteLine("Its a float");
            //}
            //else
            //{
            //    Console.WriteLine("Not a float");
            //}
            //Console.WriteLine(sizeof(char));
            //Console.ReadLine();

            //object[] objs = new object[3];
            //objs[0] = "sfgregerg";
            //objs[1] = 11;
            //objs[2] = "Ammar";

            //foreach (object i in objs)
            //{
            //    string s = i as string;
            //    if (s != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    else
            //        Console.WriteLine("Not a string!");
            //    Console.ReadLine();
            //}

        }
        public static void callDelegate(Program p)
    {
            //Func<int, int, int, int> CalculateSimpleInterest = new Func<int, int, int, int>(p.getTotalInterest);

            //CalculateSimpleInterest c = delegate (int principal, int rate, int time)
            //{
            //    Console.WriteLine(principal * rate * time / 100);
            //};   

            //c(5, 7000, 2);

            //CalculateSimpleInterest c = (principal,rate,time) =>
            //{
            //    Console.WriteLine(principal * rate * time / 100);
            //};
            //c(5,8000,2);
            
            CalculateSimpleInterest c = new CalculateSimpleInterest(p.getTotalInterest);

            Console.WriteLine(c(5, 4000, 2));
            c += new CalculateSimpleInterest(p.getRate);

            Console.WriteLine(c(400,2,4000));

            Console.ReadLine();

    }
}

    
}
