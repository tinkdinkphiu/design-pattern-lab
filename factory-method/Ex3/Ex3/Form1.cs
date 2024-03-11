namespace Ex3
{
    public partial class Form1 : Form
    {
        ShapeType shapeType = ShapeType.T;
        bool drawingFlag = false;
        List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_VT_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.VT;
        }

        private void btn_VP_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.VP;
        }

        private void btn_Can_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.C;
        }

        private void btn_Deu_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.D;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.T;
        }

        private void btn_Rec_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.CN;
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.V;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drawingFlag = true;
            foreach (var sha in shapes)
            {
                if (sha.IsInside(e.Location))
                {
                    foreach (var shas in shapes)
                    {
                        shas.color = Color.Black;
                    }
                    sha.color = Color.Red;
                    Invalidate();
                    return;
                }
            }

            Shape shape = new ShapeFactory().CreateShape(shapeType);
            shape.pointA = shape.pointB = e.Location;
            shapes.Add(shape);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drawingFlag = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawingFlag) { return; }
            else
            {
                shapes[shapes.Count - 1].pointB = e.Location;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}