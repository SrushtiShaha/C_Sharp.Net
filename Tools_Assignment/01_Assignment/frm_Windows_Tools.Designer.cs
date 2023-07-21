
namespace Student_Management_System
{
    partial class frm_Windows_Tools
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
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Emp_Nm = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Known_Languages = new System.Windows.Forms.Label();
            this.lbl_Hobby = new System.Windows.Forms.Label();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.lbl_Result_Text = new System.Windows.Forms.Label();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Department_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Language_Error = new System.Windows.Forms.Label();
            this.lbl_Hobby_Error = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.pnl_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(531, 9);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(631, 90);
            this.lbl_Employee_Details.TabIndex = 2;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // lbl_Emp_Nm
            // 
            this.lbl_Emp_Nm.AutoSize = true;
            this.lbl_Emp_Nm.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Nm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Emp_Nm.Location = new System.Drawing.Point(46, 160);
            this.lbl_Emp_Nm.Name = "lbl_Emp_Nm";
            this.lbl_Emp_Nm.Size = new System.Drawing.Size(282, 46);
            this.lbl_Emp_Nm.TabIndex = 3;
            this.lbl_Emp_Nm.Text = "Employee Name";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Department.Location = new System.Drawing.Point(46, 309);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(374, 46);
            this.lbl_Department.TabIndex = 4;
            this.lbl_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Gender.Location = new System.Drawing.Point(47, 457);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(135, 46);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Output.Location = new System.Drawing.Point(12, 744);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(125, 43);
            this.lbl_Output.TabIndex = 7;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(452, 160);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(393, 45);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "R&D",
            "HRD",
            "Testing",
            "Management"});
            this.cmb_Department.Location = new System.Drawing.Point(452, 310);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(339, 45);
            this.cmb_Department.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Submit.Location = new System.Drawing.Point(500, 639);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(190, 61);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(96, 28);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(116, 42);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(247, 28);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(157, 42);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gb_Gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(452, 432);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(411, 90);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Reset.Location = new System.Drawing.Point(1068, 639);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(165, 61);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Known_Languages
            // 
            this.lbl_Known_Languages.AutoSize = true;
            this.lbl_Known_Languages.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Languages.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Known_Languages.Location = new System.Drawing.Point(938, 160);
            this.lbl_Known_Languages.Name = "lbl_Known_Languages";
            this.lbl_Known_Languages.Size = new System.Drawing.Size(318, 46);
            this.lbl_Known_Languages.TabIndex = 12;
            this.lbl_Known_Languages.Text = "Konwn Languages";
            // 
            // lbl_Hobby
            // 
            this.lbl_Hobby.AutoSize = true;
            this.lbl_Hobby.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobby.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Hobby.Location = new System.Drawing.Point(938, 389);
            this.lbl_Hobby.Name = "lbl_Hobby";
            this.lbl_Hobby.Size = new System.Drawing.Size(151, 46);
            this.lbl_Hobby.TabIndex = 13;
            this.lbl_Hobby.Text = "Hobbies";
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Tracking",
            "Gaming",
            "Cooking",
            "Reading"});
            this.clb_Hobbies.Location = new System.Drawing.Point(1312, 378);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(289, 242);
            this.clb_Hobbies.TabIndex = 11;
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gb_Known_Languages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Known_Languages.Location = new System.Drawing.Point(1312, 160);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(301, 165);
            this.gb_Known_Languages.TabIndex = 6;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(174, 115);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(118, 31);
            this.cb_French.TabIndex = 10;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(28, 109);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(123, 31);
            this.cb_English.TabIndex = 9;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(174, 45);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(101, 31);
            this.cb_Hindi.TabIndex = 8;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(28, 45);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(126, 31);
            this.cb_Marathi.TabIndex = 7;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // pnl_Output
            // 
            this.pnl_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_Output.Controls.Add(this.lbl_Result_Text);
            this.pnl_Output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnl_Output.Location = new System.Drawing.Point(134, 744);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(1736, 54);
            this.pnl_Output.TabIndex = 15;
            // 
            // lbl_Result_Text
            // 
            this.lbl_Result_Text.AutoSize = true;
            this.lbl_Result_Text.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Text.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Result_Text.Location = new System.Drawing.Point(3, 15);
            this.lbl_Result_Text.Name = "lbl_Result_Text";
            this.lbl_Result_Text.Size = new System.Drawing.Size(474, 28);
            this.lbl_Result_Text.TabIndex = 0;
            this.lbl_Result_Text.Text = "Output Of Submit Button Appears Here";
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Name_Error.Location = new System.Drawing.Point(600, 219);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(108, 17);
            this.lbl_Name_Error.TabIndex = 16;
            this.lbl_Name_Error.Text = "Name Error";
            this.lbl_Name_Error.Visible = false;
            // 
            // lbl_Department_Error
            // 
            this.lbl_Department_Error.AutoSize = true;
            this.lbl_Department_Error.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Department_Error.Location = new System.Drawing.Point(521, 378);
            this.lbl_Department_Error.Name = "lbl_Department_Error";
            this.lbl_Department_Error.Size = new System.Drawing.Size(168, 17);
            this.lbl_Department_Error.TabIndex = 17;
            this.lbl_Department_Error.Text = "Department Error";
            this.lbl_Department_Error.Visible = false;
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(621, 544);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(128, 17);
            this.lbl_Gender_Error.TabIndex = 18;
            this.lbl_Gender_Error.Text = "Gender Error";
            this.lbl_Gender_Error.Visible = false;
            // 
            // lbl_Language_Error
            // 
            this.lbl_Language_Error.AutoSize = true;
            this.lbl_Language_Error.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Language_Error.Location = new System.Drawing.Point(1390, 338);
            this.lbl_Language_Error.Name = "lbl_Language_Error";
            this.lbl_Language_Error.Size = new System.Drawing.Size(148, 17);
            this.lbl_Language_Error.TabIndex = 19;
            this.lbl_Language_Error.Text = "Language Error";
            this.lbl_Language_Error.Visible = false;
            // 
            // lbl_Hobby_Error
            // 
            this.lbl_Hobby_Error.AutoSize = true;
            this.lbl_Hobby_Error.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobby_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Hobby_Error.Location = new System.Drawing.Point(1420, 639);
            this.lbl_Hobby_Error.Name = "lbl_Hobby_Error";
            this.lbl_Hobby_Error.Size = new System.Drawing.Size(118, 17);
            this.lbl_Hobby_Error.TabIndex = 20;
            this.lbl_Hobby_Error.Text = "Hobby Error";
            this.lbl_Hobby_Error.Visible = false;
            // 
            // frm_Windows_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1882, 823);
            this.Controls.Add(this.lbl_Hobby_Error);
            this.Controls.Add(this.lbl_Language_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Department_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.lbl_Hobby);
            this.Controls.Add(this.lbl_Known_Languages);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Emp_Nm);
            this.Controls.Add(this.lbl_Employee_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Windows_Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use Windows Controls";
            this.Load += new System.EventHandler(this.frm_Windows_Tools_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Label lbl_Emp_Nm;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Known_Languages;
        private System.Windows.Forms.Label lbl_Hobby;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.Label lbl_Result_Text;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Department_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Language_Error;
        private System.Windows.Forms.Label lbl_Hobby_Error;
    }
}