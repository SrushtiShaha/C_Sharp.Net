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

namespace Employee_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username And Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if( tb_Username.Text == "s" && tb_Password.Text == "s" )
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Employee obj = new frm_Add_New_Employee();
                obj.Show();
                this.Hide();
            }
            else 
            {
                lbl_Note.Text = "Incorrect Username Or Password!!!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
