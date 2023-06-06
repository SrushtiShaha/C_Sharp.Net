
namespace Employee_Management_System
{
    partial class frm_Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee));
            this.lbl_Add_New_Information = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lab_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Des = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Des = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Emp_List = new System.Windows.Forms.Button();
            this.lbl_Logout = new System.Windows.Forms.Button();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Information
            // 
            this.lbl_Add_New_Information.AutoSize = true;
            this.lbl_Add_New_Information.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Add_New_Information.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Information.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Add_New_Information.Location = new System.Drawing.Point(263, 39);
            this.lbl_Add_New_Information.Name = "lbl_Add_New_Information";
            this.lbl_Add_New_Information.Size = new System.Drawing.Size(370, 38);
            this.lbl_Add_New_Information.TabIndex = 0;
            this.lbl_Add_New_Information.Text = "Add New Information";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Id.Location = new System.Drawing.Point(57, 121);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(37, 27);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Name.Location = new System.Drawing.Point(55, 194);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(69, 27);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lab_Mob_No
            // 
            this.lab_Mob_No.AutoSize = true;
            this.lab_Mob_No.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_Mob_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Mob_No.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Mob_No.Location = new System.Drawing.Point(57, 269);
            this.lab_Mob_No.Name = "lab_Mob_No";
            this.lab_Mob_No.Size = new System.Drawing.Size(121, 27);
            this.lab_Mob_No.TabIndex = 3;
            this.lab_Mob_No.Text = "Mobile No.";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_DOB.Location = new System.Drawing.Point(57, 340);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(80, 27);
            this.lbl_DOB.TabIndex = 4;
            this.lbl_DOB.Text = "D.O.B.";
            // 
            // lbl_Des
            // 
            this.lbl_Des.AutoSize = true;
            this.lbl_Des.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Des.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Des.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Des.Location = new System.Drawing.Point(57, 412);
            this.lbl_Des.Name = "lbl_Des";
            this.lbl_Des.Size = new System.Drawing.Size(126, 27);
            this.lbl_Des.TabIndex = 5;
            this.lbl_Des.Text = "Designation";
            // 
            // tb_Id
            // 
            this.tb_Id.Enabled = false;
            this.tb_Id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(590, 126);
            this.tb_Id.MaxLength = 5;
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(198, 29);
            this.tb_Id.TabIndex = 1;
            this.tb_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(590, 199);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(198, 29);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo.Location = new System.Drawing.Point(590, 274);
            this.tb_MobNo.MaxLength = 10;
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(198, 29);
            this.tb_MobNo.TabIndex = 3;
            this.tb_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(590, 343);
            this.dtp_DOB.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(198, 29);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // cmb_Des
            // 
            this.cmb_Des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Des.FormattingEnabled = true;
            this.cmb_Des.Items.AddRange(new object[] {
            "Tester",
            "Manager",
            "Developer"});
            this.cmb_Des.Location = new System.Drawing.Point(590, 412);
            this.cmb_Des.MaxLength = 50;
            this.cmb_Des.Name = "cmb_Des";
            this.cmb_Des.Size = new System.Drawing.Size(198, 32);
            this.cmb_Des.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(367, 492);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 41);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(60, 492);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(116, 41);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Emp_List
            // 
            this.btn_Emp_List.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_List.Location = new System.Drawing.Point(627, 492);
            this.btn_Emp_List.Name = "btn_Emp_List";
            this.btn_Emp_List.Size = new System.Drawing.Size(161, 41);
            this.btn_Emp_List.TabIndex = 8;
            this.btn_Emp_List.Text = "Employee List";
            this.btn_Emp_List.UseVisualStyleBackColor = true;
            this.btn_Emp_List.Click += new System.EventHandler(this.btn_Emp_List_Click);
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.Red;
            this.lbl_Logout.Location = new System.Drawing.Point(747, 2);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(85, 34);
            this.lbl_Logout.TabIndex = 9;
            this.lbl_Logout.Text = "LogOut";
            this.lbl_Logout.UseVisualStyleBackColor = true;
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_UName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UName.Location = new System.Drawing.Point(-1, 2);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(95, 25);
            this.lbl_UName.TabIndex = 10;
            this.lbl_UName.Text = "Username";
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.lbl_Logout);
            this.Controls.Add(this.btn_Emp_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Des);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_MobNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lbl_Des);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lab_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Add_New_Information);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Details";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Information;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lab_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Des;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Des;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Emp_List;
        private System.Windows.Forms.Button lbl_Logout;
        private System.Windows.Forms.Label lbl_UName;
    }
}