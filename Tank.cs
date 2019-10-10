using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    public abstract class Tank
    {
        public string TankName { get; set; }
        public int Ammunition { get; set; }
        public int ArmorLevel { get; set; }
        public int MobilityLevel { get; set; }
        public int Experience { get; set; }
        public int Camouflage { get; set; }
        public static Random rnd = new Random();
        public Tank()
        {
            Ammunition = rnd.Next(5, 10);
            ArmorLevel = rnd.Next(80, 110);
            Experience = rnd.Next(1, 10);
        }
        public static bool operator *(Tank tank1, Tank tank2)
        {
            int countTank1 = 0, countTank2 = 0;
            if (tank1.MobilityLevel > tank2.MobilityLevel)
                countTank1++;
            else if (tank1.MobilityLevel < tank2.MobilityLevel)
                countTank2++;

            if (tank1.Experience > tank2.Experience)
                countTank1++;
            else if (tank1.Experience < tank2.Experience)
                countTank2++;

            if (tank1.Camouflage > tank2.Camouflage)
                countTank1++;
            else if (tank1.Camouflage < tank2.Camouflage)
                countTank2++;

            if (countTank1 == countTank2)
            {
                Console.WriteLine("Standoff");
                return false;
            }
            else if (countTank1 > countTank2)
            {
                Console.WriteLine($"{tank1.TankName} is WIN");
                tank1.change(tank2);
            }
            else if (countTank1 < countTank2)
            {
                Console.WriteLine($"{tank2.TankName} is WIN");
                tank2.change(tank1);
            }
            return true;
        }
        private Tank change(Tank tank)
        {
            tank.ArmorLevel -= Ammunition;
            ArmorLevel -= tank.Ammunition / 2;
            tank.Experience++;
            Experience++;
            tank.Camouflage++;
            return this;
        }
        public override string ToString()
        {
            return (TankName + ":\n Boekomplect - " + Ammunition + "\n Yroven_Broni - " + ArmorLevel
                + "\n Yroven_Manevrenosti - " + MobilityLevel + "\n Opit_Ecipasha - " + Experience
                + "\n Maskirovca - " + Camouflage);
        }
    }
}
