using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBoatGame.Screens
{
    public partial class GameScreen : UserControl
    {
        Random randGen = new Random();
        SolidBrush hudBrush = new SolidBrush(Color.Moccasin);
        SolidBrush reloadBrush = new SolidBrush(Color.IndianRed);
        Brush textBrush = new SolidBrush(Color.Black);
        Font textFont = new Font("Mongolian Baiti", 12);

        List<Plane> players = new List<Plane>();
        List<Plane> enemies = new List<Plane>();
        List<Carrier> carriers = new List<Carrier>();
        List<Bullet> bullets = new List<Bullet>();
        List<Bullet> enemyBullets = new List<Bullet>();

        int waves;

        int gameTime;
        public Carrier carrier;
        public Plane player;
        public Plane enemy;
        Boolean upKeyDown, rightKeyDown, leftKeyDown, downKeyDown, wKeyDown, dKeyDown, aKeyDown, sKeyDown, mKeyDown, spaceKeyDown, zKeyDown, xKeyDown;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            DoubleBuffered = true;
        }

        public void OnStart()
        {
            gameTime = 0;
            waves = 0;

            gameTimer.Start();
            if (GameForm.vs)
            {
                players.Add(player = new Plane(8, 250, 550, 0, "F4F_4"));
                enemies.Add(player = new Plane(5, 250, 250, 0, "A6M2"));
            }
            else
            {
                if (GameForm.yank == true)
                {
                    players.Add(player = new Plane(8, 250, 550, 0, "F4F_4"));
                }
                else
                {
                    players.Add(player = new Plane(5, 250, 250, 0, "A6M2"));
                }
                carriers.Add(carrier = new Carrier(this.Width / 2 - 40, this.Height / 2 - 225));
            }



        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Down:
                    downKeyDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
                case Keys.M:
                    mKeyDown = true;
                    break;
                case Keys.Z:
                    zKeyDown = true;
                    break;
                case Keys.X:
                    xKeyDown = true;
                    break;
            }
        }


        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upKeyDown = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    break;
                case Keys.Left:
                    leftKeyDown = false;
                    break;
                case Keys.Down:
                    downKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
                case Keys.M:
                    mKeyDown = false;
                    break;
                case Keys.Z:
                    zKeyDown = false;
                    break;
                case Keys.X:
                    xKeyDown = false;
                    break;
            }
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTime++;

            foreach (Bullet b in bullets)
            {
                bool delete = false;
                b.Move();
                foreach (Plane en in enemies)
                {
                    if (en.Colision(b))
                    {
                        if (b.cannon) { en.hp -= 2; }/// bullet and enemie plane collision
                        else { en.hp -= 1; }
                        if (en.hp <= 0)
                        {
                            if (GameForm.vs)
                            {
                                GameOver("", "MenuScreen");
                            }
                            else
                            {
                                enemies.Remove(en);
                            }
                        }
                        delete = true;
                        bullets.Remove(b);
                        break;
                    }
                }
                if (delete) { break; }
            }

            foreach (Bullet b in enemyBullets)
            {
                bool end = false;
                b.Move();
                foreach (Plane p in players)
                {
                    if (p.Colision(b))
                    {
                        if (b.cannon) { p.hp -= 2; }/// bullet and enemie plane collision
                        else { p.hp -= 1; }
                        if (p.hp <= 0)
                        {
                            if (GameForm.vs)
                            {
                                end = true;
                                GameOver("you lose carrier ded", "MenuScreen");
                                break;
                            }
                            else
                            {
                                enemies.Remove(p);
                            }

                        }
                        end = true;
                        bullets.Remove(b);
                    }
                }
                if (end) { break; }
            }

            foreach (Plane p in players) ///player 1
            {
                p.OnScreen(gameTime);
                p.Update();
                p.GunPosition();
                p.Move();
                if (spaceKeyDown && p.shotClock > p.fireRate && p.ammo1 > 0)
                {
                    p.ammo1--;
                    if (p.gunSide)
                    {
                        bullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, true));
                    }
                    else if (!p.gunSide)
                    {
                        bullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, false));
                    }
                    p.gunSide = !p.gunSide;
                }
                else if (p.ammo1 <= 0)
                {
                    p.PrimaryReload();
                }
                //Secondary Shooting
                if (mKeyDown && p.shotClock > p.fireRate && p.ammo2 > 0)
                {
                    p.ammo2--;
                    if (GameForm.yank)
                    {
                        if (p.gunSide)
                        {
                            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, true));
                        }
                        else if (!p.gunSide)
                        {
                            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, false));
                        }
                        p.gunSide = !p.gunSide;
                    }
                    else
                    {
                        if (p.gunSide)
                        {
                            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, true));
                        }
                        else if (!p.gunSide)
                        {
                            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, false));
                        }
                        p.gunSide = !p.gunSide;
                    }

                }
                else if (p.ammo2 <= 0)
                {
                    p.SecondaryReload();
                }
            }


            if (GameForm.vs) // vs mode checks/////////////////////////////////////////////////////////////////////////////////
            {

                if (dKeyDown)
                {
                    enemies[0].Turn(true);
                }
                else if (aKeyDown)
                {
                    enemies[0].Turn(false);
                }
                if (rightKeyDown)
                {
                    players[0].Turn(true);
                }
                else if (leftKeyDown)
                {
                    players[0].Turn(false);
                }
              

                foreach (Plane p in enemies) ///player 2
                {
                    p.OnScreen(gameTime);
                    p.Update();
                    p.GunPosition();
                    p.Move();
                    if (zKeyDown && p.shotClock > p.fireRate && p.ammo1 > 0)
                    {
                        p.ammo1--;
                        if (p.gunSide)
                        {
                            enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, true)); // alternates sides of shoot
                        }
                        else if (!p.gunSide)
                        {
                            enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, false));
                        }
                        p.gunSide = !p.gunSide;
                    }
                    else if (p.ammo1 <= 0)
                    {
                        p.PrimaryReload();
                    }
                    //Secondary Shooting
                    if (xKeyDown && p.shotClock > p.fireRate && p.ammo2 > 0)
                    {
                        p.ammo2--;
                        if (GameForm.yank)
                        {
                            if (p.gunSide)
                            {
                                enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, true));
                            }
                            else if (!p.gunSide)
                            {
                                enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), false, false)); //add boollts
                            }
                            p.gunSide = !p.gunSide;
                        }
                        else
                        {
                            if (p.gunSide)
                            {
                                enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, true));
                            }
                            else if (!p.gunSide)
                            {
                                enemyBullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, false));
                            }
                            p.gunSide = !p.gunSide;
                        }

                    }
                    else if (p.ammo2 <= 0)
                    {
                        p.SecondaryReload(); // reloads when out of ammo
                    }

                }


            }
            else////////////////////////////////////////////////////////////////////
            {


                foreach (Plane en in enemies) //Enemy Shooting
                {
                    enemyBullets.Add(en.BackShoot(Convert.ToInt16(en.direction) - 5));
                }

                if (enemies.Count == 0) //New Wave
                {
                    waves++;
                    if (waves == 6)
                    {
                        GameOver("Congratulations! You've fought off all the enemies!", "EndScreen");
                    }
                    if (GameForm.yank)
                    {
                        EnemySpawn("B7A2");
                    }
                    else
                    {
                        EnemySpawn("Dauntless");
                    }

                }

                if (rightKeyDown)
                {
                    players[0].Turn(true);
                }
                else if (leftKeyDown)
                {
                    players[0].Turn(false);
                }

                foreach (Plane p in enemies)
                {
                    p.Update();
                    if (p.bombed == false)
                    {
                        p.CarrierAutoTurn(carriers[0]);
                    }
                    else
                    {
                        p.PlayerAutoTurn(players[0]);
                    }
                    p.Move();
                }

                //foreach (Plane p in players)
                //{
                //    p.OnScreen(gameTime);
                //    p.Update();
                //    p.GunPosition();
                //    p.Move();
                //    if (spaceKeyDown && p.shotClock > p.fireRate && p.ammo1 > 0)
                //    {
                //        p.ammo1--;
                //        if (p.gunSide)
                //        {
                //            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, true));
                //        }
                //        else if (!p.gunSide)
                //        {
                //            bullets.Add(p.Shoot(Convert.ToInt16(p.direction), true, false));
                //        }
                //        p.gunSide = !p.gunSide;
                //    }
                //    else if (p.ammo1 <= 0)
                //    {
                //        p.PrimaryReload();
                //    }
                //    foreach (Plane en in enemies)
                //    {
                //        p.Colision(en);

                //    }
                //}
                foreach (Plane en in enemies)
                {
                    if (en.Colision(carrier) && en.bombed == false)
                    {
                        en.bombed = true;
                        en.maxSpeed = 8;
                        carrier.hp -= 5;
                    }
                    if (carrier.hp <= 0)
                    {
                        carrier.hp = 0;
                        GameOver("The carrier has been destroyed. This is a shameful display!", "EndScreen");
                        break;
                    }

                }
               
            }
            Refresh();
        }

        public void EnemySpawn(string type)
        {
            for (int i = 0; i <= waves * 2; i++)
            {
                int side = randGen.Next(1, 3);
                int position = randGen.Next(1, 4);
                if (side == 1)
                {
                    side = -100;
                }
                else
                {
                    side = this.Width + 100;
                }
                if (position == 1)
                {
                    position = this.Height / 4;
                }
                if (position == 1)
                {
                    position = this.Height / 4;
                }
                else if (position == 2)
                {
                    position = this.Height / 2;
                }
                else
                {
                    position = this.Height * (3 / 4);
                }
                enemies.Add(enemy = new Plane(2, side, position, 0, type));
            }

        }

        public void GameOver(string msg,string screen)
        {
            gameTimer.Enabled = false;
            if (!GameForm.vs)
            {
                GameForm.score = carrier.hp + "";
            }
            GameForm.msg = msg;
            GameForm.ChangeScreen(this, screen);
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Carrier c in carriers)
            {
                if (GameForm.yank)
                {
                    e.Graphics.DrawImage(Properties.Resources.Dauntless_Down, c.rect);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.Shokaku, c.rect);
                }
            }
            foreach (Plane p in players)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), p.rect);
                e.Graphics.DrawImage(p.playerImage(), p.rect);
            }
            foreach (Plane p in enemies)
            {
                e.Graphics.DrawImage(p.playerImage(), p.rect);
            }
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(hudBrush, b.rect);
            }
            foreach (Bullet b in enemyBullets)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Orange), b.rect);
            }

            //HUD
            e.Graphics.FillRectangle(hudBrush, this.Width - 200, 0, 200, this.Height);
            e.Graphics.DrawString("Score: " + GameForm.score, textFont, textBrush, this.Width - 150, 50);
            if (!GameForm.vs)
            {
                e.Graphics.DrawString("Carrier HP: " + carrier.hp, textFont, textBrush, this.Width - 150, 75);
                e.Graphics.DrawString("HP: " + player.hp, textFont, textBrush, this.Width - 150, 175);
            }
            else
            {
                e.Graphics.DrawString("HP: " + players[0].hp, textFont, textBrush, this.Width - 150, 175);
                e.Graphics.DrawString("HP: " + enemies[0].hp, textFont, textBrush, this.Width - 150, 145);
            }

            if (GameForm.yank)
            {
                e.Graphics.DrawString("Speed: " + player.speed * 15 + "mph", textFont, textBrush, this.Width - 150, 200);
            }
            else
            {
                e.Graphics.DrawString("Speed: " + player.speed * 15 + "km/h", textFont, textBrush, this.Width - 150, 200);
            }
            if (player.reload1)
            {
                e.Graphics.DrawString("Reload: " + player.primaryCounter, textFont, reloadBrush, this.Width - 150, 225);
            }
            else
            {
                e.Graphics.DrawString("Primary: " + player.ammo1, textFont, textBrush, this.Width - 150, 225);
            }
            if (player.reload2)
            {
                e.Graphics.DrawString("Secondary: " + player.secondaryCounter, textFont, reloadBrush, this.Width - 150, 250);
            }
            else
            {
                e.Graphics.DrawString("Secondary: " + player.ammo2, textFont, textBrush, this.Width - 150, 250);
            }

        }
    }
}
