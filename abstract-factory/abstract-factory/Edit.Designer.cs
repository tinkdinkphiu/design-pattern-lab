namespace abstract_factory
{
    partial class Edit
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
            label1 = new Label();
            txt_EditMSSV = new TextBox();
            label2 = new Label();
            txt_EditFullname = new TextBox();
            label3 = new Label();
            txt_EditBirthDate = new TextBox();
            label4 = new Label();
            txt_EditStudentClass = new TextBox();
            btn_Cancel = new Button();
            btn_Confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // txt_EditMSSV
            // 
            txt_EditMSSV.Location = new Point(12, 27);
            txt_EditMSSV.Name = "txt_EditMSSV";
            txt_EditMSSV.Size = new Size(200, 23);
            txt_EditMSSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Fullname";
            // 
            // txt_EditFullname
            // 
            txt_EditFullname.Location = new Point(12, 71);
            txt_EditFullname.Name = "txt_EditFullname";
            txt_EditFullname.Size = new Size(200, 23);
            txt_EditFullname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "BirthDate";
            // 
            // txt_EditBirthDate
            // 
            txt_EditBirthDate.Location = new Point(12, 115);
            txt_EditBirthDate.Name = "txt_EditBirthDate";
            txt_EditBirthDate.Size = new Size(200, 23);
            txt_EditBirthDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "StudentClass";
            // 
            // txt_EditStudentClass
            // 
            txt_EditStudentClass.Location = new Point(12, 159);
            txt_EditStudentClass.Name = "txt_EditStudentClass";
            txt_EditStudentClass.Size = new Size(200, 23);
            txt_EditStudentClass.TabIndex = 7;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(12, 197);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Location = new Point(137, 197);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(75, 23);
            btn_Confirm.TabIndex = 9;
            btn_Confirm.Text = "Lưu";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 234);
            Controls.Add(btn_Confirm);
            Controls.Add(btn_Cancel);
            Controls.Add(txt_EditStudentClass);
            Controls.Add(label4);
            Controls.Add(txt_EditBirthDate);
            Controls.Add(label3);
            Controls.Add(txt_EditFullname);
            Controls.Add(label2);
            Controls.Add(txt_EditMSSV);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_EditMSSV;
        private Label label2;
        private TextBox txt_EditFullname;
        private Label label3;
        private TextBox txt_EditBirthDate;
        private Label label4;
        private TextBox txt_EditStudentClass;
        private Button btn_Cancel;
        private Button btn_Confirm;
    }
}