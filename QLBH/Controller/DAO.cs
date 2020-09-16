using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QLBH.Controller
{
    class DAO
    {
        private static String connectionString = @"Server=LAPTOP-HENIB6EN\SQLEXPRESS;Database=BanHang18;User=hhsh;Password=123";

        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            return con; 
        }
        public SqlDataAdapter getDataAdapter(String queryString)
        {
            return new SqlDataAdapter(queryString, getConnection());
        }


        public DataTable getDataSource(SqlDataAdapter sda)
        {
            DataTable dataSource = new DataTable();
            sda.Fill(dataSource);
            return dataSource;
        }

        public SqlDataReader sqlReader(String query)
        {

            SqlConnection con = this.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }

        public bool executeCommands(String queryString)
        {
            SqlConnection con = getConnection();
            try
            {
                SqlCommand command = new SqlCommand(queryString, con);
                return command.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }





    }
}
