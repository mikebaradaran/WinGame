using System;
using System.Drawing;


namespace WinGame.v7
{
    public class World : Shape
    {
        public Rectangle container;

        public Shape[] shapes;
        public World(Rectangle rec, int dirX, int dirY, Rectangle container) : base(rec, dirX, dirY)
        {
            this.container = container;
            
            shapes = new Shape[] {
                new Shape(new Rectangle(rec.X+10, rec.Y+10, 30, 30), 1, 3),
                new Shape(new Rectangle(rec.X+50, rec.Y+10, 30, 30), 2, 5),
                new Shape(new Rectangle(rec.X+20, rec.Y+30, 30, 20), 3, 2, ShapeType.Oval),
                new Shape(new Rectangle(rec.X+60, rec.Y+30, 30, 50), 5, 1, ShapeType.Oval),
                new Shape(new Rectangle(rec.X+70, rec.Y+10, 30, 30), 3, 3)
            };
        }

        public void moveDraw(Graphics g)
        {
            base.move(container);
            g.FillRectangle(Brushes.Red, rec);

            foreach (var ball in shapes)
            {
                ball.move(rec);
                if(ball.Type == ShapeType.Oval)
                    g.FillEllipse(Brushes.Blue, ball.rec);
                else if (ball.Type == ShapeType.Rectangle)
                    g.FillRectangle(Brushes.Yellow, ball.rec);
            }

        }
    }

}
