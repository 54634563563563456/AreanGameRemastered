using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Electrodaragon : Hero
    {
        public Electrodaragon(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {

        }


        public override double Attack()// scaling with aromor
        {
            double totalDamage = Armor + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
        }


    }
}
