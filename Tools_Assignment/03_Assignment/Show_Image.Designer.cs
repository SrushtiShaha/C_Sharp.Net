
namespace _03_Assignment
{
    partial class frm_Show_Image
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Show_Image = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.picture_Box_Image_Assignment_DBDataSet = new _03_Assignment.Picture_Box_Image_Assignment_DBDataSet();
            this.imageDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.image_DetailsTableAdapter = new _03_Assignment.Picture_Box_Image_Assignment_DBDataSetTableAdapters.Image_DetailsTableAdapter();
            this.btn_Add_Images = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box_Image_Assignment_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Show_Image
            // 
            this.lbl_Show_Image.AutoSize = true;
            this.lbl_Show_Image.BackColor = System.Drawing.Color.White;
            this.lbl_Show_Image.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Show_Image.Location = new System.Drawing.Point(428, 28);
            this.lbl_Show_Image.Name = "lbl_Show_Image";
            this.lbl_Show_Image.Size = new System.Drawing.Size(332, 62);
            this.lbl_Show_Image.TabIndex = 1;
            this.lbl_Show_Image.Text = "Show Image";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image.Location = new System.Drawing.Point(212, 124);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(106, 34);
            this.lbl_Image.TabIndex = 4;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image_List.Location = new System.Drawing.Point(813, 124);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(170, 34);
            this.lbl_Image_List.TabIndex = 5;
            this.lbl_Image_List.Text = "Image List";
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.SystemColors.Window;
            this.pb_Image.Location = new System.Drawing.Point(20, 181);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(489, 402);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 6;
            this.pb_Image.TabStop = false;
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.AllowUserToAddRows = false;
            this.dgv_Image_List.AllowUserToDeleteRows = false;
            this.dgv_Image_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Image_List.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Image_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(601, 181);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Image_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Image_List.RowHeadersWidth = 51;
            this.dgv_Image_List.RowTemplate.Height = 24;
            this.dgv_Image_List.Size = new System.Drawing.Size(550, 402);
            this.dgv_Image_List.TabIndex = 7;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged);
            // 
            // picture_Box_Image_Assignment_DBDataSet
            // 
            this.picture_Box_Image_Assignment_DBDataSet.DataSetName = "Picture_Box_Image_Assignment_DBDataSet";
            this.picture_Box_Image_Assignment_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageDetailsBindingSource
            // 
            this.imageDetailsBindingSource.DataMember = "Image_Details";
            this.imageDetailsBindingSource.DataSource = this.picture_Box_Image_Assignment_DBDataSet;
            // 
            // image_DetailsTableAdapter
            // 
            this.image_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_Images
            // 
            this.btn_Add_Images.BackColor = System.Drawing.Color.Teal;
            this.btn_Add_Images.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Images.ForeColor = System.Drawing.Color.Purple;
            this.btn_Add_Images.Location = new System.Drawing.Point(448, 619);
            this.btn_Add_Images.Name = "btn_Add_Images";
            this.btn_Add_Images.Size = new System.Drawing.Size(261, 56);
            this.btn_Add_Images.TabIndex = 8;
            this.btn_Add_Images.Text = "Add Image";
            this.btn_Add_Images.UseVisualStyleBackColor = false;
            this.btn_Add_Images.Click += new System.EventHandler(this.btn_Add_Images_Click);
            // 
            // frm_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btn_Add_Images);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Show_Image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Image";
            this.Load += new System.EventHandler(this.frm_Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box_Image_Assignment_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Show_Image;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private Picture_Box_Image_Assignment_DBDataSet picture_Box_Image_Assignment_DBDataSet;
        private System.Windows.Forms.BindingSource imageDetailsBindingSource;
        private Picture_Box_Image_Assignment_DBDataSetTableAdapters.Image_DetailsTableAdapter image_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Add_Images;
    }
}