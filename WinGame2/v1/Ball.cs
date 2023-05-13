using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGameV1
{
    public class Ball
    {
        public int x, y, w, h, dirX, dirY;
        public static int worldX = 20, worldY = 20, worldW = 200, worldH = 400;
        public Ball(int x, int y, int w, int h, int dirX, int dirY)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.dirX = dirX;
            this.dirY = dirY;
        }
        public Ball(int x, int y, int w, int h):this(x,y,w,h,1,1)
        {
        }

        public void move()
        {
            x += dirX; y += dirY;

            if(x < worldX)
            {
                x = worldX; dirX = -dirX;
            }
            if (x+w > worldX + worldW)
            {
                x = worldX+worldW-w; dirX = -dirX;
            }
            if (y < worldY)
            {
                y = worldY; dirY = -dirY;
            }
            if (y + h > worldY + worldH)
            {
                y = worldY + worldH - h; dirY = -dirY;
            }
        }
    }
}
