using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using partial_classes;
using static_classes;
using extendedMethod;
using interface_example;
using vehiclesNamespace;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //developer1 d = new developer1();
            //d.display();
            //d.print()
            //    ;
            //Console.ReadLine()
            //    ;

            //Console.WriteLine(rectangle.area(3.5F, 5.5F));
            //Console.ReadLine();

            //string s;
            //s = Console.ReadLine();
            //s.stringToIntConverter();
            //Console.ReadLine();

            //employee m = new manager();
            //m.cal_salary();
            //m = new clerk();
            //m.cal_salary();
            //Console.ReadLine();

            //Console.WriteLine("Enter a number!! (integer-only)");

            //int a = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}".PadLeft(15),a,i,a*i);
            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter stream of words!");
            //string s = Console.ReadLine();

            //s.wordFirstLetterUppercase();
            //Console.ReadLine();

            Console.WriteLine("BMW:1 and Indigo:2");
            int ch = Convert.ToInt32(Console.ReadLine());

            Vehicles v;
            if (ch == 1)
            {
                v = new BMW();
                //v.commonFeatures();
                v.specialFeatures();
                Console.ReadLine();
            }
            else if(ch==2)
            {
                v = new Indigo();
                //v.commonFeatures();
                v.specialFeatures();
                Console.ReadLine();
            }
                

        }
    }

    
}

namespace partial_classes
{
    partial class developer1
    {
        public void print()
        {
            Console.WriteLine("Hey there! I am developer1");
        }
    }

    partial class developer1
    {
        public void display()
        {
            Console.WriteLine("Hey there! I am developer2");
        }
    }
}

namespace static_classes
{
    static class rectangle
    {
        static public float area(float l,float b)
        {
            return l * b;
        }
    }
}

namespace extendedMethod
{
    static class myExtended
    {
        public static void stringToIntConverter(this string s)
        {
            Console.WriteLine(Convert.ToInt32(s));
        }

        public static void wordFirstLetterUppercase(this string s)
        {
            StringBuilder ss = new StringBuilder();

            string[] words = s.Split();

            foreach(string word in words)
            {
                for(int i=0;i< word.Length;i++)
                {
                    if (i == 0)
                        ss.Append(word[i].ToString().ToUpper());

                    else
                        ss.Append(word[i]);
                }
                ss.Append(" ");
            }

            Console.WriteLine("After conversion: "+ss);
        }
    }
    
        
}

namespace interface_example
{
    interface employee
    {
        void cal_salary();
    }

    class manager:employee
    {
        public void cal_salary()
        {
            Console.WriteLine("Manager salary is : "+10000);
        }
    }

    class clerk : employee
    {
        public void cal_salary()
        {
            Console.WriteLine("Clerk salary is : " + 1000);
        }
    }
}

namespace vehiclesNamespace
{
    interface Vehicles
    {
        void specialFeatures();
    }

    class Indigo:Vehicles
    {

        public void specialFeatures()
        {
            Console.WriteLine("It has big.....Trunk..;)");
        }
    }
    class BMW : Vehicles
    {
        public void specialFeatures()
        {
            Console.WriteLine("Popular h bhai!");
        }
    }
}