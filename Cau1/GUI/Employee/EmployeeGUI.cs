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
        int selectRowIndex = -1;
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

            DepartmentBEL department = departmentBAL.get(employee.department_id);
            dgvEmployees.Rows[index].Cells["department"].Value = department.name;

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
        void clearInput()
        {
            inputId.Text = "";
            inputName.Text = "";
            inputPlaceBirth.Text = "";
            inputGender.Checked = false;
            inputDepartment.SelectedIndex = 0;
        }
        void loadInput(EmployeeBEL employee)
        {
            inputId.Text = employee.id;
            inputName.Text = employee.name;
            inputDateBirth.Value = employee.date_birth;
            inputPlaceBirth.Text = employee.place_birth;
            inputGender.Checked = employee.gender;
            DepartmentBEL department = departmentBAL.get(employee.department_id);
            inputDepartment.Text = department.name;
        }
        EmployeeBEL getEmployeeInput()
        {
            EmployeeBEL employee = new EmployeeBEL();
            employee.name = inputName.Text;
            employee.date_birth = inputDateBirth.Value;
            employee.place_birth = inputPlaceBirth.Text;
            employee.gender = inputGender.Checked;
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
                    clearInput();
                }
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEmployees.CurrentCell.RowIndex;
            if(index >= 0)
            {
                dgvEmployees.Rows[index].Selected = true;
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEmployees.SelectedRows.Count > 0)
            {
                if(dgvEmployees.SelectedRows[0].Index >= 0 && dgvEmployees.SelectedRows[0].Index < dgvEmployees.Rows.Count - 1)
                {
                    selectRowIndex = dgvEmployees.SelectedRows[0].Index;
                    EmployeeBEL employee = employeeBAL.get(dgvEmployees.SelectedRows[0].Cells["id"].Value.ToString());
                    loadInput(employee);
                }
                else
                {
                    clearInput();
                    selectRowIndex = -1;
                }
            }
            else
            {
                clearInput();
                selectRowIndex = -1;
            }
        }
    }
}
