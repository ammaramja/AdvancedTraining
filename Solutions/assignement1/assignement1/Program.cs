using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignement1
{
    abstract class birds
    {
        abstract public void print();
    }
    class bird1 : birds
    {
        public override void print()
        {
            Console.WriteLine("This bird can fly and walk!");
        }
    }
    class bird2 : birds
    {
        public override void print()
        {
            Console.WriteLine("This bird can sing and walk!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bird1 b1 = new bird1();
            b1.print();
            bird2 b2 = new bird2();
            b2.print();
            Console.ReadLine();
        }
    }
}
