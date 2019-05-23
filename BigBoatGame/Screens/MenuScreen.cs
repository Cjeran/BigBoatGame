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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "GameScreen");
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "HighScreen");
        }

        private void howButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "HowScreen");
        }

        private void flipperButton_Click(object sender, EventArgs e)
        {
            GameForm.yank = !GameForm.yank;
        }
    }
}
