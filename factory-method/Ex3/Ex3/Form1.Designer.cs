namespace Ex3
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
            btn_VT = new ToolStripButton();
            btn_VP = new ToolStripButton();
            btn_Can = new ToolStripButton();
            btn_Deu = new ToolStripButton();
            btn_Circle = new ToolStripButton();
            btn_Rec = new ToolStripButton();
            btn_Square = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_VT, btn_VP, btn_Can, btn_Deu, btn_Circle, btn_Rec, btn_Square });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_VT
            // 
            btn_VT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_VT.Image = (Image)resources.GetObject("btn_VT.Image");
            btn_VT.ImageTransparentColor = Color.Magenta;
            btn_VT.Name = "btn_VT";
            btn_VT.Size = new Size(82, 22);
            btn_VT.Text = "TG Vuông trái";
            btn_VT.Click += btn_VT_Click;
            // 
            // btn_VP
            // 
            btn_VP.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_VP.Image = (Image)resources.GetObject("btn_VP.Image");
            btn_VP.ImageTransparentColor = Color.Magenta;
            btn_VP.Name = "btn_VP";
            btn_VP.Size = new Size(88, 22);
            btn_VP.Text = "TG Vuông phải";
            btn_VP.Click += btn_VP_Click;
            // 
            // btn_Can
            // 
            btn_Can.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_Can.Image = (Image)resources.GetObject("btn_Can.Image");
            btn_Can.ImageTransparentColor = Color.Magenta;
            btn_Can.Name = "btn_Can";
            btn_Can.Size = new Size(48, 22);
            btn_Can.Text = "TG Cân";
            btn_Can.Click += btn_Can_Click;
            // 
            // btn_Deu
            // 
            btn_Deu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_Deu.Image = (Image)resources.GetObject("btn_Deu.Image");
            btn_Deu.ImageTransparentColor = Color.Magenta;
            btn_Deu.Name = "btn_Deu";
            btn_Deu.Size = new Size(48, 22);
            btn_Deu.Text = "TG Đều";
            btn_Deu.Click += btn_Deu_Click;
            // 
            // btn_Circle
            // 
            btn_Circle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_Circle.Image = (Image)resources.GetObject("btn_Circle.Image");
            btn_Circle.ImageTransparentColor = Color.Magenta;
            btn_Circle.Name = "btn_Circle";
            btn_Circle.Size = new Size(34, 22);
            btn_Circle.Text = "Tròn";
            btn_Circle.Click += btn_Circle_Click;
            // 
            // btn_Rec
            // 
            btn_Rec.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_Rec.Image = (Image)resources.GetObject("btn_Rec.Image");
            btn_Rec.ImageTransparentColor = Color.Magenta;
            btn_Rec.Name = "btn_Rec";
            btn_Rec.Size = new Size(60, 22);
            btn_Rec.Text = "Chữ nhật";
            btn_Rec.Click += btn_Rec_Click;
            // 
            // btn_Square
            // 
            btn_Square.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_Square.Image = (Image)resources.GetObject("btn_Square.Image");
            btn_Square.ImageTransparentColor = Color.Magenta;
            btn_Square.Name = "btn_Square";
            btn_Square.Size = new Size(46, 22);
            btn_Square.Text = "Vuông";
            btn_Square.Click += btn_Square_Click;
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
        private ToolStripButton btn_VT;
        private ToolStripButton btn_VP;
        private ToolStripButton btn_Can;
        private ToolStripButton btn_Deu;
        private ToolStripButton btn_Circle;
        private ToolStripButton btn_Rec;
        private ToolStripButton btn_Square;
    }
}