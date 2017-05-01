using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
    public class Text
    {
        public string txt;
        public Vector2 position;
        public int lines = 1;


        private string WrapText(string text, float MaxLineWidth)
        {
            if (Game1.font.MeasureString(text).X < MaxLineWidth)
            {
                return text;
            }

            string[] words = text.Split(' ');
            StringBuilder wrappedText = new StringBuilder();
            float linewidth = 0f;
            float spaceWidth = Game1.font.MeasureString(" ").X;
            for (int i = 0; i < words.Length; ++i)
            {
                Vector2 size = Game1.font.MeasureString(words[i]);
                if (linewidth + size.X < MaxLineWidth)
                {
                    linewidth += size.X + spaceWidth;
                }
                else
                {
                    wrappedText.Append("\n");
                    linewidth = size.X + spaceWidth;
                    lines++;
                }
                wrappedText.Append(words[i]);
                wrappedText.Append(" ");
            }

            return wrappedText.ToString();
        }


        public Text(string text, Vector2 pos)
        {

            txt = WrapText(text, 512);
            position = pos;
        }
    }
}
