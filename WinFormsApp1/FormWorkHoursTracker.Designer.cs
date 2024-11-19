namespace WinFormsApp1
{
    partial class FormWorkHoursTracker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtEnterpriseID = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblEnterpriseID = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();

            // txtEmployeeID
            this.txtEmployeeID.Location = new System.Drawing.Point(8, 32);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 23);
            this.txtEmployeeID.TabIndex = 0;

            // txtPosition
            this.txtPosition.Location = new System.Drawing.Point(8, 76);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 23);
            this.txtPosition.TabIndex = 1;

            // txtHoursWorked
            this.txtHoursWorked.Location = new System.Drawing.Point(8, 120);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 23);
            this.txtHoursWorked.TabIndex = 2;

            // txtEnterpriseID
            this.txtEnterpriseID.Location = new System.Drawing.Point(8, 164);
            this.txtEnterpriseID.Name = "txtEnterpriseID";
            this.txtEnterpriseID.Size = new System.Drawing.Size(100, 23);
            this.txtEnterpriseID.TabIndex = 3;

            // txtContactInfo
            this.txtContactInfo.Location = new System.Drawing.Point(8, 208);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(100, 23);
            this.txtContactInfo.TabIndex = 4;

            // dataGridViewEmployee
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(150, 10);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(800, 400);
            this.dataGridViewEmployee.TabIndex = 5;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(8, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(64, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 25);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // lblEmployeeID
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(8, 14);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 15);
            this.lblEmployeeID.TabIndex = 9;
            this.lblEmployeeID.Text = "Employee ID:";

            // lblPosition
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(8, 58);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(52, 15);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Position:";

            // lblHoursWorked
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(8, 102);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(83, 15);
            this.lblHoursWorked.TabIndex = 11;
            this.lblHoursWorked.Text = "Hours Worked:";

            // lblEnterpriseID
            this.lblEnterpriseID.AutoSize = true;
            this.lblEnterpriseID.Location = new System.Drawing.Point(8, 146);
            this.lblEnterpriseID.Name = "lblEnterpriseID";
            this.lblEnterpriseID.Size = new System.Drawing.Size(76, 15);
            this.lblEnterpriseID.TabIndex = 12;
            this.lblEnterpriseID.Text = "Enterprise ID:";

            // lblContactInfo
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Location = new System.Drawing.Point(8, 190);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(75, 15);
            this.lblContactInfo.TabIndex = 13;
            this.lblContactInfo.Text = "Contact Info:";

            // FormWorkHoursTracker
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblEnterpriseID);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtEnterpriseID);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Name = "FormWorkHoursTracker";
            this.Text = "Work Hours Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtEnterpriseID;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblEnterpriseID;
        private System.Windows.Forms.Label lblContactInfo;
    }
}
