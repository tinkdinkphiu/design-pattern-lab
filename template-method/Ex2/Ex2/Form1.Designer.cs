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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnCan = new ToolStripButton();
            btnDeu = new ToolStripButton();
            btnVuongPhai = new ToolStripButton();
            btnVuongTrai = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCan, btnDeu, btnVuongPhai, btnVuongTrai });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCan
            // 
            btnCan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCan.Image = (Image)resources.GetObject("btnCan.Image");
            btnCan.ImageTransparentColor = Color.Magenta;
            btnCan.Name = "btnCan";
            btnCan.Size = new Size(32, 22);
            btnCan.Text = "Cân";
            btnCan.Click += btnCan_Click;
            // 
            // btnDeu
            // 
            btnDeu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDeu.Image = (Image)resources.GetObject("btnDeu.Image");
            btnDeu.ImageTransparentColor = Color.Magenta;
            btnDeu.Name = "btnDeu";
            btnDeu.Size = new Size(32, 22);
            btnDeu.Text = "Đều";
            btnDeu.Click += btnDeu_Click;
            // 
            // btnVuongPhai
            // 
            btnVuongPhai.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVuongPhai.Image = (Image)resources.GetObject("btnVuongPhai.Image");
            btnVuongPhai.ImageTransparentColor = Color.Magenta;
            btnVuongPhai.Name = "btnVuongPhai";
            btnVuongPhai.Size = new Size(72, 22);
            btnVuongPhai.Text = "Vuông phải";
            btnVuongPhai.Click += btnVuongPhai_Click;
            // 
            // btnVuongTrai
            // 
            btnVuongTrai.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVuongTrai.Image = (Image)resources.GetObject("btnVuongTrai.Image");
            btnVuongTrai.ImageTransparentColor = Color.Magenta;
            btnVuongTrai.Name = "btnVuongTrai";
            btnVuongTrai.Size = new Size(66, 22);
            btnVuongTrai.Text = "Vuông trái";
            btnVuongTrai.Click += btnVuongTrai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCan;
        private ToolStripButton btnDeu;
        private ToolStripButton btnVuongPhai;
        private ToolStripButton btnVuongTrai;
    }
}