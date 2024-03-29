﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Windows_Tools : Form
    {
        public frm_Windows_Tools()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void frm_Windows_Tools_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = false;
            
            if(tb_Name.Text != "")
            {
                Result = tb_Name.Text;

                if (cmb_Department.Text != "")
                {
                    Result += " From Department " + cmb_Department.Text + " is ";

                    if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Candidate, And Prefers Shift Time ";
                    }
                    else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Candidate, And Prefers Shift Time ";
                    }
                    else
                    {
                        MessageBox.Show("First Select Gender.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flag = true;
                    }

                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ". ";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("First Select Shift Time.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("First Select Department.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Flag = true;
                }

                if( Flag == false)
                {
                    tb_Output.Text = Result;
                }
            }
            else
            {
                MessageBox.Show("First Enter Name.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Flag = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Department.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
            tb_Output.Clear();
        }
    }
}