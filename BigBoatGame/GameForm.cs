using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBoatGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            OnStart();
           
        }
        public void OnStart()
        {
            
            Form f = this.FindForm();
            f.Controls.Remove(this);
            UserControl ns = null;
            ns = new Screens.MenuScreen();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);
            ns.Focus();
            
        }

        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            //switches screen
            switch (next)
            {
                case "MenuScreen":
                    ns = new Screens.MenuScreen();
                    break;
                case "GameScreen":
                  //  ns = new GameScreen();
                    break;
                case "HighScreen":
                   // ns = new HighScreen();
                    break;
                case "NameScreen":
                   // ns = new NameScreen1();
                    break;
            }
            //centres on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);

            f.Controls.Add(ns);
            ns.Focus();
        }



    }
}
