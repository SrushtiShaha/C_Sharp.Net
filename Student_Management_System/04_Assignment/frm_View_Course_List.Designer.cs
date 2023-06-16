
namespace Student_Management_System
{
    partial class frm_View_Course_List
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
            this.lbl_View_Course_List = new System.Windows.Forms.Label();
            this.dgv_Course_List = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet2 = new Student_Management_System.Student_Management_System_DBDataSet2();
            this.course_ListTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet2TableAdapters.Course_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Course_List
            // 
            this.lbl_View_Course_List.AutoSize = true;
            this.lbl_View_Course_List.BackColor = System.Drawing.Color.White;
            this.lbl_View_Course_List.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Course_List.ForeColor = System.Drawing.Color.Blue;
            this.lbl_View_Course_List.Location = new System.Drawing.Point(371, 46);
            this.lbl_View_Course_List.Name = "lbl_View_Course_List";
            this.lbl_View_Course_List.Size = new System.Drawing.Size(471, 68);
            this.lbl_View_Course_List.TabIndex = 1;
            this.lbl_View_Course_List.Text = "View Course List";
            // 
            // dgv_Course_List
            // 
            this.dgv_Course_List.AllowUserToAddRows = false;
            this.dgv_Course_List.AllowUserToDeleteRows = false;
            this.dgv_Course_List.AutoGenerateColumns = false;
            this.dgv_Course_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MingLiU-ExtB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Course_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Course_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Course_List.DataSource = this.courseListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Course_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Course_List.Location = new System.Drawing.Point(12, 183);
            this.dgv_Course_List.Name = "dgv_Course_List";
            this.dgv_Course_List.ReadOnly = true;
            this.dgv_Course_List.RowHeadersWidth = 51;
            this.dgv_Course_List.RowTemplate.Height = 24;
            this.dgv_Course_List.Size = new System.Drawing.Size(1158, 658);
            this.dgv_Course_List.TabIndex = 2;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseListBindingSource
            // 
            this.courseListBindingSource.DataMember = "Course_List";
            this.courseListBindingSource.DataSource = this.student_Management_System_DBDataSet2;
            // 
            // student_Management_System_DBDataSet2
            // 
            this.student_Management_System_DBDataSet2.DataSetName = "Student_Management_System_DBDataSet2";
            this.student_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_ListTableAdapter
            // 
            this.course_ListTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Course_List);
            this.Controls.Add(this.lbl_View_Course_List);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Course List";
            this.Load += new System.EventHandler(this.frm_View_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Course_List;
        private System.Windows.Forms.DataGridView dgv_Course_List;
        private Student_Management_System_DBDataSet2 student_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource courseListBindingSource;
        private Student_Management_System_DBDataSet2TableAdapters.Course_ListTableAdapter course_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}