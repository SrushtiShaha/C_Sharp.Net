﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Management_System_DB_01;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Id.Clear();
            tb_Name.Clear();
            tb_MobNo.Clear();
            dtp_DOB.Text = "31 - 12 - 2010";
            cmb_Des.SelectedIndex = -1;

            tb_Id.Focus();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Id.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Emp_List_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List obj = new frm_View_Employee_List();
            obj.Show();
            this.Hide();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Id.Text != "" && tb_Name.Text != "" && tb_MobNo.Text != "" && cmb_Des.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Employee_Details Values(@Id, @Nm, @MobNo, @DOB, @Des)";

                cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Id.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_MobNo.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Des.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
    }
}
