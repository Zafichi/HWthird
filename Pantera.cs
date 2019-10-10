using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    public class Pantera : Tank
    {
        public static int countPantera = 1;
        public Pantera() : base()
        {
            Camouflage = rnd.Next(1, 10);
            MobilityLevel = rnd.Next(20, 100);
            TankName = "Pantera: " + countPantera;
            countPantera++;
        }
    }
}
