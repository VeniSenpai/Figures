namespace figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(TriangleThread);
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread2 = new Thread(RectangleThread);
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread3 = new Thread(CircleThread);
            thread3.Start();
        }
        public void TriangleThread()
        {

            int random = new Random().Next(1, 1000);
            for (int i = 0; i < random; i++)
            {
                Random rnd = new Random();
                Color Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen Pen = new Pen(Color, 4);
                int n = new Random().Next(20, 170);
                PointF point1 = new PointF(new Random().Next(0, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height) + new Random().Next(20, 170));
                PointF point2 = new PointF(new Random().Next(0, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height) + new Random().Next(20, 170));
                PointF point3 = new PointF(new Random().Next(0, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height) + new Random().Next(20, 170));
                PointF[] curvePoints =
                         {
                 point1,
                 point2,
                 point3,
             };

                this.CreateGraphics().DrawPolygon(Pen, curvePoints);
                Thread.Sleep(2000);
            }
        }
        public void RectangleThread()
        {
            int random = new Random().Next(1, 10000);
            for (int i = 0; i < random; i++)
            {
                Random rnd = new Random();
                Color Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int b = new Random().Next(20, 170);
                int n = new Random().Next(20, 170);
                this.CreateGraphics().DrawRectangle(new Pen(Color, 4), new Rectangle(new Random().Next(0, this.Width), new Random().Next(0, this.Height), n, b));

                Thread.Sleep(3000);

            }
        }

        public void CircleThread()
        {
            int random = new Random().Next(1, 10000);
            for (int i = 0; i < random; i++)
            {
                {
                    Random rnd = new Random();
                    Color Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    int n = new Random().Next(20, 170);
                    this.CreateGraphics().DrawEllipse(new Pen(Color, 4), new Random().Next(200, this.Width), new Random().Next(0, this.Height), n, n);
                    Thread.Sleep(4000);
                }
            }
        }
    }
}
