using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_august
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays a = new arrays();
            //a.kuchbhi();

            //tuples t = new tuples();
            //t._multiTuple();

            firstOne f;
            f.x = 10;
            Console.WriteLine(f.x);
            f = new firstOne();
            f.changeX(4);
            Console.WriteLine(f.x);
            Console.ReadLine();
        }
    }
    
    public struct firstOne
    {
        public int x;

        public void changeX(int newX)
        {
            x = newX;
        }
    }


    class tuples
    {
        public void _3tuple()
        {
            var threeElementTuple = new Tuple <int,int,int>(1,2,3);

            Console.WriteLine(threeElementTuple.Item2);
            Console.ReadLine();
        }

        public void _multiTuple()
        {
            var threeElementTuple = new Tuple<int, int, int,int,int,int,int,Tuple <int>>(1, 2, 3,4,5,6,7,new Tuple <int>(1));

            Console.WriteLine(threeElementTuple.Rest.Item1);
            Console.ReadLine();
        }

    }

    class arrays
    {
        public void kuchbhi()
        {
            int[] singleDimensionalArray = new int[5];

            int[,] multidimensionalArray = new int[3, 3];

            Console.WriteLine("Multi data:");
            Console.WriteLine(multidimensionalArray.Length);
            //for(int i = 0; i < multidimensionalArray.Length;i++)
            //{
            //    for(int j = 0;j < )
            //}

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];

            Console.WriteLine("Enter data");

            for(int i = 0;i< jaggedArray.Length;i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
