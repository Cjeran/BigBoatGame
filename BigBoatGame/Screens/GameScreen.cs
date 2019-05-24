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
        List<Plane> players = new List<Plane>();
        int waves;
        public static int carrierHP;
        Boolean upKeyDown, rightKeyDown, leftKeyDown, downKeyDown;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
           
        }

        public void OnStart()
        {
            waves = 0;
            carrierHP = 100;
            gameTimer.Start();

            if (GameForm.yank == true)
            {
                Plane player = new Plane(8, 50, 50, 0, 0, 3, false, 50, 50);
                players.Add(player);
            } 
            else
            {
                Plane player = new Plane(5, 50, 50, 0, 0, 2, true, 50, 50);
                players.Add(player);
            }
                   



        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Plane p in players)
            {
                p.Move();
                if (p.speed > 10)
                {
                    p.speed++;
                }
            }

            foreach (Plane p in players)
            {
                if (rightKeyDown)
                {
                    p.Turn(true);
                }
                else if (leftKeyDown)
                {
                    p.Turn(false);
                }
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
            }
        }
    }
}
