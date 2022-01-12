using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BEL.Department
{
    class DepartmentBEL
    {
        public String id { get; set; }
        public String name { get; set; }

        public DepartmentBEL(SqlDataReader sqlDataReader)
        {
            this.id = sqlDataReader["id"].ToString();
            this.name = sqlDataReader["name"].ToString();
        }
    }
}
