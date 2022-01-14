using Cau1.BAL.Department;
using Cau1.BAL.Employee;
using Cau1.BEL.Department;
using Cau1.BEL.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1.GUI.Employee
{
    public partial class EmployeeGUI : Form
    {
        EmployeeBAL employeeBAL = new EmployeeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        public EmployeeGUI()
        {
            InitializeComponent();
        }
        private void EmployeeGUI_Load(object sender, EventArgs e)
        {
            List<EmployeeBEL> list = employeeBAL.gets();

            inputDepartment.Items.Clear();
            inputDepartment.DataSource = departmentBAL.gets();
            inputDepartment.DisplayMember = "name";

            dgvEmployees.Rows.Clear();
            foreach(EmployeeBEL employee in list)
            {
                addRowView(employee);
            }
        }
        void addRowView(EmployeeBEL employee)
        {
            int index = dgvEmployees.Rows.Add();
            loadRowView(index, employee);
        }
        void loadRowView(int index,EmployeeBEL employee)
        {
  
            dgvEmployees.Rows[index].Cells["id"].Value = employee.id;
            dgvEmployees.Rows[index].Cells["name"].Value = employee.name;
            dgvEmployees.Rows[index].Cells["gender"].Value = employee.gender;
            dgvEmployees.Rows[index].Cells["date_birth"].Value = employee.date_birth;
            dgvEmployees.Rows[index].Cells["place_birth"].Value = employee.place_birth;
        }


        Boolean validateInput()
        {
            if (inputName.Equals(""))
            {
                MessageBox.Show("Không bỏ trống tên nhân viên!");
                return false;
            }
            return true;
        }
        EmployeeBEL getEmployeeInput()
        {
            EmployeeBEL employee = new EmployeeBEL();
            employee.name = inputName.Text;
            employee.date_birth = inputDateBirth.Value;
            employee.place_birth = inputPlaceBirth.Text;

            DepartmentBEL department = (DepartmentBEL)(inputDepartment.SelectedItem);

            employee.department_id = department.id;
            return employee;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                EmployeeBEL employee = getEmployeeInput();
                if (employeeBAL.post(employee))
                {
                    addRowView(employee);
                }
            }
        }
    }
}
