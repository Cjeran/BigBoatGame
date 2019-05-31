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
        public int hp, x, y, speed, ammo1, ammo2, shotClock, fireRate;
        int gunNumber, primaryCounter, secondaryCounter, maxSpeed, turnTimer, speedMult;
        public bool cannon, gunSide;
        public Rectangle planeRect;
        public Point leftGun, rightGun;
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
            shotClock = 0;
            fireRate = 5;

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

        public void AutoTurn(Plane p)
        {
            if (turnTimer > 10)
            {
                Direction changer = direction;

                if (p.planeRect.X > planeRect.X && p.planeRect.Y + 25 > planeRect.Y && p.planeRect.Y - 25 < planeRect.Y)
                {
                    direction = Direction.Right;
                }
                else if (p.planeRect.X < planeRect.X && p.planeRect.Y + 25 > planeRect.Y && p.planeRect.Y - 25 < planeRect.Y)
                {
                    direction = Direction.Left;
                }
                else if (p.planeRect.Y > planeRect.Y && p.planeRect.X + 25 > planeRect.X && p.planeRect.X - 25 < planeRect.X)
                {
                    direction = Direction.Down;
                }
                else if (p.planeRect.Y < planeRect.Y && p.planeRect.X + 25 > planeRect.X && p.planeRect.X - 25 < planeRect.X)
                {
                    direction = Direction.Up;
                }
                else if (p.planeRect.X > planeRect.X && p.planeRect.Y > planeRect.Y)
                {
                    direction = Direction.DownRight;
                }
                else if (p.planeRect.X > planeRect.X && p.planeRect.Y < planeRect.Y)
                {
                    direction = Direction.UpRight;
                }
                else if (p.planeRect.X < planeRect.X && p.planeRect.Y > planeRect.Y)
                {
                    direction = Direction.DownLeft;
                }
                else if (p.planeRect.X < planeRect.X && p.planeRect.Y < planeRect.Y)
                {
                    direction = Direction.UpLeft;
                }

                if (changer != direction)
                {
                    turnTimer = 0;
                }
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
        public Boolean Colision(Plane p)
        {
            return (planeRect.IntersectsWith(p.planeRect));
        }

        public Bullet Shoot(int shootDirection, bool primary, bool side)
        {
            if (side)
            {
                shotClock = 0;
                Bullet b = new Bullet(rightGun.X - 2, rightGun.Y - 2, true, shootDirection);
                return b;
            }
            else if (!side) {
                shotClock = 0;
                Bullet b = new Bullet(leftGun.X - 2, leftGun.Y - 2, true, shootDirection);
                return b;
            }
            Bullet bullet = new Bullet(planeRect.X + 23, rightGun.Y + 23, true, shootDirection);
            return bullet;
        }

        public void GunPosition()
        {
            switch (direction)
            {
                case Direction.Up:
                    leftGun = new Point(planeRect.X + 8, planeRect.Y + 12);
                    rightGun = new Point(planeRect.X + 42, planeRect.Y + 12);
                    break;
                case Direction.UpRight:
                    leftGun = new Point(planeRect.X + 20, planeRect.Y + 7);
                    rightGun = new Point(planeRect.X + 43, planeRect.Y + 30);
                    break;
                case Direction.Right:
                    leftGun = new Point(planeRect.X + 38 , planeRect.Y + 8);
                    rightGun = new Point(planeRect.X + 38, planeRect.Y + 42);
                    break;
                case Direction.DownRight:
                    leftGun = new Point(planeRect.X + 43, planeRect.Y + 20);
                    rightGun = new Point(planeRect.X + 20, planeRect.Y + 43);
                    break;
                case Direction.Down:
                    leftGun = new Point(planeRect.X + 8, planeRect.Y + 38);
                    rightGun = new Point(planeRect.X + 42, planeRect.Y + 38);
                    break;
                case Direction.DownLeft:
                    leftGun = new Point(planeRect.X + 7, planeRect.Y + 20);
                    rightGun = new Point(planeRect.X + 30, planeRect.Y + 43);
                    break;
                case Direction.Left:
                    leftGun = new Point(planeRect.X + 8, planeRect.Y + 12);
                    rightGun = new Point(planeRect.X + 8, planeRect.Y + 38);
                    break;
                case Direction.UpLeft:
                    leftGun = new Point(planeRect.X + 7, planeRect.Y + 30);
                    rightGun = new Point(planeRect.X + 30, planeRect.Y + 7);
                    break;
            }
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
            shotClock++;
        }
    }
}
