using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class SoberCrusader : Enemy
    {
        private int baseHealthValue;
        private int maxHealthValue;
        private int currentHealthValue;
        private int lvl = 0;
        private int baseDamage;
        public SoberCrusader(int lvl) : base(15, 2, lvl)
        {

        }

    }
}
