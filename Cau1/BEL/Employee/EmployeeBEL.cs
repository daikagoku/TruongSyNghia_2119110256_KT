using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BEL.Employee
{
    class EmployeeBEL
    {
        public String id { get; set; }
        public String name { get; set; }
        public Boolean gender { get; set; }
        public DateTime date_birth { get; set; }
        public String place_birth { get; set; }
        public String department_id { get; set; }

        public EmployeeBEL() { }
        public EmployeeBEL(SqlDataReader sqlDataReader)
        {
            this.id = sqlDataReader["id"].ToString();
            this.name = sqlDataReader["name"].ToString();

            this.gender = (Boolean)sqlDataReader["gender"];


            this.date_birth = (DateTime)sqlDataReader["date_birth"];
            this.place_birth = sqlDataReader["place_birth"].ToString();

            this.department_id = sqlDataReader["department_id"].ToString();
        }

    }
}
