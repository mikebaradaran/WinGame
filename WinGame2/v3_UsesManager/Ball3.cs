using System.Drawing;

namespace WinGameV3
{
    // uses Rectangle and better algorithm
    public class Ball
    {
        public Rectangle rec;
        private int dirX, dirY;
        public Ball(Rectangle rec, int dirX, int dirY)
        {
            this.rec = rec;
            this.dirX = dirX;
            this.dirY = dirY;
        }

        public void move(Rectangle world)
        {
            rec.Offset(dirX, dirY);
            if (rec.X < world.X || rec.Right > world.Right)
            {
                dirX = -dirX;
                rec.Offset(dirX, 0);
            }
            if (rec.Y < world.Y || rec.Bottom > world.Bottom)
            {
                dirY = -dirY;
                rec.Offset(0, dirY);
            }
        }
    }
}
