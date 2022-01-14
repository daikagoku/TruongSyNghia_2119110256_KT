using Cau1.BEL.Department;
using Cau1.DAL.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BAL.Department
{
    class DepartmentBAL
    {
        DepartmentDAL departmentDAL = new DepartmentDAL();
        public List<DepartmentBEL> gets()
        {
            return departmentDAL.gets();
        }
        public DepartmentBEL get(String id)
        {
            return departmentDAL.get(id);
        }
    }
}
