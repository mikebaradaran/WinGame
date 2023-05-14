using System;
using System.Drawing;


namespace WinGame2.TwoPerPape
{
    public class World
    {
        public Rectangle bounds;

        public Shape[] balls;
        public World(Rectangle rec)
        {
            bounds = rec;

            balls = new Shape[] {
                new Shape(new Rectangle(bounds.X+10, bounds.Y+10, 30, 30), 1, 3),
                new Shape(new Rectangle(bounds.X+50, bounds.Y+10, 30, 30), 2, 5),
                new Shape(new Rectangle(bounds.X+20, bounds.Y+30, 30, 20), 3, 2, ShapeType.Oval),
                new Shape(new Rectangle(bounds.X+60, bounds.Y+30, 30, 50), 5, 1, ShapeType.Oval),
                new Shape(new Rectangle(bounds.X+70, bounds.Y+10, 30, 30), 3, 3)
            };
        }

        public void moveDraw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, bounds);

            foreach (var ball in balls)
            {
                ball.move(bounds);
                if(ball.Type == ShapeType.Oval)
                    g.FillEllipse(Brushes.Blue, ball.rec);
                else if (ball.Type == ShapeType.Rectangle)
                    g.FillRectangle(Brushes.Yellow, ball.rec);
            }

        }
    }

}
