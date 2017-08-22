using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //a1 a = new a1();
            //a.twentyFive();

            //a2 a = new a2();
            //a.rectangle();

            ////a5 a = new a5();
            ////a.primeNumbers();

            //a7 a = new a7();
            //a.reverse();

            //a8 a = new a8();
            //a.leapCheck();

            //a9 a = new a9();
            //a.consumer();

            //a10 a = new a10();
            //a.numberPattern();

            //a11 a = new a11();
            //a.diamond();


        }
    }
    class a11
    {
        public void diamond()
        {
            Console.WriteLine("Enter height of the diamond! (must be odd)");
            int height = Convert.ToInt32(Console.ReadLine());
            int height2 = height/2;
            int width2 = 1;

            for(int i = 0;i<height;i++)
            {
                if (i < height / 2)
                {
                    for (int j = 0; j < height2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (2 * i) + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    height2--;
                }
                else if(i == height/2)
                {
                    for (int j=0;j<height;j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    height2 = (height / 2) - 1;
                }
                else
                {
                    for (int j = 0; j < width2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = ((2 * height2) + 1); j > 0 ; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    height2--;
                    width2++;
                }

            }
            Console.ReadLine();
            
        }
    }
    class a10
    {
        public void numberPattern()
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int width2 = width;

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < width2; i++)
                {
                    Console.Write(num);
                }
                width2--;
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }

    class a9
    {
        public void consumer()
        {
            Console.WriteLine("Cut Id:");
            int cust_id = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Unit:");
            int unit = Convert.ToInt32(Console.ReadLine());

            decimal cost = 100;

            if(unit < 199)
            {
                cost = (decimal) (unit * 1.20);
            }
            else if(unit >= 200 && unit < 400)
            {
                cost = (decimal)(unit * 1.50);
            }
            else if (unit >= 400 && unit < 600)
            {
                cost = (decimal)(unit * 1.80);
            }
            else if (unit >= 600)
            {
                cost = (decimal)(unit * 2);
            }

            if(cost > 400)
            {
                cost += (cost * (decimal)0.15);
            }
            Console.WriteLine("Cost : "+cost);
            Console.ReadLine();

        }
    }
        
    class a8
    {
        public void leapCheck()
        {
            Console.WriteLine("ENTER YEAR:");
            int NUM = Convert.ToInt32(Console.ReadLine());

            if(NUM % 400 == 0)
            {
                Console.WriteLine("Leap year!");
            }
            else
            {
                if((NUM % 100!=0) && (NUM % 4 == 0))
                {
                    Console.WriteLine("Leap year!");
                }
                else
                {
                    Console.WriteLine("Not a Leap year");
                }

            }
            Console.ReadLine();
        }
    }
    class a7
    {
        public void reverse()
        {
            Console.WriteLine("String please ");
            string s = Console.ReadLine();
            //foreach(char i in s.Reverse())
            //    {
            //    Console.Write(i);
            //}
            string[] words = s.Split();
            for(int i=words.Length -1;i>=0;i--)
            {
                Console.Write(words[i]+" ");
            }
            Console.ReadLine();
        }
    }
    class a6
    {
        public void sum()
        {
            Console.WriteLine("Enter a number!");

            int number = Convert.ToInt32(Console.ReadLine());
            string s = number.ToString();
            int sum = 0;
            for (int i=0;i<s.Length;i++)
            {
                sum += (s[i]-'0');
            }
            Console.WriteLine("Sum "+sum);
            Console.ReadLine();
        }
    }

    class a5
    {
        public bool isPrime(int num)
        {
            //if (num == 2)
            //    {
            //    return true;
            //}
            int x = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= x; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void primeNumbers()
        {
            int sum = 2;
            int count = 1;
            int i = 3;
            while (count < 1000)
            {
                    if (isPrime(i))
                    {
                        //Console.WriteLine(i);
                        sum += i;
                        count++;
                    }
                i++;
                
            }
            Console.WriteLine("Sum: "+sum);
            Console.ReadLine();
        }
    }
    class a4
    {
        public void longestWord()
        {
            Console.WriteLine("String");
            String s = Console.ReadLine();
            String[] words = s.Split();
            int max = -99;
            string longWord="";
            foreach(string word in words)
            {
                if(word.Length > max)
                {
                    max = word.Length;
                    longWord = word;
                }
            }
            Console.WriteLine("longestWord : "+longWord);
            Console.ReadLine();
        }
    }
    class a3
    {
        public void celciusToFaren()
        {
            Console.WriteLine("Enter temperature in celcius!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Farenheit = "+((1.8*number)+32));
            Console.ReadLine();
        }
    }
    class a2
    {
        public void rectangle()
        {
            Console.WriteLine("Enter a digit!");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i%4==0)
                    {
                        Console.Write(number);
                    }
                    else
                    {
                        if (j % 2 == 0)
                            Console.Write(number);
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class a1
    {
        public void twentyFive()
        {
            Console.WriteLine("Enter a digit!");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("" + number + " ");
                    }
                    else
                    {
                        Console.Write(number);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
