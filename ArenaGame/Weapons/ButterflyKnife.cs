using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class ButterflyKnife : IWeapon
    {
        protected Random random = new Random();
       
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public ButterflyKnife(string name)
        {
            Name = name;
            AttackDamage = random.Next(1, 20);
            BlockingPower = random.Next(1, 5);
        }
    }
}
