
namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    partial class frm_View_Product_Details
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
            this.lbl_View_Product_Details = new System.Windows.Forms.Label();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.tb_Subcategory_Name = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.pnl_Navigation_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_View_Product_Details);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 70);
            this.pnl_Navigation_Bar.TabIndex = 7;
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
            this.lbl_Logout.TabIndex = 6;
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
            this.lbl_Back.TabIndex = 5;
            this.lbl_Back.Text = "Back";
            // 
            // lbl_View_Product_Details
            // 
            this.lbl_View_Product_Details.AutoSize = true;
            this.lbl_View_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_View_Product_Details.Location = new System.Drawing.Point(337, 9);
            this.lbl_View_Product_Details.Name = "lbl_View_Product_Details";
            this.lbl_View_Product_Details.Size = new System.Drawing.Size(476, 51);
            this.lbl_View_Product_Details.TabIndex = 0;
            this.lbl_View_Product_Details.Text = "View Product Details";
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Location = new System.Drawing.Point(12, 209);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.RowHeadersWidth = 51;
            this.dgv_Product_Details.RowTemplate.Height = 24;
            this.dgv_Product_Details.Size = new System.Drawing.Size(1158, 472);
            this.dgv_Product_Details.TabIndex = 35;
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.btn_Reset);
            this.gb_Product_Details.Controls.Add(this.cmb_Category_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Details.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Product_Details.ForeColor = System.Drawing.Color.MediumBlue;
            this.gb_Product_Details.Location = new System.Drawing.Point(91, 76);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(959, 127);
            this.gb_Product_Details.TabIndex = 36;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "PRODUCT DETAILS";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Subcategory_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(100, 81);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(185, 27);
            this.lbl_Subcategory_Name.TabIndex = 30;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // tb_Subcategory_Name
            // 
            this.tb_Subcategory_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Subcategory_Name.Location = new System.Drawing.Point(475, 78);
            this.tb_Subcategory_Name.Name = "tb_Subcategory_Name";
            this.tb_Subcategory_Name.Size = new System.Drawing.Size(257, 30);
            this.tb_Subcategory_Name.TabIndex = 3;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.Location = new System.Drawing.Point(767, 57);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(113, 40);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(475, 27);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(257, 31);
            this.cmb_Category_Name.TabIndex = 1;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Category_Name.Location = new System.Drawing.Point(100, 31);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(154, 27);
            this.lbl_Category_Name.TabIndex = 29;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // frm_View_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.dgv_Product_Details);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product Details";
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Label lbl_View_Product_Details;
        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.TextBox tb_Subcategory_Name;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
    }
}