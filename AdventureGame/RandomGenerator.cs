using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class RandomGenerator
    {
        public int d20Value {  get; set; }
        public int encounter { get; set; }
        public int encounterNum;
        private static Random rand = new Random();

        public void RollD20() 
        {
            this.d20Value = rand.Next(1, 21);
        }

        public void Encounter() 
        {
            
        }
    }
}
