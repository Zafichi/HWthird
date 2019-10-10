using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    public class T34 : Tank
    {
        public static int countT34 = 1;
        public T34() : base()
        {
            Camouflage = rnd.Next(5, 10);
            MobilityLevel = rnd.Next(1, 100);
            TankName = "T34: " + countT34;
            countT34++;
        }
    }
}
