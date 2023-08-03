
namespace _03_Assignment
{
    partial class frm_Add_Image
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
            this.lbl_Insert_Image = new System.Windows.Forms.Label();
            this.lbl_Image_Id = new System.Windows.Forms.Label();
            this.lbl_Image_Des = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.tb_Image_Id = new System.Windows.Forms.TextBox();
            this.tb_Image_Des = new System.Windows.Forms.TextBox();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Show_Images = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Insert_Image
            // 
            this.lbl_Insert_Image.AutoSize = true;
            this.lbl_Insert_Image.BackColor = System.Drawing.Color.White;
            this.lbl_Insert_Image.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Insert_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Insert_Image.Location = new System.Drawing.Point(463, 41);
            this.lbl_Insert_Image.Name = "lbl_Insert_Image";
            this.lbl_Insert_Image.Size = new System.Drawing.Size(348, 62);
            this.lbl_Insert_Image.TabIndex = 0;
            this.lbl_Insert_Image.Text = "Insert Image";
            // 
            // lbl_Image_Id
            // 
            this.lbl_Image_Id.AutoSize = true;
            this.lbl_Image_Id.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Id.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image_Id.Location = new System.Drawing.Point(22, 195);
            this.lbl_Image_Id.Name = "lbl_Image_Id";
            this.lbl_Image_Id.Size = new System.Drawing.Size(145, 34);
            this.lbl_Image_Id.TabIndex = 1;
            this.lbl_Image_Id.Text = "Image Id";
            // 
            // lbl_Image_Des
            // 
            this.lbl_Image_Des.AutoSize = true;
            this.lbl_Image_Des.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Des.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image_Des.Location = new System.Drawing.Point(22, 305);
            this.lbl_Image_Des.Name = "lbl_Image_Des";
            this.lbl_Image_Des.Size = new System.Drawing.Size(292, 34);
            this.lbl_Image_Des.TabIndex = 2;
            this.lbl_Image_Des.Text = "Image Description";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image.Location = new System.Drawing.Point(896, 124);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(106, 34);
            this.lbl_Image.TabIndex = 3;
            this.lbl_Image.Text = "Image";
            // 
            // tb_Image_Id
            // 
            this.tb_Image_Id.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Id.Location = new System.Drawing.Point(346, 192);
            this.tb_Image_Id.MaxLength = 10;
            this.tb_Image_Id.Name = "tb_Image_Id";
            this.tb_Image_Id.Size = new System.Drawing.Size(303, 43);
            this.tb_Image_Id.TabIndex = 1;
            this.tb_Image_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Image_Des
            // 
            this.tb_Image_Des.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Des.Location = new System.Drawing.Point(346, 305);
            this.tb_Image_Des.MaxLength = 50;
            this.tb_Image_Des.Multiline = true;
            this.tb_Image_Des.Name = "tb_Image_Des";
            this.tb_Image_Des.Size = new System.Drawing.Size(303, 240);
            this.tb_Image_Des.TabIndex = 2;
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.SystemColors.Window;
            this.pb_Image.Location = new System.Drawing.Point(741, 189);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(383, 330);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 5;
            this.pb_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Browse.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Browse.Location = new System.Drawing.Point(873, 535);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(145, 44);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Teal;
            this.btn_Reset.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Purple;
            this.btn_Reset.Location = new System.Drawing.Point(59, 623);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(145, 56);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Teal;
            this.btn_Save.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Purple;
            this.btn_Save.Location = new System.Drawing.Point(461, 623);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(145, 56);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Show_Images
            // 
            this.btn_Show_Images.BackColor = System.Drawing.Color.Teal;
            this.btn_Show_Images.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Images.ForeColor = System.Drawing.Color.Purple;
            this.btn_Show_Images.Location = new System.Drawing.Point(838, 623);
            this.btn_Show_Images.Name = "btn_Show_Images";
            this.btn_Show_Images.Size = new System.Drawing.Size(286, 56);
            this.btn_Show_Images.TabIndex = 6;
            this.btn_Show_Images.Text = "Show Images";
            this.btn_Show_Images.UseVisualStyleBackColor = false;
            this.btn_Show_Images.Click += new System.EventHandler(this.btn_Show_Images_Click);
            // 
            // frm_Add_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btn_Show_Images);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.tb_Image_Des);
            this.Controls.Add(this.tb_Image_Id);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Image_Des);
            this.Controls.Add(this.lbl_Image_Id);
            this.Controls.Add(this.lbl_Insert_Image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Image";
            this.Load += new System.EventHandler(this.frm_Add_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Insert_Image;
        private System.Windows.Forms.Label lbl_Image_Id;
        private System.Windows.Forms.Label lbl_Image_Des;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.TextBox tb_Image_Id;
        private System.Windows.Forms.TextBox tb_Image_Des;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Show_Images;
    }
}

