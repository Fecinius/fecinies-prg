using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTrainingDungeoncrawler
{
    internal class Player
    {
       
        int health;
        public int dmg;
        public string name;
        Random rng;

        public Player(int health, int dmg, string name)
        {
           SetHealth(health);
            this.dmg = dmg;
            this.name = name;
            rng = new Random();
        }

        public void  SetHealth(int value)
        {  health = value; 
            if (health < 0)
            {
                health = 0;
            }
        }

        public int GetHealth ()
        { 
            return health;
        }

        public int GetDmg()
        { return dmg;}

        public int GetRndDmg()
        {
            float randomizedDMG = rng.Next(dmg/3, dmg*3) + 1 / 10f;
            return (int)randomizedDMG;

        }
        public void Hurt(int amount)
        {
            health -= amount;
            Console.WriteLine("player was hit for " + amount + "dmg");
            if (health <= 0)
            {
                Console.WriteLine("player is dead");
            }  
        }

        public bool IsDead()
        {
            return health <= 0;
        }
    }
}
