namespace Ex2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_int = new TextBox();
            txt_double = new TextBox();
            txt_string = new TextBox();
            txt_email = new TextBox();
            txt_datetime = new TextBox();
            btn_check = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "int";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "double";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "string";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "datetime";
            // 
            // txt_int
            // 
            txt_int.Location = new Point(72, 9);
            txt_int.Name = "txt_int";
            txt_int.Size = new Size(200, 23);
            txt_int.TabIndex = 5;
            // 
            // txt_double
            // 
            txt_double.Location = new Point(72, 38);
            txt_double.Name = "txt_double";
            txt_double.Size = new Size(200, 23);
            txt_double.TabIndex = 6;
            // 
            // txt_string
            // 
            txt_string.Location = new Point(72, 67);
            txt_string.Name = "txt_string";
            txt_string.Size = new Size(200, 23);
            txt_string.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(72, 96);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(200, 23);
            txt_email.TabIndex = 8;
            // 
            // txt_datetime
            // 
            txt_datetime.Location = new Point(72, 125);
            txt_datetime.Name = "txt_datetime";
            txt_datetime.Size = new Size(200, 23);
            txt_datetime.TabIndex = 9;
            // 
            // btn_check
            // 
            btn_check.Location = new Point(197, 154);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(75, 23);
            btn_check.TabIndex = 10;
            btn_check.Text = "Save";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 192);
            Controls.Add(btn_check);
            Controls.Add(txt_datetime);
            Controls.Add(txt_email);
            Controls.Add(txt_string);
            Controls.Add(txt_double);
            Controls.Add(txt_int);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_int;
        private TextBox txt_double;
        private TextBox txt_string;
        private TextBox txt_email;
        private TextBox txt_datetime;
        private Button btn_check;
    }
}