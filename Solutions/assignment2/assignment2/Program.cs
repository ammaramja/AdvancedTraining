using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for addition and 0 to terminate!");
            int sum = 0;
            int num;
            do
            {
                 num = Convert.ToInt32(Console.ReadLine());

                sum += num;
            }
            while (num != 0);

            Console.WriteLine("Addition is "+sum);
            Console.ReadLine();
        }
    }
}
