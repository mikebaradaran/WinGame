using System.Drawing;

namespace WinGame2.v4_Shape
{
    public class Shape
    {
        public Rectangle rec;
        private int dirX, dirY;
        public Shape(Rectangle rec, int dirX, int dirY)
        {
            this.rec = rec;
            this.dirX = dirX;
            this.dirY = dirY;
        }

        public void move(Rectangle world)
        {
            rec.Offset(dirX, dirY);
            if (rec.X < world.X)
            {
                dirX = -dirX;
                rec.X = world.X;
            }
            if (rec.Bottom > world.Bottom)
            {
                dirY = -dirY;
                rec.Y = world.Bottom-rec.Height;
            }
            if (rec.Right > world.Right)
            {
                dirX = -dirX;
                rec.X = world.Right - rec.Width;
            }
            if (rec.Y < world.Y)
            {
                dirY = -dirY;
                rec.Y = world.Y;
            }
        }
    }
}
