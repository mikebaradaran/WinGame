using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinGameV2;

namespace WinGame2
{
    public partial class Form2 : Form
    {
        Ball[] balls;
        public Form2()
        {
            InitializeComponent();

            balls = new Ball[] {
                new Ball(new Rectangle(10, 10, 30, 30), 1, 3),
                new Ball(new Rectangle(10, 10, 30, 30), 2, 5),
                new Ball(new Rectangle(20, 30, 30, 20), 3, 2),
                new Ball(new Rectangle(20, 30, 30, 50), 5, 1),
                new Ball(new Rectangle(10, 10, 30, 30), 3, 3)
            };
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.AntiqueWhite);

            e.Graphics.FillRectangle(Brushes.Red, Ball.world);

            foreach (var ball in balls)
            {
                ball.move();
                e.Graphics.FillEllipse(Brushes.Blue, ball.rec);
            }
        }
    }
}
