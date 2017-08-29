using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _23_august_adoDotNet
{
    public class SqlHelper
    {
        SqlConnection _connection;
        SqlCommand _command;

        public String query = null;
        String connectionString = @"Data Source=.;Initial Catalog=AmmarsFirst;Integrated Security=True;Pooling=False";

        
        public SqlHelper()
        {
            _connection = new SqlConnection(connectionString);
            if(_connection.State == System.Data.ConnectionState.Closed)
            _connection.Open();

            Console.WriteLine("Opened!");
        }
         
        public SqlDataReader ExeuteQuery(String query)
        {
            _command = new SqlCommand();
            _command.CommandText = query;
            _command.Connection = _connection;
            return _command.ExecuteReader();
        }

        public String ExeuteScalar(String query)
        {
            _command = new SqlCommand();
            _command.CommandText = query;
            _command.Connection = _connection;
            return _command.ExecuteScalar().ToString();
        }

        public bool ExecuteNonquery(string query)
        {
            var result = false;
            _command = new SqlCommand(query,_connection);
            if (_command.ExecuteNonQuery() > 0)
            {
                result = true;
            }
            else
                result = false;
            return result;
        }

        public DataTable getDataSet(String query)
        {
            var ds = new DataSet();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _connection);

            sqlAdapter.Fill(ds,"firstTable");

            return ds.Tables[0];
        }

        public void update(String query)
        {
            _command = new SqlCommand(query,_connection);
            int count = _command.ExecuteNonQuery();
            if(count > 0)
            {
                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Error!!");
            }
        }


   
    }
}
