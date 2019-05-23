using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBoatGame
{
    class Plane
    {
        Direction direction;
        public int hp, x, y, speed, gunNumber, ammo1, ammo2, primaryCounter, secondaryCounter;
        public bool cannon;
        public enum Direction
        {
            up = 0,
            upRight = 1,
            right = 2,
            downRight = 3,
            down = 4,
            downLeft = 5,
            left = 6,
            upLeft = 7
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
        }

        public void Move()
        {
            switch (direction)
            {
                case Direction.up:
                    y = y - speed;
                    break;
                case Direction.upRight:
                    y = y - speed / 2;
                    x = x + speed / 2;
                    break;
                case Direction.right:
                    x = x + speed;
                    break;
                case Direction.downRight:
                    y = y + speed / 2;
                    x = x + speed / 2;
                    break;
                case Direction.down:
                    y = y + speed;
                    break;
                case Direction.downLeft:
                    y = y + speed / 2;
                    x = x - speed / 2;
                    break;
                case Direction.left:
                    x = x - speed;
                    break;
                case Direction.upLeft:
                    y = y - speed / 2;
                    x = x - speed / 2;
                    break;
            }
        }

        public void Shoot(int shootDirection, bool primary)
        {

        }
    }

   
}
