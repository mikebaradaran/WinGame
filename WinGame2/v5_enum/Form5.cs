using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinGame2.v4_Shape;

namespace WinGame2.v5_enum
{
    public partial class Form5 : Form
    {
        World world = new World(new Rectangle(20, 20, 500, 400));
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            this.Paint += (s, ev) => { world.moveDraw(ev.Graphics); };
            t.Start();
        }
    }
}
