﻿using System.Drawing;
using WinGameV3;

namespace WinGame3
{
    public class BallsManager
    {
        public Rectangle world;

        public Ball[] balls;
        public BallsManager()
        {
            world.X = 20; world.Y = 20; world.Width = 500; world.Height = 400;
            balls = new Ball[] {
                new Ball(new Rectangle(world.X+10, world.Y+10, 30, 30), 1, 3),
                new Ball(new Rectangle(world.X+10, world.Y+10, 30, 30), 2, 5),
                new Ball(new Rectangle(world.X+20, world.Y+30, 30, 20), 3, 2),
                new Ball(new Rectangle(world.X+20, world.Y+30, 30, 50), 5, 1),
                new Ball(new Rectangle(world.X+10, world.Y+10, 30, 30), 3, 3)
            };
        }

        public void moveDraw(Graphics g)
        {
            g.Clear(Color.AntiqueWhite);

            g.FillRectangle(Brushes.Red, world);

            foreach (var ball in balls)
            {
                ball.move(world);
                g.FillEllipse(Brushes.Blue, ball.rec);
            }

        }
    }

}
