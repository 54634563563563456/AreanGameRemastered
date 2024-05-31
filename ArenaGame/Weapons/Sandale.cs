using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sandale : IWeapon
    {
        protected Random random = new Random();
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Sandale(string name)
        {
            Name = name;
            AttackDamage = 20 + random.Next(1, 30); 
            BlockingPower = 1 + random.Next(1, 5);
        }
    }
}
