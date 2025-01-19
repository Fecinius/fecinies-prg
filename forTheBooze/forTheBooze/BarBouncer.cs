using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class BarBouncer : Enemy
    {
        private int baseHealthValue;
        private int maxHealthValue;
        private int currentHealthValue;
        private int lvl = 0;
        private int baseDamage;

        public BarBouncer(int lvl) : base(100, 20, lvl)
        {
        }
        public bool KickOut(Drinker player)
        {
            
            if (player.DrunkValueChecker() > 60)//bouncer attacks only if player is more than 60% drunk
            {
                Console.WriteLine("Bar Bouncer: 'You're too drunk, get out!'");
                return true;
            }

            else
            {
                Console.WriteLine("Bar Bouncer: 'You're good to go, have a good night!'");
                return false;
            }
        }
    }
}
