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

namespace _03_Assignment
{
    public partial class frm_Add_Image : Form
    {
        public frm_Add_Image()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-B27E96R;Initial Catalog=Picture_Box_Image_Assignment_DB;Integrated Security=True");

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
            tb_Image_Des.Clear();
            pb_Image.Image = null;

            Auto_Incr();
            tb_Image_Des.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true; 
            }
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Image_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Image_Id) from Image_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_Image_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        private void frm_Add_Image_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg;)|*.jpg";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Image_Id.Text != "" && tb_Image_Des.Text != "" && pb_Image.Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Image_Details Values (@ID, @Image_Description, @Image)", Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Image_Id.Text;
                cmd.Parameters.Add("@Image_Description", SqlDbType.NVarChar).Value = tb_Image_Des.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully.");

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Show_Images_Click(object sender, EventArgs e)
        {
            frm_Show_Image Obj = new frm_Show_Image();
            Obj.Show();
            this.Hide();
        }
    }
}
