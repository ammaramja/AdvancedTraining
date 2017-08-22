using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using custom;

namespace day4
{
    class Program
    {
        static int Main(string[] args)
        {
            custom.bb b = new custom.bb();
            b.myWriteLine("hola");
            //Console.ReadLine();
            custom.nestedOne.cc dummtObject = new custom.nestedOne.cc();

            dummtObject.myReadLine();
            //Main(2);
            return -1;
        }
        `
    }
    class tryyy
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Custom main");
        Console.ReadLine();
    }
}
}

namespace custom
{
    class bb
    {
        public void myWriteLine(string toBePrinted)
        {
            Console.WriteLine(toBePrinted);
        }
    }

    namespace nestedOne
    {
        class cc
        {
            public void myReadLine()
            {
                Console.ReadLine();
            }
        }
    }
}