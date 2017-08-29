using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace _23_august_adoDotNet
{
    public class Student
    {
        public SqlHelper _sql;
        public String sqlQuery;

        public Student()
        {
            _sql = new SqlHelper();
        }

        public void getData()
        {
            sqlQuery = "select * from [Table]";

            var dataRead = _sql.ExeuteQuery(sqlQuery);
            int count = 0;
            while (dataRead.Read())
            {
                Console.WriteLine("NAME : {1}\nMARKS : {2}\nRoll Number : {0}", dataRead[0], dataRead[1], dataRead[2]);
                count++;
            }

            dataRead.Close();

            //var newDataRead = _sql.ExeuteScalar(sqlQuery);
            //Console.WriteLine(newDataRead);
            ////Console.WriteLine("Count : {0}",count);
        }

        public void insertData()
        {
            Console.WriteLine("Enter Name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Roll number:");
            int rollNumber =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks:");
            int marks = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter Phone number:");
            String phoneNumber = Console.ReadLine();

            sqlQuery = string.Format("insert into [Table] values ({0},'{1}',{2},'{3}')",rollNumber,name,marks,phoneNumber);

            Console.WriteLine(_sql.ExecuteNonquery(sqlQuery));

        }

        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";

            DataTable dt = _sql.getDataSet(sqlQuery);
            
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine("NAME : {1}\nMARKS : {2}\nRoll Number : {0}", dr[0], dr[1], dr[2]);
            
            }

            dt.WriteXml("my.xls");
        }

        public void updateRecord(int rollNumber)
        {
            Console.WriteLine("Enter new name: ");
            String name = Console.ReadLine();


            Console.WriteLine("Enter new Marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter new Phone number:");
            String phoneNumber = Console.ReadLine();

            sqlQuery = string.Format(@"update[Table] set RollNum = {0}, StudName = '{1}', Marks = {2}, ContactNum = '{3}' where RollNum = '{0}'",rollNumber,name,marks,phoneNumber);

            _sql.update(sqlQuery);
        }
    }
}
