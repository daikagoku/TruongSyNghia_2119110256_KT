using Cau1.BEL.Department;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL.Department
{
    class DepartmentDAL : BaseDAL
    {
        public DepartmentDAL() : base()
        {
            this.primary = "id";
            this.table = "department_2119110256";
        }
        public List<DepartmentBEL> gets()
        {
            List<DepartmentBEL> departments = new List<DepartmentBEL>();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getDepartments_2119110256", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    departments.Add(new DepartmentBEL(sqlDataReader));
                }
            }
            sqlConnection.Close();
            return departments;
        }
        public DepartmentBEL get(String id)
        {
            DepartmentBEL department = null;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getDepartment_2119110256", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    department = new DepartmentBEL(sqlDataReader);
                }
            }
            sqlConnection.Close();
            return department;
        }
    }
}
