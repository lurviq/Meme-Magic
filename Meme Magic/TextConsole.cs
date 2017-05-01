using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
    public class TextConsole
    {
        public List<Text> list = new List<Text>();
        int currentIndex = 0;

        public void Add(string text)
        {
            list.Add(new Text(text, new Vector2(224, 512)));
            foreach (Text txt in list)
            {
                txt.position = new Vector2(txt.position.X, txt.position.Y - (Game1.font.MeasureString(text).Y * list[currentIndex].lines) - 2);
            }
            currentIndex++;
        }
        public void Question(string text)
        {
            list.Add(new Text(text, new Vector2(224, 512)));
            foreach (Text txt in list)
            {
                txt.position = new Vector2(txt.position.X, txt.position.Y - (Game1.font.MeasureString(text).Y * list[currentIndex].lines) - 2);
            }
            currentIndex++;
        }
    }
    
}
