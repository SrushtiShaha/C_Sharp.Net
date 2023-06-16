
namespace Student_Management_System
{
    partial class frm_Add_Course
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
            this.lbl_Add_Course = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Course_Nm = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Course_Nm = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_Course
            // 
            this.lbl_Add_Course.AutoSize = true;
            this.lbl_Add_Course.BackColor = System.Drawing.Color.White;
            this.lbl_Add_Course.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Course.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Add_Course.Location = new System.Drawing.Point(450, 94);
            this.lbl_Add_Course.Name = "lbl_Add_Course";
            this.lbl_Add_Course.Size = new System.Drawing.Size(333, 68);
            this.lbl_Add_Course.TabIndex = 0;
            this.lbl_Add_Course.Text = "Add Course";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Modern No. 20", 22.2F);
            this.lbl_Id.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Id.Location = new System.Drawing.Point(159, 300);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(181, 40);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Course_Id";
            // 
            // lbl_Course_Nm
            // 
            this.lbl_Course_Nm.AutoSize = true;
            this.lbl_Course_Nm.Font = new System.Drawing.Font("Modern No. 20", 22.2F);
            this.lbl_Course_Nm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Course_Nm.Location = new System.Drawing.Point(159, 437);
            this.lbl_Course_Nm.Name = "lbl_Course_Nm";
            this.lbl_Course_Nm.Size = new System.Drawing.Size(215, 40);
            this.lbl_Course_Nm.TabIndex = 2;
            this.lbl_Course_Nm.Text = "Course Name";
            // 
            // tb_Id
            // 
            this.tb_Id.Enabled = false;
            this.tb_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F);
            this.tb_Id.Location = new System.Drawing.Point(745, 303);
            this.tb_Id.MaxLength = 5;
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(314, 43);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_Course_Nm
            // 
            this.tb_Course_Nm.Font = new System.Drawing.Font("Modern No. 20", 19.8F);
            this.tb_Course_Nm.Location = new System.Drawing.Point(745, 437);
            this.tb_Course_Nm.MaxLength = 30;
            this.tb_Course_Nm.Name = "tb_Course_Nm";
            this.tb_Course_Nm.Size = new System.Drawing.Size(314, 43);
            this.tb_Course_Nm.TabIndex = 2;
            this.tb_Course_Nm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Save.Location = new System.Drawing.Point(526, 580);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 54);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Nm);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lbl_Course_Nm);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Add_Course);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Course;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Course_Nm;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Course_Nm;
        private System.Windows.Forms.Button btn_Save;
    }
}