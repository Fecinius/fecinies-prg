using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class Enemy//general enemy template
    {
        private int baseHealthValue;//starting enemy hp
        private int maxHealthValue;//maximum enemy hp based on lvl modifier
        private int currentHealthValue;//current enemy hp
        private int lvl = 0;//enemy level value
        private int baseDamage;//enemy flat damage value without modifiers
        public string name;//enemy name

        public Enemy(int baseHealthValue,  int baseDamage, int lvl)//enemy constructor
        {
            this.lvl = lvl;
            this.baseHealthValue = baseHealthValue + this.lvl * 5;
            maxHealthValue = this.baseHealthValue;
            this.currentHealthValue = this.baseHealthValue;
            this.baseDamage = baseDamage;
        }
        //stat checkers
        public void StatTyper()
        {
            Console.WriteLine("Max Health: " + maxHealthValue);
            Console.WriteLine("Current Health: " + currentHealthValue);
            Console.WriteLine("Level: " + lvl);
        }
        public int HealthChecker()
        {
            return currentHealthValue;
        }

        //batle fucntions
        public void Attack(Drinker player) //Attack method
        {
            player.TakeDamage(baseDamage);
        }

        public void TakeDamage(int damage) //Take damage method
        {
            currentHealthValue -= damage;
        }
    }
}
