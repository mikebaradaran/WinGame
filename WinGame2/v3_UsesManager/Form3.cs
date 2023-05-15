using System;
using System.Windows.Forms;

namespace WinGame3
{
    // uses a manager Balls class
    public partial class Form3 : Form
    {
        BallsManager ballsManager = new BallsManager();

        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Timer t = new Timer();
            t.Interval = 50;

            t.Tick += (s, ev) => {
                this.Invalidate();
            };
            t.Start();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            ballsManager.moveDraw(e.Graphics);
        }
    }
}

