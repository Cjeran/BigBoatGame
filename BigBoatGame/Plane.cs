using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBoatGame
{
    class Plane
    {
        Direction direction;
        public int hp, x, y, speed, gunNumber, ammo1, ammo2, primaryCounter, secondaryCounter;
        public bool cannon;
        public Rectangle planeRect;

        public enum Direction
        {
            Up = 0,
            UpRight = 1,
            Right = 2,
            DownRight = 3,
            Down = 4,
            DownLeft = 5,
            Left = 6,
            UpLeft = 7
        }

        public Plane(int _hp, int _x, int _y, int _direction, int _speed, int _gunNumber, bool _cannon, int _ammo1, int _ammo2)
        {
            hp = _hp;
            x = _x;
            y = _y;
            speed = _speed;
            direction = (Direction)_direction;
            gunNumber = _gunNumber;
            cannon = _cannon;
            ammo1 = _ammo1;
            ammo2 = _ammo2;
            planeRect = new Rectangle(x, y, 50, 50);
        }

        public void Move()
        {
            switch (direction)
            {
                case Direction.Up:
                    y = y - speed;
                    break;
                case Direction.UpRight:
                    y = y - speed / 2;
                    x = x + speed / 2;
                    break;
                case Direction.Right:
                    x = x + speed;
                    break;
                case Direction.DownRight:
                    y = y + speed / 2;
                    x = x + speed / 2;
                    break;
                case Direction.Down:
                    y = y + speed;
                    break;
                case Direction.DownLeft:
                    y = y + speed / 2;
                    x = x - speed / 2;
                    break;
                case Direction.Left:
                    x = x - speed;
                    break;
                case Direction.UpLeft:
                    y = y - speed / 2;
                    x = x - speed / 2;
                    break;
            }
        }

        public void Shoot(int shootDirection, bool primary)
        {

        }

        public Image playerImage()
        {
                if (GameForm.yank)
                {
                    switch (direction)
                    {
                        case Direction.Up:
                            return Properties.Resources.F4F_4_Up;
                        case Direction.UpRight:
                            return Properties.Resources.F4F_4_UpRight;
                        case Direction.Right:
                            return Properties.Resources.F4F_4_Right;
                        case Direction.DownRight:
                            return Properties.Resources.F4F_4_DownRight;
                        case Direction.Down:
                            return Properties.Resources.F4F_4_Down;
                        case Direction.DownLeft:
                            return Properties.Resources.F4F_4_DownLeft;
                        case Direction.Left:
                            return Properties.Resources.F4F_4_Left;
                        case Direction.UpLeft:
                            return Properties.Resources.F4F_4_UpLeft;
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case Direction.Up:
                            return Properties.Resources.F4F_4_Up;
                        case Direction.UpRight:
                            return Properties.Resources.F4F_4_UpRight;
                        case Direction.Right:
                            return Properties.Resources.F4F_4_Right;
                        case Direction.DownRight:
                            return Properties.Resources.F4F_4_DownRight;
                        case Direction.Down:
                            return Properties.Resources.F4F_4_Down;
                        case Direction.DownLeft:
                            return Properties.Resources.F4F_4_DownLeft;
                        case Direction.Left:
                            return Properties.Resources.F4F_4_Left;
                        case Direction.UpLeft:
                            return Properties.Resources.F4F_4_UpLeft;
                    }

                }
            return Properties.Resources.F4F_4_Up;
        }


    }

}