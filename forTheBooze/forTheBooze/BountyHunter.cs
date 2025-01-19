using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class BountyHunter : Enemy
    {
        Random rng = new Random();
        public BountyHunter(int lvl) : base(50, 10, lvl) { }
    }
}
