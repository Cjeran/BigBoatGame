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
    public partial class HighScreen : UserControl
    {
        public HighScreen()
        {
            InitializeComponent();
            OnStart();
        }
        private void OnStart()
        {
            
            for (int i = 0; i < 10;i++)
            {
                scoreLabel.Text += "\n"+GameForm.scores[i].name+" - "+ GameForm.scores[i].number;
            }
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "MenuScreen");
        }
    }

}
