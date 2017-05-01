using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
    class Entity
    {
        //Resources
        int currentHp;
        int maxHp;
        int currentAutism;
        int maxAutism;

        //Stats
        int strength;
        int maxStrength;
        int dexterity;
        int maxDexterity;
        int intelligence;
        int maxIntelligence;

        //Armor
        int armor;
        int maxArmor;

        //Item

        //Personal information
        string name;
        string bio;
        int eyecolor;
        int race;
        int age;
        float height;
        float weight;

        //Misc
        Random rand = new Random();

        public Entity(string NAME, int MAXHP, int HP, int MAXAUTISM, int AUTISM, int MAXSTRENGTH, int STRENGTH, int MAXDEXTERITY, int DEXTERITY, int MAXINTELLIGENCE, int INTELLIGENCE, int MAXARMOR, int ARMOR, int EYECOLOR = 0, int RACE = 0, int AGE = 0, int HEIGHT = 0, int WEIGHT = 0)
        {
            //Randomizers
            if (EYECOLOR == 0) //If eyecolor is 0, randomize it between 1 and 4.
            {
                eyecolor = rand.Next(1, 4);
                
            }
            else //If we typed something else, convert it to coder input.
            {
                eyecolor = EYECOLOR;
            }

            if (AGE == 0) //If age is 0, randomize it between 1 and 4.
            {
                age = rand.Next(18, 60);

            }
            else //If we typed something else, convert it to coder input.
            {
                age = AGE;
            }
            if (RACE == 0) //If race is 0, randomize it between 1 and 4.
            {
                race = rand.Next(1, 6); //White, black, indian, sandnigger, asian, hispanic 
            }
            else //If we typed something else, convert it to coder input.
            {
                race = RACE;
            }
            if (HEIGHT == 0) //If height is 0, randomize it between 1 and 4.
            {
                height = rand.Next(150, 195);

            }
            else //If we typed something else, convert it to coder input.
            {
                height = HEIGHT;
            }
            if (WEIGHT == 0) //If weight is 0, randomize it between 1 and 4.
            {
                weight = rand.Next(50, 200);

            }
            else //If we typed something else, convert it to coder input.
            {
                weight = WEIGHT;
            }

        }

        

    }
}
