using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-B27E96R;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Course_Nm.Clear();

            Auto_Incr();
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Course_List";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Course_Id) from Course_List";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Id.Text != "" && tb_Course_Nm.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Course_List Values(@Id, @Nm)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Course_Nm.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Inserted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
    }
}
