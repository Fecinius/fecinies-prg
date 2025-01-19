using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class JudgmentalNeighbor : Enemy
    {
        private int baseHealthValue;
        private int maxHealthValue;
        private int currentHealthValue;
        private int lvl = 0;
        private int baseDamage;
        public JudgmentalNeighbor(int lvl) : base(15, 2, lvl)
        {

        }
        public void PassiveCriticism(Drinker player)
        {
            Console.WriteLine("Judgmental Neighbor: 'Shouldn’t you be doing something more productive?'");
            player.TakeDamage(baseDamage); // Minor but constant damage.
        }



    }
}

    

