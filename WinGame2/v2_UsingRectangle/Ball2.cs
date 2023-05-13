using System.Drawing;

namespace WinGameV2
{
    // uses Rectangle
    public class Ball
    {
        public Rectangle rec;
        private int dirX, dirY;
        public static Rectangle world;
        public Ball(Rectangle rec, int dirX, int dirY)
        {
            world = new Rectangle(10, 10, 600, 500);
            this.rec = rec;
            this.dirX = dirX;
            this.dirY = dirY;
        }

        public void move()
        {
            rec.Offset(dirX, dirY);

            if(rec.X < world.X)
            {
                rec.X = world.X; dirX = -dirX;
            }
            if (rec.Right > world.Right)
            {
                rec.X = world.Right-rec.Width; dirX = -dirX;
            }
            if (rec.Y < world.Y)
            {
                rec.Y = world.Y; dirY = -dirY;
            }
            if ( rec.Bottom > world.Bottom)
            {
                rec.Y = world.Bottom - rec.Height; dirY = -dirY;
            }
        }
    }
}
