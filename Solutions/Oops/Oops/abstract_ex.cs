using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Oops
//{
//    class inheritance_ex
//    {
//        public string hello()
//        {
//            return "hello";
//        }
//    }

//    class derived1 : inheritance_ex
//    {
//        public void kay_zhala()
//        {
//            Console.WriteLine("in d1;");
//            Console.WriteLine(hello());
//            Console.ReadLine();
//        }
//    }


//}

namespace hola
{
   public class base1
    {
        public virtual void yellow()
    {
        Console.WriteLine("bbbbbbbbbbbbbbb");
    }
}

 public class derived : base1
    {
    public override void yellow()
    {
        Console.WriteLine("dddddddd");
    }
    }
}

