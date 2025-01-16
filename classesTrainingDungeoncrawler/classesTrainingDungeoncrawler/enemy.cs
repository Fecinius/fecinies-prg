using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classesTrainingDungeoncrawler
{
    internal class Enemy
    {
        int healthBase;
        int health;
        int dmgBase;
        int dmg;
        int lvl;
        Random rng;
        

        public Enemy(int healthBase, int dmgBase , int lvl)
        {
            this.healthBase = healthBase;
            health = this.healthBase * lvl;
            this.dmgBase = dmgBase;
            dmg = this.dmgBase * lvl;

            this.lvl = lvl;
            rng = new Random();
        }
        public int GetHealth()
        {
            return health;
        }
        public int GetDmg()
        {
            return dmg;
        }

        public int GetRndDmg() 
        {
            return rng.Next(dmg / 2, dmg + 1);
            
        }
        public void Hurt(int amount)
        {
            health -= amount;
            Console.WriteLine("enemy was hit for " + amount + "dmg");
            if(health <= 0)
            {
                Console.WriteLine("enemy is dead");
            }
            
        }
        public bool IsDead()
        {
            return health <= 0;
        }


    }
}
