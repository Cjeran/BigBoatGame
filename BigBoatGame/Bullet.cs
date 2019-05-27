using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBoatGame
{
    class Bullet
    {
        public int x, y, speed;
        public bool cannon;
        public Rectangle bulletRect;

        public Bullet(int _x, int _y, bool _cannon)// need some way to know if the plane has power up 
        {
            x = _x;
            y = _y;
            speed = 15;  // * by power ups 
            cannon = _cannon;
            bulletRect = new Rectangle(x, y, 50, 50);
        }

        public void Move(int direction)
        {
            switch (direction)
            {
                case 0: //up
                    bulletRect.Y -= speed;
                    break;
                case 1: //upRight
                    bulletRect.Y -= speed/2;
                    bulletRect.X += speed / 2;
                    break;
                case 2: //right
                    bulletRect.X += speed;
                    break;
                case 3: //downRight
                    bulletRect.Y += speed / 2;
                    bulletRect.X += speed / 2;
                    break;
                case 4: //down
                    bulletRect.Y += speed;
                    break;
                case 5: //downLeft
                    bulletRect.Y += speed/2;
                    bulletRect.X -= speed / 2;
                    break;
                case 6: //left
                    bulletRect.X -= speed;
                    break;
                case 7: //upLeft
                    bulletRect.Y -= speed / 2;
                    bulletRect.X -= speed / 2;
                    break;
            }
        }
    }
}
