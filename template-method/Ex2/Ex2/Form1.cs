namespace Ex2
{
    public partial class Form1 : Form
    {
        TriangleType triangleType = TriangleType.VT;
        bool drawingFlag = false;
        List<Triangle> triangles = new List<Triangle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drawingFlag = true;
            foreach (var tri in triangles)
            {
                if (tri.IsInside(e.Location))
                {
                    foreach (var tris in triangles)
                    {
                        tris.Color = Color.Black;
                    }
                    tri.Color = Color.Red;
                    Invalidate();
                    return;
                }
            }

            Triangle triangle = new TriangleSimpleFactory().CreateTriangle(triangleType);
            triangle.pointA = triangle.pointB = e.Location;
            triangles.Add(triangle);
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
                triangles[triangles.Count - 1].pointB = e.Location;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var triangle in triangles)
            {
                triangle.Draw(e.Graphics);
            }
        }

        private void btnVuongTrai_Click(object sender, EventArgs e)
        {
            triangleType = TriangleType.VT;
        }

        private void btnVuongPhai_Click(object sender, EventArgs e)
        {
            triangleType = TriangleType.VP;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            triangleType = TriangleType.C;
        }

        private void btnDeu_Click(object sender, EventArgs e)
        {
            triangleType = TriangleType.D;
        }
    }
}