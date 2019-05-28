using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BigBoatGame
{
    public class Plane
    {
        public Direction direction;
        public int hp, x, y, speed, ammo1, ammo2;
        int gunNumber, primaryCounter, secondaryCounter, maxSpeed, turnTimer, speedMult;
        public bool cannon;
        public Rectangle planeRect;
        string name;


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

        public Plane(int _hp, int _x, int _y, int _direction, string _name)
        {
            hp = _hp;
            x = _x;
            y = _y;
            speed = 0;
            direction = (Direction)_direction;
            maxSpeed = 6;
           

            ammo1 = 40;
            ammo2 = 20;
            planeRect = new Rectangle(x, y, 50, 50);
            name = _name;
            turnTimer = 0;
            switch (name)
            {
                case "F4F_4":
                    cannon = false;
                    ammo1 = 40;
                    ammo2 = 40;
                    gunNumber = 3;
                    break;
                case "A6M2":
                    cannon = true;
                    ammo1 = 40;
                    ammo2 = 20;
                    gunNumber = 2;
                    break;
                case "Dauntless":
                    cannon = false;
                    ammo1 = 40;
                    ammo2 = 0;
                    gunNumber = 1;
                    break;
                case "B7A2":
                    cannon = false;
                    ammo1 = 40;
                    ammo2 = 0;
                    gunNumber = 1;
                    break;
            }

        }

        public void Move()
        {
            if (speed < maxSpeed)
            {
                speed++;
            }
            switch (direction)
            {
                case Direction.Up:
                    planeRect.Y -= speed;
                    break;
                case Direction.UpRight:
                    planeRect.Y -= speed * 2/3;
                    planeRect.X += speed * 2/3;
                    break;
                case Direction.Right:
                    planeRect.X += speed;
                    break;
                case Direction.DownRight:
                    planeRect.Y += speed * 2/3;
                    planeRect.X += speed * 2/3;
                    break;
                case Direction.Down:
                    planeRect.Y += speed;
                    break;
                case Direction.DownLeft:
                    planeRect.Y += speed * 2/3;
                    planeRect.X -= speed * 2/3;
                    break;
                case Direction.Left:
                    planeRect.X -= speed;
                    break;
                case Direction.UpLeft:
                    planeRect.Y -= speed * 2/3;
                    planeRect.X -= speed * 2/3;
                    break;
            }


        }

        public void Turn(Boolean right)
        {
            if (turnTimer > 10 && right)
            {
                speed--;
                switch (direction)
                {
                    case Direction.Up:
                        direction = Direction.UpRight;
                        turnTimer = 0;
                        break;
                    case Direction.UpRight:
                        direction = Direction.Right;
                        turnTimer = 0;
                        break;
                    case Direction.Right:
                        direction = Direction.DownRight;
                        turnTimer = 0;
                        break;
                    case Direction.DownRight:
                        direction = Direction.Down;
                        turnTimer = 0;
                        break;
                    case Direction.Down:
                        direction = Direction.DownLeft;
                        turnTimer = 0;
                        break;
                    case Direction.DownLeft:
                        direction = Direction.Left;
                        turnTimer = 0;
                        break;
                    case Direction.Left:
                        direction = Direction.UpLeft;
                        turnTimer = 0;
                        break;
                    case Direction.UpLeft:
                        direction = Direction.Up;
                        turnTimer = 0;
                        break;
                }
            }
            else if (turnTimer > 10 & !right)
            {
                speed--;
                switch (direction)
                {
                    case Direction.Up:
                        direction = Direction.UpLeft;
                        turnTimer = 0;
                        break;
                    case Direction.UpRight:
                        direction = Direction.Up;
                        turnTimer = 0;
                        break;
                    case Direction.Right:
                        direction = Direction.UpRight;
                        turnTimer = 0;
                        break;
                    case Direction.DownRight:
                        direction = Direction.Right;
                        turnTimer = 0;
                        break;
                    case Direction.Down:
                        direction = Direction.DownRight;
                        turnTimer = 0;
                        break;
                    case Direction.DownLeft:
                        direction = Direction.Down;
                        turnTimer = 0;
                        break;
                    case Direction.Left:
                        direction = Direction.DownLeft;
                        turnTimer = 0;
                        break;
                    case Direction.UpLeft:
                        direction = Direction.Left;
                        turnTimer = 0;
                        break;
                }
            }
        }

        public Bullet Shoot(int shootDirection, bool primary)
        {
            Bullet b = new Bullet(planeRect.X, planeRect.Y, true,shootDirection);
            return b;
        }


        public Image playerImage()             // i hate this but it works
        {
            switch (name)
            {
                case "F4F_4":
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
                    return Properties.Resources.F4F_4_Up;

                case "A6M2":
                    switch (direction)                // TODO chage images
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
                    return Properties.Resources.F4F_4_Up;

                case "Dauntless":
                    switch (direction)
                    {
                        case Direction.Up:
                            return Properties.Resources.Dauntless_Up;
                        case Direction.UpRight:
                            return Properties.Resources.Dauntless_UpRight;
                        case Direction.Right:
                            return Properties.Resources.Dauntless_Right;
                        case Direction.DownRight:
                            return Properties.Resources.Dauntless_DownRight;
                        case Direction.Down:
                            return Properties.Resources.Dauntless_Down;
                        case Direction.DownLeft:
                            return Properties.Resources.Dauntless_DownLeft;
                        case Direction.Left:
                            return Properties.Resources.Dauntless_Left;
                        case Direction.UpLeft:
                            return Properties.Resources.Dauntless_UpLeft;
                    }
                    return Properties.Resources.Dauntless_Up;

                case "B7A2":
                    switch (direction)                        // TODO change image directory when images are done
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
                    return Properties.Resources.F4F_4_Up;


            }
            return Properties.Resources.F4F_4_Up;
        }


        public void Update()
        {
            turnTimer++;
        }
    }
}
