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
    public partial class EndScreen : UserControl
    {
        Score s;
        public EndScreen()
        {
            InitializeComponent();
            OnStart();
        }
    
        private void OnStart()
        {
            Score s = new Score();
            s.number = GameForm.score;

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            GameForm.scores.Add(s);
            GameForm.ChangeScreen(this, "HighScreen");
        }
    }
}
