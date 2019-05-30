using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace BigBoatGame
{
    public class Carrier
    {
        public Rectangle rect; 
        public Carrier(int _x,int _y)
        {
            rect = new Rectangle(_x,_y,80,150);

        }
        public Boolean Colision(Plane p)
        {
            return (rect.IntersectsWith(p.planeRect));
        }
    }
}
