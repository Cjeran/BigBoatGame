using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BigBoatGame
{
    public partial class GameForm : Form
    {

        public static List<Score> scores;
        public static string score;
        XmlReader reader; 
        public static bool yank = true;
        public static bool vs;
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
            ns.Location = new Point((f.Width - ns.Width) / 2, ((f.Height - ns.Height) / 2)-30);
            f.Controls.Add(ns);
            ns.Focus();
            XmlRead();
        }
        public void XmlRead()
        {
            scores = new List<Score>();
            reader = XmlReader.Create("Resources/HighScores.xml");

            reader.ReadToFollowing("HighScores");
            while (reader.Read())
            {
                
                // create a score object
                Score s = new Score();
                // fill score object with required data
               
                reader.ReadToFollowing("player");
                s.name = reader.GetAttribute("name"); 
                s.number = reader.GetAttribute("score");

                //
                if (s != null)
                {
                    scores.Add(s);
                }
            }
            reader.Close();
           // scores.RemoveAt(10); // fix bug 
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
                    ns = new Screens.GameScreen();
                    break;
                case "HighScreen":
                    ns = new Screens.HighScreen();
                    break;
                case "HowScreen":
                    ns = new Screens.HowScreen();
                    break;
                case "NameScreen":
                   // ns = new NameScreen1();
                    break;
                case "EndScreen":
                     ns = new Screens.EndScreen();
                    break;
            }
            //centres on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, ((f.Height - ns.Height) / 2) - 30);

            f.Controls.Add(ns);
            ns.Focus();
        }



    }
}
