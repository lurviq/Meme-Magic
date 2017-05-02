using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
	public static class eAtt
	{
        public static int level = 0;
		public static int curHP = 1;
		public static int maxHP = 2;
		public static int curAutism = 3;
		public static int maxAutism = 4;
		public static int curSTR = 5;
		public static int maxSTR = 6;
		public static int curDEX = 7;
		public static int maxDEX = 8;
		public static int curINT = 9;
		public static int maxINT = 10;
		public static int curArmor = 11;
		public static int maxArmor = 12;
		public static int eyeColor = 13;
		public static int race = 14;
		public static int age = 15;
		public static int height = 16;
		public static int weight = 17;

		public static int MAX_ATTRIBUTES = 18;
	}

	public static class eRaces
	{
		public const int white = 0;
		public const int black = 1;
		public const int indian = 2;
		public const int sandnigger = 3;
		public const int asian = 4;
		public const int hispanic = 5;

		public const int MAX_RACES = 6;

		public static string getString(int race)
		{
			switch (race)
			{
				case white:
					return "White";
				case black:
					return "Black";
				case indian:
					return "Indian";
				case sandnigger:
					return "Sandnigger";
				case asian:
					return "Asian";
				case hispanic:
					return "Hispanic";
				default:
					return "UNKNOWN_RACE: " + race.ToString();
			}
		}
	}

	public static class eColors
	{
		public const int red = 0;
		public const int green = 1;
		public const int blue = 2;

		public const int MAX_COLORS = 3;

		public static string getString(int color)
		{
			switch (color)
			{
				case red:
					return "red";
				case green:
					return "green";
				case blue:
					return "blue";
				default:
					return "UNKNOWN_COLOR: " + color.ToString();
			}
		}
	}
}
