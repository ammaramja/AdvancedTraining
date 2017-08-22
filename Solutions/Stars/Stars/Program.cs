using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            starPrinting s1 = new starPrinting();
            s1.print();
            //palindrome p = new palindrome();
            //p.checkPalindrome();
            //deDuplication d = new deDuplication();
            //d.removeDuplicates();

        }
    }
    class palindrome
    {
        public void checkPalindrome()
        {
            Console.WriteLine("Enter a string!");
            string s = Console.ReadLine();
            StringBuilder reverseOfs = new StringBuilder(s.Length);
            for(int i = s.Length -1;i>=0;i--)
            {
                reverseOfs.Append(s[i]);
            }
            Console.WriteLine("Reverse of s is : "+reverseOfs);

            if(s == reverseOfs.ToString())
            {
                Console.WriteLine("It is Palindrome!!!!");
            }
            else
                Console.WriteLine("Not Palindrome!");
            Console.ReadLine();
        }
    }

    class deDuplication
    {
        public void removeDuplicates()
        {
            Console.WriteLine("Enter a string!");
            string s = Console.ReadLine();
            var words = s.Split(' ').Distinct();
            Console.WriteLine(String.Join(" ", words));
            Console.ReadLine(); 

        }
    }

    class starPrinting
    {
        public void print()
        {
            Console.WriteLine("Enter number of levels");

            int numberOfLevels = Convert.ToInt32(Console.ReadLine());

            numberOfLevels += 1;
            int originalNumberOfLevels = numberOfLevels;
            numberOfLevels *= numberOfLevels;
            
            int countOfStar = 0;

            while (numberOfLevels > 0)
            {
                if ((numberOfLevels % originalNumberOfLevels != 0))
                {
                    if((numberOfLevels % originalNumberOfLevels <= countOfStar))// || (numberOfLevels != (originalNumberOfLevels * originalNumberOfLevels)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                else
                {                    
                        countOfStar++;
                        Console.WriteLine();
                    if (originalNumberOfLevels - numberOfLevels == 0)
                        break;       
                }
                
                numberOfLevels--;
            }
            Console.ReadLine();
        }
    }
}
