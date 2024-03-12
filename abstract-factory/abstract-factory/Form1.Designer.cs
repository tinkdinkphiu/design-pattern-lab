namespace abstract_factory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_MSSV = new TextBox();
            txt_Fullname = new TextBox();
            label2 = new Label();
            txt_BirthDate = new TextBox();
            label3 = new Label();
            txt_StudentClass = new TextBox();
            label4 = new Label();
            btn_Add = new Button();
            dataGridView1 = new DataGridView();
            MSSV = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            StudentClass = new DataGridViewTextBoxColumn();
            btn_Delete = new Button();
            btn_Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "MSSV";
            // 
            // txt_MSSV
            // 
            txt_MSSV.Location = new Point(78, 6);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(200, 23);
            txt_MSSV.TabIndex = 2;
            // 
            // txt_Fullname
            // 
            txt_Fullname.Location = new Point(78, 35);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(200, 23);
            txt_Fullname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            // 
            // txt_BirthDate
            // 
            txt_BirthDate.Location = new Point(78, 64);
            txt_BirthDate.Name = "txt_BirthDate";
            txt_BirthDate.Size = new Size(200, 23);
            txt_BirthDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // txt_StudentClass
            // 
            txt_StudentClass.Location = new Point(78, 93);
            txt_StudentClass.Name = "txt_StudentClass";
            txt_StudentClass.Size = new Size(200, 23);
            txt_StudentClass.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "Lớp";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(203, 122);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MSSV, Fullname, BirthDate, StudentClass });
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 298);
            dataGridView1.TabIndex = 10;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "MSSV";
            MSSV.Name = "MSSV";
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Fullname";
            Fullname.Name = "Fullname";
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "BirthDate";
            BirthDate.Name = "BirthDate";
            // 
            // StudentClass
            // 
            StudentClass.HeaderText = "StudentClass";
            StudentClass.Name = "StudentClass";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(697, 122);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(284, 122);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 23);
            btn_Edit.TabIndex = 12;
            btn_Edit.Text = "Sửa";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Add);
            Controls.Add(txt_StudentClass);
            Controls.Add(label4);
            Controls.Add(txt_BirthDate);
            Controls.Add(label3);
            Controls.Add(txt_Fullname);
            Controls.Add(label2);
            Controls.Add(txt_MSSV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_MSSV;
        private TextBox txt_Fullname;
        private Label label2;
        private TextBox txt_BirthDate;
        private Label label3;
        private TextBox txt_StudentClass;
        private Label label4;
        private Button btn_Add;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn StudentClass;
        private Button btn_Delete;
        private Button btn_Edit;
    }
}
