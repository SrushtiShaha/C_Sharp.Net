
namespace Ayuraj_Computer_Shopee_App.Forms.Distributer
{
    partial class frm_View_Distributor_Details
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
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.lbl_View_Customer_Details = new System.Windows.Forms.Label();
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Distributor_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Distributor_Details = new System.Windows.Forms.Panel();
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Distributor_ID = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnl_Navigation_Bar.SuspendLayout();
            this.gb_Distributor_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Details)).BeginInit();
            this.pnl_Distributor_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_View_Customer_Details);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 70);
            this.pnl_Navigation_Bar.TabIndex = 3;
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
            // lbl_View_Customer_Details
            // 
            this.lbl_View_Customer_Details.AutoSize = true;
            this.lbl_View_Customer_Details.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Customer_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_View_Customer_Details.Location = new System.Drawing.Point(340, 9);
            this.lbl_View_Customer_Details.Name = "lbl_View_Customer_Details";
            this.lbl_View_Customer_Details.Size = new System.Drawing.Size(547, 51);
            this.lbl_View_Customer_Details.TabIndex = 0;
            this.lbl_View_Customer_Details.Text = "View Distributor Details";
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Distributor_Details.Controls.Add(this.dgv_Distributor_Details);
            this.gb_Distributor_Details.Controls.Add(this.pnl_Distributor_Details);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Distributor_Details.ForeColor = System.Drawing.Color.MediumBlue;
            this.gb_Distributor_Details.Location = new System.Drawing.Point(0, 76);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(1182, 548);
            this.gb_Distributor_Details.TabIndex = 12;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "DISTRIBUTOR DETAILS";
            // 
            // dgv_Distributor_Details
            // 
            this.dgv_Distributor_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Distributor_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Distributor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Distributor_Details.Location = new System.Drawing.Point(6, 92);
            this.dgv_Distributor_Details.Name = "dgv_Distributor_Details";
            this.dgv_Distributor_Details.RowHeadersWidth = 51;
            this.dgv_Distributor_Details.RowTemplate.Height = 24;
            this.dgv_Distributor_Details.Size = new System.Drawing.Size(1170, 450);
            this.dgv_Distributor_Details.TabIndex = 14;
            // 
            // pnl_Distributor_Details
            // 
            this.pnl_Distributor_Details.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Distributor_Details.Controls.Add(this.tb_Distributor_ID);
            this.pnl_Distributor_Details.Controls.Add(this.btn_Search);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Distributor_ID);
            this.pnl_Distributor_Details.Location = new System.Drawing.Point(188, 27);
            this.pnl_Distributor_Details.Name = "pnl_Distributor_Details";
            this.pnl_Distributor_Details.Size = new System.Drawing.Size(836, 59);
            this.pnl_Distributor_Details.TabIndex = 13;
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Distributor_ID.Location = new System.Drawing.Point(270, 12);
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(257, 30);
            this.tb_Distributor_ID.TabIndex = 54;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(652, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 40);
            this.btn_Search.TabIndex = 53;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Distributor_ID
            // 
            this.lbl_Distributor_ID.AutoSize = true;
            this.lbl_Distributor_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Distributor_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Distributor_ID.Location = new System.Drawing.Point(67, 15);
            this.lbl_Distributor_ID.Name = "lbl_Distributor_ID";
            this.lbl_Distributor_ID.Size = new System.Drawing.Size(115, 27);
            this.lbl_Distributor_ID.TabIndex = 0;
            this.lbl_Distributor_ID.Text = "Distributor";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.Location = new System.Drawing.Point(542, 641);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(113, 40);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // frm_View_Distributor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Distributor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Distributor Details";
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            this.gb_Distributor_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Details)).EndInit();
            this.pnl_Distributor_Details.ResumeLayout(false);
            this.pnl_Distributor_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Label lbl_View_Customer_Details;
        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.DataGridView dgv_Distributor_Details;
        private System.Windows.Forms.Panel pnl_Distributor_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Distributor_ID;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Button btn_Reset;
    }
}