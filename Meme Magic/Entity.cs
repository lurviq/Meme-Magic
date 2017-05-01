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
			int c_curArmor, int c_maxArmor, int c_eyeColor = -1, int c_race = -1, int c_age = -1, int c_height = -1, int c_weight = -1)
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
			curINT = c_curINT;
			maxINT = c_maxINT;
			curArmor = c_curArmor;
			maxArmor = c_maxArmor;
			eyeColor = c_eyeColor;
			race = c_race;
			age = c_age;
			height = c_height;
			weight = c_weight;

			//Randomize these if not passed in constructor (value will be -1)
			if (eyeColor==-1)
				eyeColor = rand.Next(1, 4);

			if (age==-1)
				age = rand.Next(18, 60);

			if (race==-1)
				//White, black, indian, sandnigger, asian, hispanic 
				race = rand.Next(1, 6);

			if (height==-1)
				height = rand.Next(150, 195);

			if (weight==-1)
				weight = rand.Next(50, 200);
		}
	}
}
