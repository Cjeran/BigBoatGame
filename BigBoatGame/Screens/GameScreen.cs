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
        }
            

            
}
}
