using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    class BaseDAL
    {
        protected SqlConnection sqlConnection;
        protected String schema = "HR";
        protected String table = "";
        protected String primary = "";
        protected String username = "sa";
        protected String password = "12345";
        private String defaultId = "00000000";
        public BaseDAL()
        {
            sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=" + schema + ";User Id=" + username + ";Password=" + password + ";");
        }

        public String getNewID()
        {
            return getNewID(primary);
        }
        public String getNewID(String id_name)
        {
            String id = "";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT top(1) * FROM " + table + " ORDER BY " + id_name + " DESC", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows && sqlDataReader.Read())
            {
                id = sqlDataReader[0].ToString();
            }
            sqlConnection.Close();
            if (id == "")
            {
                id = defaultId;
            }
            else
            {
                Boolean isIncrease = true;
                int index = id.Length - 1;
                char[] args = id.ToCharArray();
                while (isIncrease && index >= 0)
                {
                    if(args[index] == '9')
                    {
                        args[index] = '0';
                        index--;
                    }
                    else
                    {
                        args[index]++;
                        isIncrease = false;
                    }
                }
                id = new String(args);
            }

            return id;
        }
    }
}
