using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
	class Entity
	{
		string name;
		string bio;

		public List<int> a;

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
		int eyeColor;
		int race;
		int age;

		//Misc
		Random rand = new Random();

		public bool loadFromFile(string fileName)
		{
			//string data = System.IO.File.ReadAllText(@"C:\\Users\\Edgar\\Documents\\GitHub\\Meme-Magic\\Meme Magic\\gameObjects\\Entities\\" + fileName + ".txt");
			string data = System.IO.File.ReadAllText(@"gameObjects\\Entities\\" + fileName + ".txt");

			string value = "";
			int c = 0;

			//Read name
			for (; data[c] != '\n'; c++)
				name += data[c];
			c++;

			//Read bio
			for (; data[c] != '\n'; c++)
				bio += data[c];
			c++;

			//Read curHP
			for (; data[c] != '/'; c++)
				value += data[c];
			//a[eAtt.curHP] = Int32.Parse(value);
			value = "";
			c++;

			//Read maxHP
			for (; data[c] != '\n'; c++)
				bio += data[c];
			c++;
			for (; data[c] != '\n'; c++)
				bio += data[c];
			c++;
			for (; data[c] != '\n'; c++)
				bio += data[c];
			c++;

			return true;
		}

		public string getName()
		{
			return name;
		}

		public string getBio()
		{
			return bio;
		}

		public Entity(string fileName)
		{
			//Read the datafile
			string[] dataLines = System.IO.File.ReadAllLines("gameObjects\\Entities\\" + fileName + ".txt");

			//Set the first two values
			name = dataLines[0];
			bio = dataLines[1];

			a = new List<int>();
			string curATT = "";
			string maxATT = "";
			bool slashTriggered = false;
			for (int c = 0; c < dataLines[2].Length; c++)
			{
				if (dataLines[2][c] == '/')
				{
					slashTriggered = true;
					continue;
				}
				if (!slashTriggered)
					curATT += dataLines[2][c];
				else
					maxATT += dataLines[2][c];
			}

			a.Add(Convert.ToInt32(curATT));
			a.Add(Convert.ToInt32(maxATT));

			curATT = "";
			maxATT = "";
			slashTriggered = false;
			for (int c = 0; c < dataLines[3].Length; c++)
			{
				if (dataLines[3][c] == '/')
				{
					slashTriggered = true;
					continue;
				}
				if (!slashTriggered)
					curATT += dataLines[3][c];
				else
					maxATT += dataLines[3][c];
			}

			a.Add(Convert.ToInt32(curATT));
			a.Add(Convert.ToInt32(maxATT));

			int character = 0;
			for (int stat = 0; stat < 3; stat++)
			{
				curATT = "";
				maxATT = "";
				slashTriggered = false;
				for (; character < dataLines[4].Length; character++)
				{
					if (dataLines[4][character] == '/')
					{
						slashTriggered = true;
						continue;
					}
					if (dataLines[4][character] == ',')
						break;
					if (!slashTriggered)
						curATT += dataLines[4][character];
					else
						maxATT += dataLines[4][character];
				}
				a.Add(Convert.ToInt32(curATT));
				a.Add(Convert.ToInt32(maxATT));
				character++;
			}

			curATT = "";
			maxATT = "";
			slashTriggered = false;
			for (int c = 0; c < dataLines[5].Length; c++)
			{
				if (dataLines[5][c] == '/')
				{
					slashTriggered = true;
					continue;
				}
				if (!slashTriggered)
					curATT += dataLines[5][c];
				else
					maxATT += dataLines[5][c];
			}

			a.Add(Convert.ToInt32(curATT));
			a.Add(Convert.ToInt32(maxATT));

			for (int att = 6; att < 11; att++)
				a.Add(Convert.ToInt32(dataLines[att]));

			//When reading the attributes, VERIFY that they are in the same order as in class eAtt (Enums.cs)
			//for (int attribute = 0; attribute < eAtt.MAX_ATTRIBUTES; attribute++)
			//a.Add(Convert.ToInt32(dataLines[attribute + 2]));
		}

		public Entity(
			string c_name, string c_bio,
			int c_curHP, int c_maxHP, int c_curAutism, int c_maxAutism,
			int c_curSTR, int c_maxSTR, int c_curDEX, int c_maxDEX, int c_curINT, int c_maxINT,
			int c_curArmor, int c_maxArmor,
			int c_eyeColor = -1, int c_race = -1, int c_age = -1, int c_height = -1, int c_weight = -1)
		{
			name = c_name;
			bio = c_bio;

			//Place the values into the List
			//NOTE: Make sure these are added in the same order you see in public static class eAtt (Enums.cs)
			a = new List<int>();
			a.Add(c_curHP);
			a.Add(c_maxHP);
			a.Add(c_curAutism);
			a.Add(c_maxAutism);
			a.Add(c_curSTR);
			a.Add(c_maxSTR);
			a.Add(c_curDEX);
			a.Add(c_maxDEX);
			a.Add(c_curINT);
			a.Add(c_maxINT);
			a.Add(c_curArmor);
			a.Add(c_maxArmor);
			a.Add(c_eyeColor);
			a.Add(c_race);
			a.Add(c_age);
			a.Add(c_height);
			a.Add(c_weight);

			//Randomize these if not passed in constructor (value will be -1)
			if (a[eAtt.eyeColor] == -1)
				a[eAtt.eyeColor] = rand.Next(1, 4);

			if (a[eAtt.age] == -1)
				a[eAtt.age] = rand.Next(18, 60);

			if (a[eAtt.race] == -1)
				a[eAtt.race] = rand.Next(1, 6);

			if (a[eAtt.height] == -1)
				a[eAtt.height] = rand.Next(150, 195);

			if (a[eAtt.weight] == -1)
				a[eAtt.weight] = rand.Next(50, 200);
		}
	}
}
