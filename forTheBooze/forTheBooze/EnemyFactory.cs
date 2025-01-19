using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal static class EnemyFactory
    {
        private static Random rng = new Random();
        public static List<Enemy> GetRandomEnemies(int playerLevel, int maxEnemies)
        {
            List<Func<int, Enemy>> enemyConstructors = new List<Func<int, Enemy>>
            {
                level => new JudgmentalNeighbor(level),
                level => new HomelessDrunk(level),
                level => new SoberCrusader(level),
            };

            HashSet<int> usedIndexes = new HashSet<int>();
            List<Enemy> enemies = new List<Enemy>();

            for (int i = 0; i < maxEnemies; i++)
            {
                int index;
                do
                {
                    index = rng.Next(enemyConstructors.Count);
                } while (usedIndexes.Contains(index));

                usedIndexes.Add(index);
                int enemyLevel = rng.Next(1, Math.Max(2, playerLevel + 2)); // Higher chance for higher levels as playerLevel increases
                enemies.Add(enemyConstructors[index](enemyLevel));

                // Assign unique name to the enemy
                enemies[enemies.Count - 1].name = $"{enemies[enemies.Count - 1].GetType().Name} #{i + 1}";
            }

            return enemies;
        }
    }
}
