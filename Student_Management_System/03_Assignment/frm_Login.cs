using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-B27E96R;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if( Con.State != ConnectionState.Open )
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if( Con.State != ConnectionState.Closed )
            {
                Con.Close();
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Visible = true;
            lbl_Note.Text = "Enter Correct Username And Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Login_Details Where Username = @UNm And Password = @Pwd";

            Cmd.Parameters.Add("UNm", SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if( Cnt > 0 )
            {
                MessageBox.Show("Login Successful!!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_User = "Welcome " + tb_Username.Text;

                MDI_Student_App Obj = new MDI_Student_App();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();

            Con_Close();
        }
    }
}
