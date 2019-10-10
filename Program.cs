using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tank> TT34 = new List<Tank>();
            List<Tank> TPantera = new List<Tank>();
            for (int i = 0; i < 2; i++)
            {
                TT34.Add(new T34());
                TPantera.Add(new Pantera());
            }

            int countBattle = 1;
            int indexT34, indexPantera;
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("ARMY T34:");
                foreach (Tank el in TT34)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine("\nARMY Pantera:");

                foreach (Tank el in TPantera)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine();

                Console.WriteLine("BATTLE " + countBattle++);
                indexT34 = Tank.rnd.Next(1, T34.countT34) - 1;
                indexPantera = Tank.rnd.Next(1, Pantera.countPantera) - 1;
                if (TT34[indexT34] * TPantera[indexPantera])
                {
                    if (checkOnDead(TT34[indexT34]))
                    {
                        Console.WriteLine($"{TT34[indexT34].TankName} DIED");
                        TT34.RemoveAt(indexT34);
                        T34.countT34--;
                    }
                    else if (checkOnDead(TPantera[indexPantera]))
                    {
                        Console.WriteLine($"{TPantera[indexPantera].TankName} DIED");
                        TPantera.RemoveAt(indexPantera);
                        Pantera.countPantera--;
                    }
                }
                else if (TT34.Count() == 1 && TPantera.Count == 1)
                {
                    Console.WriteLine("STANDOFF OF WAR");
                    break;
                }

                if (TT34.Count() == 0)
                {
                    Console.WriteLine("Pantera ARMY WIN");
                    break;
                }

                if (TPantera.Count() == 0)
                {
                    Console.WriteLine("T34 ARMY WIN");
                    break;
                }
                Console.WriteLine("Tap Enter to next Battle");
                Console.ReadLine();
            }
        }
        public static bool checkOnDead(Tank tank)
        {
            if (tank.ArmorLevel < 0)
                return true;
            else return false;
        }
    }
}

