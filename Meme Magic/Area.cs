using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
    class Area
    {
        int id;
        bool hasEnemies;
        int enemyAmount;
        bool randomEnemies;
        List<Entity> enemyList;

        public Area(int c_id, bool c_hasEnemies, int c_enemyAmount, bool c_randomEnemies = true)
        {
            id = c_id;
            hasEnemies = c_hasEnemies;
            enemyAmount = c_enemyAmount;
            randomEnemies = c_randomEnemies;

            if (hasEnemies)
            {
                for (int i = 0; i < enemyAmount; i++)
                {
                    if (randomEnemies)
                    {
                        enemyList.Add(new Entity())
                    }
                }
            }
        }
        void LoadArea()
        {

        }
    }
}
