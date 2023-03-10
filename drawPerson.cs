namespace draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //draw preson 
            Pen color = new Pen (Color.White); //color to draw
            //body
            g.DrawLine(color, new PointF(100,this.Height-200), new PointF(100,this.Height-120)); //color, point A(start), point B (end)
            //leg1
            g.DrawLine(color, new PointF(100, this.Height - 120), new PointF(80, this.Height - 100));
            //leg2
            g.DrawLine(color, new PointF(100, this.Height - 120), new PointF(120, this.Height - 100));
            //arm1
            g.DrawLine(color, new PointF(100, this.Height - 150), new PointF(80, this.Height - 180));
            //arm2
            g.DrawLine(color, new PointF(100, this.Height - 150), new PointF(120, this.Height - 180));
            //head
            g.DrawEllipse(color,75,this.Height-250,50,50);


        }
    }
}
