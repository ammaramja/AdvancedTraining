using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CustomException;

namespace _22_august
{
    class Program
    {

        static void Main(string[] args)
        {
            //Assignment1 a = new Assignment1();
            //a.fileIO();

            //Assignment2 a = new Assignment2();
            //a.fileIO();

            //DummyTemperature d = new DummyTemperature();

            //try
            //{
            //    d.checkTemp();
            //}
            //catch(Exception e)
            //{

            //}

            try
            { 
            MathLib.Class1 m = new MathLib.Class1();

            //object m3 = m;

            //StreamReader m4 = (StreamReader)m3;

            //MathLib.Class1 m2 = null;

            //Console.WriteLine(m2.add(1,2));

            Console.WriteLine("Enter numbers!");
            
            
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                int ch = 0;
                do
                {
                    Console.WriteLine("===========MENU===========");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Sub");
                    Console.WriteLine("3. Mul");
                    Console.WriteLine("4. div");
                    Console.WriteLine("Press 0 to exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice!!!");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine(m.add(num1, num2));
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine(m.sub(num1, num2));
                            break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine(m.mul(num1, num2));
                            break;

                        case 4:
                            Console.WriteLine();
                            if(num2 == 0)
                            {
                                throw (new CustomException("Cannot divide by zero", "div"));
                            }
                            else
                            Console.WriteLine(m.div(num1, num2));
                            break;
                        default:
                            Console.WriteLine("Invalid Input!");
                            break;
                    }
                }
                while (ch != 0);


            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

         }
    }

    class CustomException:Exception
    {
        public CustomException(string message,string methodName):base(methodName)
        {
            Console.Write("{0} from ",message);
        }
    }
    class Assignment1:IDisposable
    {

        FileStream f1;
        StreamWriter sWrite;
        StreamReader sRead;
        public void Dispose()
        {
            f1.Dispose();
            Console.WriteLine("Disposed!");
        }

        public void Dispose(int x)
        {
            if (x == 2)
            {
                sWrite.Dispose();
                Console.WriteLine("Writer disposed");
            }
            else
            {
                sRead.Dispose();
                Console.WriteLine("Reader disposed!");
            }
        }

        public void fileIO()
        {

            f1 = new FileStream("assignment1.txt", FileMode.Create);
            Dispose();
            //Console.WriteLine(f1.Length);

            sWrite = new StreamWriter("assignment1.txt");
            sWrite.WriteLine("Its me your owner!");
            Dispose(2);

            sRead = new StreamReader("assignment1.txt");

            foreach(var i in sRead.ReadLine())
            {
                Console.Write(i);
            }

            Dispose(3);
            Console.ReadLine();
        }
        
    }

    class Assignment2
    {
        public void fileIO()
        {

            using (FileStream f1 = new FileStream("assignment1.txt", FileMode.Create))
            {

            }


            using (StreamWriter sWrite = new StreamWriter("assignment1.txt"))
            {
                sWrite.WriteLine("Its me your owner!");
            }




            using (StreamReader sRead = new StreamReader("assignment1.txt"))
            {
                String s = "";
                while ((s=sRead.ReadLine())!=null)
                {
                    Console.Write(s);
                }

            }



            Console.ReadLine();
        }
    }


}

namespace CustomException
{
    class Temperature:Exception
    {
        public Temperature(string msg): base(msg)
        {
            Console.WriteLine(msg);
        }
    }

    class DummyTemperature
    {
        public void checkTemp()
        {
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 0)
            {
                throw (new Temperature("0 nako!"));
            }
            else
            {
                Console.WriteLine("barobar aahe!");
            }
            Console.ReadLine();
        }
    }
        
}