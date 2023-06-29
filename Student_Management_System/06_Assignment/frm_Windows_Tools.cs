using System;
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
            bool Flag = true;

            if(tb_Name.Text != "")
            {
                Result = tb_Name.Text + " Is From Department ";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Visible = true;
                lbl_Name_Error.Text = "Enter Employee Name.";
                Flag = false;
            }

            if (cmb_Department.Text != "")
            {
                Result += cmb_Department.Text;
                lbl_Department_Error.Visible = false;
            }
            else
            {
                lbl_Department_Error.Visible = true;
                lbl_Department_Error.Text = "Select Employee Department.";
                Flag = false;
            }

            if (rb_Male.Checked == true)
            {
                Result += ", Is " + rb_Male.Text + " Candidate. He Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else if (rb_Female.Checked == true)
            {
                Result += ", Is " + rb_Female.Text + " Candidate. She Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Visible = true;
                lbl_Gender_Error.Text = "Select Employee Gender.";
                Flag = false;
            }

            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text;
                lbl_Language_Error.Visible = false;

                if (cb_Hindi.Checked == true)
                {
                    Result += ", " + cb_Hindi.Text;
                    lbl_Language_Error.Visible = false;

                    if (cb_English.Checked == true)
                    {
                        Result += ", " + cb_English.Text;
                        lbl_Language_Error.Visible = false;

                        if (cb_French.Checked == true)
                        {
                            Result += ", " + cb_French.Text + ". ";
                            lbl_Language_Error.Visible = false;
                        }
                    }
                }
            }
            else
            {
                lbl_Language_Error.Visible = true;
                lbl_Language_Error.Text = "Select Language.";
                Flag = false;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobby_Error.Visible = false;
                Result += " And Has Hobby As ";
            }
            else
            {
                lbl_Hobby_Error.Visible = true;
                lbl_Hobby_Error.Text = "Select Hobby.";
                Flag = false;
            }

            for( int i = 0; i < clb_Hobbies.Items.Count; i++ )
            {
                if(clb_Hobbies.GetItemChecked(i))
                {
                    if(Cnt > 1)
                    {
                        Result += clb_Hobbies.Items[i] + ", ";
                    }
                    else
                    {
                        Result += clb_Hobbies.Items[i] + ".";
                    }

                    Cnt--;
                }
            }

            if (Flag == false)
            {
                lbl_Result_Text.Visible = false;
            }
            else
            {
                lbl_Result_Text.Text = Result;
                lbl_Result_Text.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Name_Error.Visible = false;
            lbl_Department_Error.Visible = false;
            lbl_Gender_Error.Visible = false;
            lbl_Language_Error.Visible = false;
            lbl_Hobby_Error.Visible = false;

            lbl_Result_Text.Visible = false;
        }

        private void lbl_Result_Text_Click(object sender, EventArgs e)
        {

        }
    }
}