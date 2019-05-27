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
        List<Carrier> carriers = new List<Carrier>();
        List<Bullet> bullets = new List<Bullet>();

        int waves;
        public static int carrierHP;
        public Carrier carrier;
        public Plane player;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            DoubleBuffered = true;
        }

        public void OnStart()
        {
            waves = 0;
            carrierHP = 100;
            gameTimer.Start();

            if (GameForm.yank == true)
            {
                
                players.Add(player = new Plane(8, 250, 250, 0, "F4F_4"));
            } 
            else
            { 
                players.Add(player = new Plane(5, 250, 250, 0, "A6M2"));
            }
            carriers.Add(carrier = new Carrier(400, 400));
            


        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Plane p in players)
            {
                p.Move();
            }
            foreach (Bullet b in bullets)
            {
               // b.Move();
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach(Plane p in players)
            {
                e.Graphics.DrawImage(p.playerImage(),p.planeRect);
            }
            foreach (Carrier c in carriers)
            {
                e.Graphics.DrawImage(Properties.Resources.Dauntless_Down, c.rect);
            }
            //e.Graphics.DrawImage(Properties.Resources.Dauntless_Down );
        }
    }
}
