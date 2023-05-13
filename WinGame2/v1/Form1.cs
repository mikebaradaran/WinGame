using System;
using System.Drawing;
using System.Windows.Forms;
using WinGameV1;

namespace WinGame2
{
    public partial class Form1 : Form
    {
        Ball[] balls;
        public Form1()
        {
            InitializeComponent();

            balls = new Ball[] {
                new Ball(10, 10, 30, 30, 1, 3),
                new Ball(10, 10, 30, 30, 2, 5),
                new Ball(20, 30, 30, 20, 3, 2),
                new Ball(20, 30, 30, 50, 5, 1),
                new Ball(10, 10, 30, 30, 3, 3)
            };
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.AntiqueWhite);

            e.Graphics.FillRectangle(Brushes.Red, Ball.worldX, Ball.worldY, Ball.worldW, Ball.worldH);

            foreach (var ball in balls)
            {
                ball.move();
                e.Graphics.FillEllipse(Brushes.Blue, ball.x, ball.y, ball.w, ball.h);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();

            t.Interval = 50;

            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
