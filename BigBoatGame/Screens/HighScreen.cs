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
            foreach (Score s in GameForm.scores)
            highLabel.Text = "hehehehe";
        }
    }

}
