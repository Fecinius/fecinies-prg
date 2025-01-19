using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class HomelessDrunk : Enemy
    {
        public HomelessDrunk(int lvl) : base(10, 8, lvl) { }

        public void StealItem(Drinker player)
        {
            Console.WriteLine("Homeless Drunk tries to steal something from your inventory!");
        }
    }
}
