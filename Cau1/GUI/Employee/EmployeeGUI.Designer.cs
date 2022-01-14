
namespace Cau1.GUI.Employee
{
    partial class EmployeeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPlaceBirth = new System.Windows.Forms.TextBox();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.inputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.inputGender = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.place_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departhment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(775, 415);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 0;
            this.buttonOut.Text = "Thoát";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(666, 415);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(75, 23);
            this.buttonPut.TabIndex = 1;
            this.buttonPut.Text = "Sửa";
            this.buttonPut.UseVisualStyleBackColor = true;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(442, 415);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Thêm";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(553, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date_birth,
            this.gender,
            this.place_birth,
            this.departhment});
            this.dgvEmployees.Location = new System.Drawing.Point(12, 98);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(838, 298);
            this.dgvEmployees.TabIndex = 3;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(66, 22);
            this.inputId.Name = "inputId";
            this.inputId.ReadOnly = true;
            this.inputId.Size = new System.Drawing.Size(145, 20);
            this.inputId.TabIndex = 4;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(299, 22);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(172, 20);
            this.inputName.TabIndex = 5;
            // 
            // inputPlaceBirth
            // 
            this.inputPlaceBirth.Location = new System.Drawing.Point(299, 60);
            this.inputPlaceBirth.Name = "inputPlaceBirth";
            this.inputPlaceBirth.Size = new System.Drawing.Size(551, 20);
            this.inputPlaceBirth.TabIndex = 6;
            // 
            // inputDepartment
            // 
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(66, 59);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(143, 21);
            this.inputDepartment.TabIndex = 7;
            // 
            // inputDateBirth
            // 
            this.inputDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDateBirth.Location = new System.Drawing.Point(562, 22);
            this.inputDateBirth.Name = "inputDateBirth";
            this.inputDateBirth.Size = new System.Drawing.Size(127, 20);
            this.inputDateBirth.TabIndex = 8;
            // 
            // inputGender
            // 
            this.inputGender.AutoSize = true;
            this.inputGender.Location = new System.Drawing.Point(715, 24);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(91, 17);
            this.inputGender.TabIndex = 9;
            this.inputGender.Text = "Giới tính Nam";
            this.inputGender.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh";
            // 
            // id
            // 
            this.id.FillWeight = 1F;
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.FillWeight = 2F;
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            // 
            // date_birth
            // 
            this.date_birth.FillWeight = 2F;
            this.date_birth.HeaderText = "Ngày sinh";
            this.date_birth.Name = "date_birth";
            // 
            // gender
            // 
            this.gender.FillWeight = 1F;
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // place_birth
            // 
            this.place_birth.FillWeight = 2F;
            this.place_birth.HeaderText = "Nơi sinh";
            this.place_birth.Name = "place_birth";
            // 
            // departhment
            // 
            this.departhment.FillWeight = 2F;
            this.departhment.HeaderText = "Đơn vị";
            this.departhment.Name = "departhment";
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputDateBirth);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.inputPlaceBirth);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.buttonOut);
            this.Name = "EmployeeGUI";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.EmployeeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPlaceBirth;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.DateTimePicker inputDateBirth;
        private System.Windows.Forms.CheckBox inputGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn departhment;
    }
}