using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinGame2.TwoPerPape
{
    public partial class Form6 : Form
    {
        World[] worlds = {
            new World(new Rectangle(2, 20, 300, 200)),
            new World(new Rectangle(310, 20, 300, 200)),
            new World(new Rectangle(50, 250, 300, 200))
        };
        public Form6()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            World currentWorld = worlds[0];

            this.MouseDown += (s, me) =>
            {
                currentWorld = getCurrentWorld(me.X, me.Y);
            };
            this.KeyDown += (s, ev) =>
            {
                World world = currentWorld;
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

            t.Tick += (s, ev) => { this.Invalidate(); };

            foreach (var world in worlds)
            {
                this.Paint += (s, ev) =>
                {
                    world.moveDraw(ev.Graphics);
                    Rectangle rec = currentWorld.bounds;
                    for (int i = 0, borderWidth=3; i < borderWidth; i++)
                    {
                        ev.Graphics.DrawRectangle(Pens.Black, rec);
                        rec.Offset(1, 1);
                    }
                };
            }
            t.Start();
        }
        private World getCurrentWorld(int x, int y)
        {
            foreach (var world in worlds)
            {
                if (world.bounds.Contains(x, y))
                    return world;
            }
            return worlds[0];
        }
    }
}
