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
        int waves;
        public static int carrierHP;

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
            } 
            else
            {
                Plane player = new Plane(5, 50, 50, 0, 0, 2, true, 50, 50);
            }
                   



        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
