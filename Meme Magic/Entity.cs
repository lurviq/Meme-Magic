using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
	class Entity
	{
		int[] attributes;

		//Resources
		int curHP, maxHP;
		int curAutism, maxAutism;

		//Stats
		int curSTR, maxSTR;
		int curDEX, maxDEX;
		int curINT, maxINT;

		//Armor
		int curArmor, maxArmor;

		//Item

		//Personal information
		string name;
		string bio;
		int eyeColor;
		int race;
		int age;
		float height;
		float weight;

		//Misc
		Random rand = new Random();

		public Entity(
			string c_Name, string c_Bio,
			int c_curHP, int c_maxHP, int c_curAutism, int c_maxAutism,
			int c_curSTR, int c_maxSTR, int c_curDEX, int c_maxDEX, int c_curINT, int c_maxINT,
			int c_curArmor, int c_maxArmor, int c_eyeColor = 0, int c_race = 0, int c_age = 0, int c_height = 0, int c_weight = 0)
		{
			//Set values
			name = c_Name;
			bio = c_Bio;
			curHP = c_curHP;
			maxHP = c_maxHP;
			curAutism = c_curAutism;
			maxAutism = c_maxAutism;
			curSTR = c_curSTR;
			maxSTR = c_maxSTR;
			curDEX = c_curDEX;
			maxDEX = c_maxDEX;

			attributes[eAttributes.curHP] = c_curHP;





			//Randomize eyeColor if not passed in constructor, else set as passed
			if (c_eyeColor == 0)
				eyeColor = rand.Next(1, 4);
			else
				eyeColor = c_eyeColor;

			//Randomize age if not passed in constructor, else set as passed
			if (c_age == 0)
				age = rand.Next(18, 60);
			else
				age = c_age;

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
