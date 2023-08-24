
namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    partial class frm_View_Emp_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Navigation_Bar = new System.Windows.Forms.Panel();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.lbl_Add_Employee = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.dgv_Employee_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Employee_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_Emp_Id = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnl_Navigation_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).BeginInit();
            this.pnl_Employee_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Add_Employee);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Logout);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 70);
            this.pnl_Navigation_Bar.TabIndex = 1;
            // 
            // lbl_Back
            // 
            this.lbl_Back.AutoSize = true;
            this.lbl_Back.BackColor = System.Drawing.Color.Teal;
            this.lbl_Back.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Back.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Back.Location = new System.Drawing.Point(12, 15);
            this.lbl_Back.Name = "lbl_Back";
            this.lbl_Back.Size = new System.Drawing.Size(66, 39);
            this.lbl_Back.TabIndex = 3;
            this.lbl_Back.Text = "Back";
            // 
            // lbl_Add_Employee
            // 
            this.lbl_Add_Employee.AutoSize = true;
            this.lbl_Add_Employee.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Employee.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Employee.Location = new System.Drawing.Point(290, 9);
            this.lbl_Add_Employee.Name = "lbl_Add_Employee";
            this.lbl_Add_Employee.Size = new System.Drawing.Size(515, 51);
            this.lbl_Add_Employee.TabIndex = 0;
            this.lbl_Add_Employee.Text = "View Employee Details";
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.AutoSize = true;
            this.lbl_Logout.BackColor = System.Drawing.Color.Teal;
            this.lbl_Logout.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Logout.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Logout.Location = new System.Drawing.Point(1077, 15);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(87, 39);
            this.lbl_Logout.TabIndex = 4;
            this.lbl_Logout.Text = "Logout";
            // 
            // dgv_Employee_Details
            // 
            this.dgv_Employee_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_Details.Location = new System.Drawing.Point(12, 152);
            this.dgv_Employee_Details.Name = "dgv_Employee_Details";
            this.dgv_Employee_Details.RowHeadersWidth = 51;
            this.dgv_Employee_Details.RowTemplate.Height = 24;
            this.dgv_Employee_Details.Size = new System.Drawing.Size(1160, 474);
            this.dgv_Employee_Details.TabIndex = 9;
            // 
            // pnl_Employee_Details
            // 
            this.pnl_Employee_Details.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Employee_Details.Controls.Add(this.btn_Search);
            this.pnl_Employee_Details.Controls.Add(this.tb_Emp_ID);
            this.pnl_Employee_Details.Controls.Add(this.lbl_Emp_Id);
            this.pnl_Employee_Details.Location = new System.Drawing.Point(290, 76);
            this.pnl_Employee_Details.Name = "pnl_Employee_Details";
            this.pnl_Employee_Details.Size = new System.Drawing.Size(654, 70);
            this.pnl_Employee_Details.TabIndex = 14;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(520, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(116, 40);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Emp_ID.Location = new System.Drawing.Point(209, 24);
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(257, 30);
            this.tb_Emp_ID.TabIndex = 4;
            // 
            // lbl_Emp_Id
            // 
            this.lbl_Emp_Id.AutoSize = true;
            this.lbl_Emp_Id.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Emp_Id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Id.Location = new System.Drawing.Point(34, 24);
            this.lbl_Emp_Id.Name = "lbl_Emp_Id";
            this.lbl_Emp_Id.Size = new System.Drawing.Size(132, 27);
            this.lbl_Emp_Id.TabIndex = 3;
            this.lbl_Emp_Id.Text = "Employee ID";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.Location = new System.Drawing.Point(538, 641);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(108, 40);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // frm_View_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pnl_Employee_Details);
            this.Controls.Add(this.dgv_Employee_Details);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Emp_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Details";
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).EndInit();
            this.pnl_Employee_Details.ResumeLayout(false);
            this.pnl_Employee_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Label lbl_Add_Employee;
        private System.Windows.Forms.DataGridView dgv_Employee_Details;
        private System.Windows.Forms.Panel pnl_Employee_Details;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Label lbl_Emp_Id;
        private System.Windows.Forms.Button btn_Search;
    }
}