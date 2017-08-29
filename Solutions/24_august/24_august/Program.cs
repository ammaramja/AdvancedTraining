using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _24_august
{
    class Program
    {
        static Semaphore s = new Semaphore(3, 3);

        static void Main(string[] args)
        {
            //Thread t = new Thread(f1);
            //t.IsBackground = true;
            //t.Start();
            //Console.WriteLine("Main!");
            //Thread t2 = new Thread(f1);
            //t2.Start();

            //Console.WriteLine("In main again!");

            //Semaphore

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t = new Thread(f1);
            //    t.Name = "thread " + i;
            //    t.Start();
            //}
            //Console.ReadLine();

            //Question1 and 2
            //Thread[] arrayOfThreads = new Thread[10];

            //for(int i =0; i<10;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        arrayOfThreads[i] = new Thread(question12);
            //        arrayOfThreads[i].Name = "Thread " + i;
            //        arrayOfThreads[i].IsBackground = true;
            //    }
            //    else
            //    {
            //        arrayOfThreads[i] = new Thread(question1);
            //        arrayOfThreads[i].Name = "Thread " + i;
            //    }

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    arrayOfThreads[i].Start();
            //}

            Program p = new Program();

            //Thread t1 = new Thread(p.divide);
            //t1.Start();
            //p.divide();

            int param1, param2;

            //ThreadPool.QueueUserWorkItem(p.tpool);
            //ThreadPool.QueueUserWorkItem(p.tpool2);
            //ThreadPool.GetMaxThreads(out param1,out param2);
            //Console.WriteLine(param1);
            //Console.WriteLine(param2);


            Task t1 = new Task(p.tpool);
            t1.Start();
            Console.ReadLine();

            Console.ReadLine();
                        

        }
        public void tpool()
        {
            Console.WriteLine("In tpool");
        }

        public void tpool2(object aiseh)
        {
            Console.WriteLine("In tpool2");
        }
        public void divide()
        {
            int i = 0;

            int num1;
            int num2;


            Random r = new Random();

            lock (this)
            {
                while (i < 1000000)
                {
                    num1 = r.Next(1, 10000);
                    num2 = r.Next(1, 1000);

                    int result = num1 / num2;
                    Console.WriteLine("Result : {0} of num1 : {1} and num2 : {2}", result, num1, num2);
                    num1 = 0;
                    num2 = 0;
                    i++;
                }
            }
        }

        public static void question1()
        {
            Console.WriteLine("I am {0} and foreground thread!",Thread.CurrentThread.Name);
        }

        public static void question12()
        {
            Random r = new Random();
            int rr = r.Next(1000);
            Thread.Sleep(rr);

            Console.WriteLine("I am {0} and I'm odd and a background thread!", Thread.CurrentThread.Name);       
        }

        public static void f1()
        {
            Console.WriteLine("Waiting");
            s.WaitOne();
            Console.WriteLine("Acquired by : {0}",Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("Released by : {0}",Thread.CurrentThread.Name);
            s.Release();

        }
    }
}
