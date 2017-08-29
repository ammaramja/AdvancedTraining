using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _23_august_adoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                //student.insertData();
                //student.getData();
                Console.WriteLine("Enter roll number of the record to be edited!");
                int rolllNum = Convert.ToInt32(Console.ReadLine());
                student.updateRecord(rolllNum);
                student.getDataSet();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
