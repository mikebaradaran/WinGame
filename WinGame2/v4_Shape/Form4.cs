using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinGame2.v4_Shape
{
    public partial class Form4 : Form
    {

        World world = new World(new Rectangle(20, 20, 500, 400));
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Left)
                {
                    if (ev.Control)
                        world.bounds.Width -= 10;
                    else
                        world.bounds.X -= 10;
                }
                else if (ev.KeyCode == Keys.Right)
                {
                    if (ev.Control)
                        world.bounds.Width += 10;
                    else
                        world.bounds.X += 10;
                }
            };

            Timer t = new Timer();
            t.Interval = 50;

            t.Tick += (s, ev) =>
            {
                this.Invalidate();
            };
            t.Start();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            world.moveDraw(e.Graphics);
        }
    }
}
