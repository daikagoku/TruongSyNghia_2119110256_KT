using Cau1.BEL.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL.Employee
{
    class EmployeeDAL : BaseDAL
    {
        public EmployeeDAL() : base()
        {
            this.table = "employee";
            this.primary = "id";
        }

        public List<EmployeeBEL> gets()
        {
            List<EmployeeBEL> employees = new List<EmployeeBEL>();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getEmployees", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employees.Add(new EmployeeBEL(sqlDataReader));
                }
            }
            sqlConnection.Close();
            return employees;
        }
        public EmployeeBEL get(String id)
        {
            EmployeeBEL employee = null;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employee = new EmployeeBEL(sqlDataReader);
                }
            }
            sqlConnection.Close();
            return employee;
        }
        public Boolean delete(EmployeeBEL employeeBEL)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_deleteEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean post(EmployeeBEL employeeBEL)
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_postEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", employeeBEL.name));
            sqlCommand.Parameters.Add(new SqlParameter("@date_birth", employeeBEL.date_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@place_birth", employeeBEL.place_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", employeeBEL.gender));
            sqlCommand.Parameters.Add(new SqlParameter("@department_id", employeeBEL.department_id));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean put(EmployeeBEL employeeBEL)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("pr_putEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", employeeBEL.name));
            sqlCommand.Parameters.Add(new SqlParameter("@date_birth", employeeBEL.date_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@place_birth", employeeBEL.place_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", employeeBEL.gender));
            sqlCommand.Parameters.Add(new SqlParameter("@department_id", employeeBEL.department_id));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
    }
}
