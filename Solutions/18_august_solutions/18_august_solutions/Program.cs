using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using _18_august_solutions;

namespace _18_august_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a phone number in \"xxx-xxxx\" format");
            //string check = Console.ReadLine();

            //regex_example r = new regex_example();
            //r.number_validation(check);

            //whitespace w = new whitespace();
            //w.removeMultipleWhitespacesOnly();

            //collections c = new collections();
            //c.myCollection();

            //mystringBuilder<string> stringList = new mystringBuilder<string>();
            //stringList.append("Ammar");
            //stringList.append("Amjawala");
            //stringList.append("yellow");
            //var i = stringList.get();

            //foreach(var j in i)
            //{
            //    Console.Write(j);
            //}

            //Console.WriteLine();
            //Console.WriteLine("after removing");
            //stringList.remove("Amjawala");

            //foreach (var j in i)
            //{
            //    Console.Write(j);
            //}
            //Console.WriteLine();
            //Console.WriteLine("After clearing!");
            //stringList.clear();
            //foreach (var j in i)
            //{
            //    Console.Write(j);
            //}

            //Console.ReadLine();

            EmployeeClass e = new EmployeeClass();
            e.initialize();
            Console.ReadLine();

        }
    }

    class SortByName : IComparer<EmployeeClass>
    {
        public int Compare(EmployeeClass x, EmployeeClass y)
        {
            return x.NameProperty.CompareTo(y.NameProperty);
        }

    }

    class SortByEmpCode : IComparer<EmployeeClass>
    {
        public int Compare(EmployeeClass x, EmployeeClass y)
        {
            return x.EmpCodeProperty.CompareTo(y.EmpCodeProperty);
        }
    }

    class EmployeeClass : IComparable<EmployeeClass>
    {
        string name;
        int emp_code,salary;

        List<EmployeeClass> myList = new List<EmployeeClass>();

        public EmployeeClass()
        {

        }
            
        public EmployeeClass(string name,int code, int salary)
        {
            NameProperty = name;
            SalaryProperty = salary;
            EmpCodeProperty = code;

        }

        public void initialize()
        {
            myList.Add(new EmployeeClass("A",1,1000));
            myList.Add(new EmployeeClass("B", 3, 100000));
            myList.Add(new EmployeeClass("CD", 5, 100000));
            myList.Add(new EmployeeClass("CC", 12, 10050));
            myList.Add(new EmployeeClass("E", -4, 10300));
            myList.Add(new EmployeeClass("AD", 100, 41000));
            myList.Add(new EmployeeClass("AB", 53, 15000));

            myList.Sort();

            foreach(EmployeeClass e in myList)
            {
                Console.WriteLine(e.NameProperty);
            }
            Console.WriteLine();
        }

        public string NameProperty {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int EmpCodeProperty { get { return emp_code; } set {emp_code= value; } }

        public int SalaryProperty { get { return salary; } set { salary = value; } }

        public int CompareTo(EmployeeClass other)
        {
            return NameProperty.CompareTo(other.NameProperty);
        }

        
    }
      
    class mystringBuilder<T>
    {
        List<T> mylist = new List<T>();

        public void append(T t1)
        {
            mylist.Add(t1);            
        }

        public List<T> get()
        {
            return mylist;
        }

        public void remove(T t1)
        {
            mylist.Remove(t1);
        }

        public void clear()
        {
            mylist.Clear();
        }
    }
    class collections
    {
        public void myCollection()
        {
            SortedList s = new SortedList();

            s.Add(1,"Ammar");
            s.Add(2,"Arwa");

            Console.WriteLine("After Additon");

            for(int i=0;i <= s.Count;i++)
            {
                Console.WriteLine(s[i]);
            }

            s.SetByIndex(0,"hola");
            Console.WriteLine("After updation:");


            for (int i = 0; i <= s.Count; i++)
            {
                Console.WriteLine(s[i]);
            }

            s.RemoveAt(0);

            Console.WriteLine("After deletion");

            foreach (DictionaryEntry d in s)
            {
                Console.WriteLine(d.Value);
            }

            Console.ReadLine();


        }
    }
    class whitespace
    {
        public void removeMultipleWhitespacesOnly()
        {
            Console.WriteLine("Enter a string!");

            string s = Console.ReadLine();
            string replacementString = " ";
            

            string newString = (string)Regex.Replace(s, "\\s+", replacementString);

            Console.WriteLine("After removing extra whitespaces : "+ newString);
            Console.ReadLine();
        }
    }
    class regex_example
    {
        public void number_validation(string s)
        {
            Regex r = new Regex(@"^\d{3}-\d{4}$");
            if(r.Match(s).Success)
            {
                Console.WriteLine("Valid!");
            }
            else
                Console.WriteLine("InValid!!!!");
            Console.ReadLine();
        }
        
    }
        
}
