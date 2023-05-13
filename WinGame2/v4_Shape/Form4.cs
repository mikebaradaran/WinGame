using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinGame2.v4_Shape
{
    public partial class Form4 : Form
    {

        World world = new World(new Rectangle(20,20,500,400));
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Timer t = new Timer();
            t.Interval = 50;

            t.Tick += (s, ev) => {
                this.Invalidate();
            };
            t.Start();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            world.moveDraw(e.Graphics);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            world.bounds.X -= 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            world.bounds.X += 10;
        }
    }
}
