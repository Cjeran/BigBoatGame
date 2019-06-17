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
    public partial class PauseScreen : UserControl
    {
        public PauseScreen()
        {
            InitializeComponent();
            foreach (var button in Controls.OfType<Button>())
            {
                button.GotFocus += (object sender, EventArgs e) => { (sender as Button).ForeColor = Color.Yellow; };
                button.LostFocus += (object sender, EventArgs e) => { (sender as Button).ForeColor = Color.Black; };
            }
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "MenuScreen");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "");
            
        }
    }
}
