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
    public partial class HowScreen : UserControl
    {
        Boolean leftKeyDown, rightKeyDown, spaceKeyDown, mKeyDown;
        Plane example;
        List<Bullet> bullets = new List<Bullet>();
        public HowScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "MenuScreen");
        }

        private void HowScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Left):
                    leftKeyDown = true;
                    break;
                case (Keys.Right):
                    rightKeyDown = true;
                    break;
                case (Keys.Space):
                    spaceKeyDown = true;
                    break;
                case (Keys.M):
                    mKeyDown = true;
                    break;
            }
        }

        private void HowScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Left):
                    leftKeyDown = false;
                    break;
                case (Keys.Right):
                    rightKeyDown = false;
                    break;
                case (Keys.Space):
                    spaceKeyDown = false;
                    break;
                case (Keys.M):
                    mKeyDown = false;
                    break;
            }
        }

        private void HowScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), b.rect);
            }
            e.Graphics.DrawImage(example.playerImage(), example.rect);
        }

        public void OnStart()
        {
            example = new Plane(1, this.Width / 2 - 25, this.Height / 2 - 25, 0, "F4F_4", 0);
            howToTimer.Enabled = true;
        }

        private void howToTimer_Tick(object sender, EventArgs e)
        {
            example.Update();
            example.GunPosition();

            if (spaceKeyDown && example.shotClock > example.fireRate)
            {
                if (example.gunSide)
                {
                    bullets.Add(example.Shoot(Convert.ToInt16(example.direction), false, true));
                }
                else if (!example.gunSide)
                {
                    bullets.Add(example.Shoot(Convert.ToInt16(example.direction), false, false));
                }
            }

            if (rightKeyDown)
            {
                example.Turn(true);
            }
            else if (leftKeyDown)
            {
                example.Turn(false);
            }
            else { }

            foreach (Bullet b in bullets)
            {
                b.Move();
            }

            Refresh();
        }
    }
}
