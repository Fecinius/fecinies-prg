    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTrainingDungeoncrawler
{
    internal class Program
    {
        static void Duel( Player player,Enemy enemy )
        {
            while (!player.IsDead() && !enemy.IsDead())
            {
                enemy.Hurt(player.GetRndDmg());

                if (!enemy.IsDead())
                {
                    player.Hurt(enemy.GetRndDmg());
                }
            }

            Console.WriteLine("enemy health " + enemy.GetHealth() + "HP");
            Console.WriteLine("player health " + player.GetHealth() + "HP");
        }
        static void Main(string[] args)
        {
            Player player = new Player(100,10,"Ignác");
            Enemy enemy = new Enemy(20, 2, 1);

            Duel(player, enemy);

            Enemy enemy2 = new Enemy(20, 2, 2);

            Duel(player, enemy2);

            Console.ReadKey(); 

        }
    }
}
