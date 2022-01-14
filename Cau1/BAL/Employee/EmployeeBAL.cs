using Cau1.BEL.Employee;
using Cau1.DAL.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BAL.Employee
{
    class EmployeeBAL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public List<EmployeeBEL> gets()
        {
           return employeeDAL.gets();
        }
        public EmployeeBEL get(String id)
        {
            return employeeDAL.get(id);
        }
        public Boolean post(EmployeeBEL employee)
        {
            String id = employeeDAL.getNewID();
            employee.id = id;
            return employeeDAL.post(employee);
        }
        public Boolean put(EmployeeBEL employee)
        {
            return employeeDAL.put(employee);
        }
        public Boolean delete(EmployeeBEL employee)
        {
            return employeeDAL.delete(employee);
        }
    }
}
