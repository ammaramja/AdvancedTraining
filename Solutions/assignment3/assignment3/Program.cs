using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class notify
    {
        public virtual void notification()
        {
            //Console.Write("You will be notified by: ");
        }
    }

    class email : notify
    {
        public override void notification()
        {
            
            Console.WriteLine("Email!");
        }
    }
    class sms : notify
    {
        public override void notification()
        {
            
            Console.WriteLine("SMS!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How would you like to be notified?");
            Console.WriteLine("Press s for sms and e for email");

            notify n1;

            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 's':
                    n1 = new sms();
                    n1.notification();
                    break;
                case 'e':
                    n1 = new email();
                    n1.notification();
                    break;
            }
            Console.ReadLine();
        }
    }
}
