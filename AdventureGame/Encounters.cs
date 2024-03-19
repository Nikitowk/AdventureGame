using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Encounters
    {
        public int enemyhealth = 25;
        public int enemydmg = 5;

        public static string CheckEncounter() 
        {
            List<string> Encounter = new List<string>();
            Encounter.Add("Attacked");
            Encounter.Add("Found a Town");
            Encounter.Add("Found a Cave");
            Encounter.Add("No Encounter");

            Random random = new Random();
            string enc = "";

            if (random.Next(1, 50) >= 46 && random.Next(1, 50) <= 50)
            {
                return enc = Encounter[0];
            }
            else if (random.Next(1, 50) >= 41 && random.Next(1, 50) <= 45)
            {
                return enc = Encounter[1];
            }
            else if (random.Next(1, 50) >= 35 && random.Next(1, 50) <= 40) 
            {
                return enc = Encounter[2];
            }
            else
            {
                return enc = Encounter[3];
            }
        }
        //public static int AttackEncounter() 
        //{
        //    //int attackdmg = 5;
        //    return enemyhealth = 25;
        //}
    }
}
