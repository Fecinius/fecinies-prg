using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class Drinker
    {
        private int baseHealthValue;
        private int maxHealthValue;
        private int currentHealthValue;
        private int exp;
        private int lvl = 0;
        private int drunkValue;
        private int baseDamage;
        private int Damage;
        public int Coins;
        public Inventorylist inventory = new Inventorylist();

        public Drinker(int baseHealthValue, int currentHealthValue, int baseDamage,int Coins)
        {
            this.baseHealthValue = baseHealthValue + lvl * 15;
            maxHealthValue = baseHealthValue;
            this.currentHealthValue = currentHealthValue;
            this.baseDamage = baseDamage;
            Damage = baseDamage * (lvl / 2);
            this.Coins = Coins;

        }
        //stat checkers
        public void StatTyper()
        {
            Console.WriteLine("\n player stats:");
            Console.WriteLine("Max Health: " + maxHealthValue);
            Console.WriteLine("Current Health: " + currentHealthValue);
            Console.WriteLine("Drunk Value: " + drunkValue);
            Console.WriteLine("Level: " + lvl);
            Console.WriteLine("Damage: " + Damage * (lvl / 2));
            Console.WriteLine("Coins: " + Coins);
            Console.ReadKey();

        }
        public int DrunkValueChecker()
        {
            return drunkValue;
        }
        public int HealthChecker()
        {
            return currentHealthValue;
        }
        public int CoinsChecker()
        {
            return Coins;
        }
        public int lvlChecker()
        {
            return lvl;
        }

        //utility functions
        public void Drink(string drinkType)
        {
            switch (drinkType)
            {
                case "Beer":
                    drunkValue += 10;
                    currentHealthValue += 5; // Slight health recovery
                    Console.WriteLine("You drank a beer! Refreshing and easygoing.");
                    break;

                case "Vodka":
                    drunkValue += 30;
                    currentHealthValue += 10;
                    Console.WriteLine("You drank a vodka! You feel a fiery warmth spreading through you.");
                    break;

                case "Whiskey":
                    drunkValue += 25;
                    currentHealthValue += 15;
                    Console.WriteLine("You drank a whiskey! Sophisticated and strong.");
                    break;

                case "Wine":
                    drunkValue += 15;
                    currentHealthValue += 20; // Greater health recovery
                    Console.WriteLine("You drank a wine! It soothes your soul and body.");
                    break;

                case "Rum":
                    drunkValue += 20;
                    currentHealthValue += 10;
                    Console.WriteLine("You drank a rum! You feel ready for a pirate adventure.");
                    break;

                case "Tequila":
                    drunkValue += 40; // High intoxication
                    currentHealthValue -= 5; // Slight health loss due to harshness
                    baseDamage += 5; // Damage boost
                    Console.WriteLine("You drank a tequila! The burn hits you like a freight train.");
                    break;

                case "Cider":
                    drunkValue += 10;
                    currentHealthValue += 10; // Balanced recovery
                    Console.WriteLine("You drank a cider! Sweet and bubbly, it lifts your spirits.");
                    break;

                case "Mead":
                    drunkValue += 15;
                    currentHealthValue += 10;
                    Console.WriteLine("You drank a mead! You feel like a Viking on a feast night.");
                    break;

                case "Sake":
                    drunkValue += 20;
                    currentHealthValue += 10;
                    Console.WriteLine("You drank a sake! A warm, calming sensation fills you.");
                    break;

                case "Absinthe":
                    drunkValue += 50; // Extremely intoxicating
                    currentHealthValue -= 20; // Harsh on the body
                    Console.WriteLine("You drank an absinthe! Hallucinations begin as reality blurs.");
                    break;

                default:
                    Console.WriteLine("Unknown drink type!");
                    break;
            }
        }
        public void LevelUp()
        {
            this.exp += exp;
            if (this.exp / 100 >= 1)
            {
                this.exp = 0;
                lvl++;
                maxHealthValue = baseHealthValue + lvl * 15;
                baseDamage += 2;
            }
        }
        public void refreshment()
        {
            currentHealthValue = maxHealthValue;
            drunkValue -= drunkValue /2;
        }
        
        public void Learning(int expirience)
        {
            exp += expirience ;
        }


        //battle functions
        public void TakeDamage(int damage)
        {
            Console.WriteLine("You took " + damage + " damage!");
            currentHealthValue -= damage;
        }

        public void Attack(Enemy enemy)
        {
            
            
            Damage = baseDamage * (lvl/2); 
            if (enemy.GetType().Name == "SoberCrusader")
            {
                enemy.TakeDamage(baseDamage / 2);
            }
            enemy.TakeDamage(baseDamage);
            Console.WriteLine("You dealt " + baseDamage + " damage to " + enemy.GetType().Name );
        }




    }
}
