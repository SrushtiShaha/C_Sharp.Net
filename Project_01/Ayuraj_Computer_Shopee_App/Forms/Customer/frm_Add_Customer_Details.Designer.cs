
namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    partial class frm_Add_Customer_Details
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
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.dtp_Cust_Added_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Subcategory = new System.Windows.Forms.ComboBox();
            this.tb_GST_Applied = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Total_Prise = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Total_Prise = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnl_Navigation_Bar.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.gb_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Add_New_Customer);
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
            this.lbl_Logout.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Logout.Location = new System.Drawing.Point(1077, 15);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(91, 41);
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
            this.lbl_Back.Size = new System.Drawing.Size(67, 41);
            this.lbl_Back.TabIndex = 5;
            this.lbl_Back.Text = "Back";
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(400, 9);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(423, 51);
            this.lbl_Add_New_Customer.TabIndex = 0;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(187, 21);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(308, 30);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Address.Location = new System.Drawing.Point(508, 74);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(88, 27);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(14, 74);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(161, 27);
            this.lbl_Customer_Name.TabIndex = 3;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(508, 24);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(115, 27);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile No.";
            // 
            // dtp_Cust_Added_Date
            // 
            this.dtp_Cust_Added_Date.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Cust_Added_Date.Location = new System.Drawing.Point(945, 48);
            this.dtp_Cust_Added_Date.Name = "dtp_Cust_Added_Date";
            this.dtp_Cust_Added_Date.Size = new System.Drawing.Size(223, 30);
            this.dtp_Cust_Added_Date.TabIndex = 11;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(631, 79);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(308, 30);
            this.tb_Address.TabIndex = 8;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(631, 21);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(308, 30);
            this.tb_Mobile_No.TabIndex = 3;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(187, 71);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(308, 30);
            this.tb_Customer_Name.TabIndex = 2;
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(14, 24);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(131, 27);
            this.lbl_Customer_Id.TabIndex = 0;
            this.lbl_Customer_Id.Text = "Customer ID";
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Customer_Details.Controls.Add(this.dtp_Cust_Added_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Address);
            this.gb_Customer_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Customer_Details.Controls.Add(this.lbl_Address);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Id);
            this.gb_Customer_Details.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.ForeColor = System.Drawing.Color.MediumBlue;
            this.gb_Customer_Details.Location = new System.Drawing.Point(0, 76);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1182, 124);
            this.gb_Customer_Details.TabIndex = 10;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "CUSTOMER DETAILS";
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Purchase_Details.Controls.Add(this.dgv_Customer_Details);
            this.gb_Purchase_Details.Controls.Add(this.btn_Add);
            this.gb_Purchase_Details.Controls.Add(this.btn_Confirm);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Category);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Subcategory);
            this.gb_Purchase_Details.Controls.Add(this.tb_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.tb_Price);
            this.gb_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Category);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Subcategory);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.ForeColor = System.Drawing.Color.MediumBlue;
            this.gb_Purchase_Details.Location = new System.Drawing.Point(0, 206);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(1182, 340);
            this.gb_Purchase_Details.TabIndex = 11;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "PURCHASE DETAILS";
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(687, 14);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(481, 320);
            this.dgv_Customer_Details.TabIndex = 53;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(563, 125);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 40);
            this.btn_Add.TabIndex = 51;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.White;
            this.btn_Confirm.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Confirm.Location = new System.Drawing.Point(546, 187);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(120, 40);
            this.btn_Confirm.TabIndex = 52;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(214, 20);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(308, 31);
            this.cmb_Category.TabIndex = 50;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(214, 128);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(308, 31);
            this.cmb_Product_Name.TabIndex = 48;
            // 
            // cmb_Subcategory
            // 
            this.cmb_Subcategory.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory.FormattingEnabled = true;
            this.cmb_Subcategory.Location = new System.Drawing.Point(214, 73);
            this.cmb_Subcategory.Name = "cmb_Subcategory";
            this.cmb_Subcategory.Size = new System.Drawing.Size(308, 31);
            this.cmb_Subcategory.TabIndex = 47;
            // 
            // tb_GST_Applied
            // 
            this.tb_GST_Applied.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST_Applied.Location = new System.Drawing.Point(214, 181);
            this.tb_GST_Applied.Name = "tb_GST_Applied";
            this.tb_GST_Applied.Size = new System.Drawing.Size(308, 30);
            this.tb_GST_Applied.TabIndex = 46;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(214, 286);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(308, 30);
            this.tb_Price.TabIndex = 44;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(214, 234);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(308, 30);
            this.tb_Quantity.TabIndex = 45;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Product_Name.Location = new System.Drawing.Point(20, 132);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(143, 27);
            this.lbl_Product_Name.TabIndex = 42;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Price.Location = new System.Drawing.Point(24, 287);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(57, 27);
            this.lbl_Price.TabIndex = 41;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_GST_Applied.Location = new System.Drawing.Point(20, 184);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(133, 27);
            this.lbl_GST_Applied.TabIndex = 40;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Category.Location = new System.Drawing.Point(21, 24);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(94, 27);
            this.lbl_Category.TabIndex = 38;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Subcategory.Location = new System.Drawing.Point(20, 77);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(125, 27);
            this.lbl_Subcategory.TabIndex = 39;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Quantity.Location = new System.Drawing.Point(20, 235);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(94, 27);
            this.lbl_Quantity.TabIndex = 43;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Bill_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Bill_Details.Controls.Add(this.tb_Discount);
            this.gb_Bill_Details.Controls.Add(this.tb_Total_Prise);
            this.gb_Bill_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Discount);
            this.gb_Bill_Details.Controls.Add(this.lbl_Total_Prise);
            this.gb_Bill_Details.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Details.ForeColor = System.Drawing.Color.MediumBlue;
            this.gb_Bill_Details.Location = new System.Drawing.Point(0, 552);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(1182, 76);
            this.gb_Bill_Details.TabIndex = 12;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "BILL DETAILS";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(892, 25);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(277, 30);
            this.tb_Total_Bill.TabIndex = 8;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(506, 27);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(277, 30);
            this.tb_Discount.TabIndex = 2;
            // 
            // tb_Total_Prise
            // 
            this.tb_Total_Prise.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Prise.Location = new System.Drawing.Point(122, 27);
            this.tb_Total_Prise.Name = "tb_Total_Prise";
            this.tb_Total_Prise.Size = new System.Drawing.Size(277, 30);
            this.tb_Total_Prise.TabIndex = 1;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(790, 27);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(96, 27);
            this.lbl_Total_Bill.TabIndex = 7;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Discount.Location = new System.Drawing.Point(405, 27);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(95, 27);
            this.lbl_Discount.TabIndex = 3;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Total_Prise
            // 
            this.lbl_Total_Prise.AutoSize = true;
            this.lbl_Total_Prise.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Prise.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Total_Prise.Location = new System.Drawing.Point(5, 27);
            this.lbl_Total_Prise.Name = "lbl_Total_Prise";
            this.lbl_Total_Prise.Size = new System.Drawing.Size(110, 27);
            this.lbl_Total_Prise.TabIndex = 0;
            this.lbl_Total_Prise.Text = "Total Prise";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(351, 640);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 40);
            this.btn_Save.TabIndex = 54;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.Location = new System.Drawing.Point(760, 640);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 40);
            this.btn_Reset.TabIndex = 55;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // frm_Add_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.gb_Bill_Details);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer Details";
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.gb_Bill_Details.ResumeLayout(false);
            this.gb_Bill_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_Cust_Added_Date;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_GST_Applied;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_GST_Applied;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Total_Prise;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Total_Prise;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
    }
}