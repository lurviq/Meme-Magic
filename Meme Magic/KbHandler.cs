using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Magic
{
    public class KbHandler
    {
        private Keys[] lastPressedKeys;
        KeyboardState kbState;

        public KbHandler()
        {
            lastPressedKeys = new Keys[0];
        }

        public void Update()
        {
            kbState = Keyboard.GetState();
            Keys[] pressedKeys = kbState.GetPressedKeys();

            //check if any of the previous update's keys are no longer pressed
            foreach (Keys key in lastPressedKeys)
            {
                if (!pressedKeys.Contains(key))
                    OnKeyUp(key);
            }

            //check if the currently pressed keys were already pressed
            foreach (Keys key in pressedKeys)
            {
                if (!lastPressedKeys.Contains(key))
                    OnKeyDown(key);
            }

            //save the currently pressed keys so we can compare on the next update
            lastPressedKeys = pressedKeys;
        }

        private void OnKeyDown(Keys key)
        {
            //do stuff
            switch (key)
            {
                case Keys.A:
                case Keys.B:
                case Keys.C:
                case Keys.D:
                case Keys.E:
                case Keys.F:
                case Keys.G:
                case Keys.H:
                case Keys.I:
                case Keys.J:
                case Keys.K:
                case Keys.L:
                case Keys.M:
                case Keys.N:
                case Keys.O:
                case Keys.P:
                case Keys.Q:
                case Keys.R:
                case Keys.S:
                case Keys.T:
                case Keys.U:
                case Keys.V:
                case Keys.W:
                case Keys.X:
                case Keys.Y:
                case Keys.Z:
                    if (Console.CapsLock & kbState.IsKeyDown(Keys.LeftShift))
                    {
                        Game1.input += key.ToString().ToLower();
                    }
                    else if (Console.CapsLock)
                    {
                        Game1.input += key.ToString().ToUpper();
                    }
                    else if (kbState.IsKeyDown(Keys.LeftShift))
                    {
                        Game1.input += key.ToString().ToUpper();
                    }
                    else
                    {
                        Game1.input += key.ToString().ToLower();
                    }
                    break;
                //Number keys
                case Keys.D1:
                    Game1.input += "1";
                        break;
                case Keys.D2:
                    Game1.input += "2";
                    break;
                case Keys.D3:
                    Game1.input += "3";
                    break;
                case Keys.D4:
                    Game1.input += "4";
                    break;
                case Keys.D5:
                    Game1.input += "5";
                    break;
                case Keys.D6:
                    Game1.input += "6";
                    break;
                case Keys.D7:
                    Game1.input += "7";
                    break;
                case Keys.D8:
                    Game1.input += "8";
                    break;
                case Keys.D9:
                    Game1.input += "9";
                    break;
                case Keys.D0:
                    Game1.input += "0";
                    break;
                case Keys.OemComma:
                    Game1.input += ",";
                break;
                case Keys.OemPeriod:
                    Game1.input += ".";
                    break;

                //Space
                case Keys.Space:
                    Game1.input += " ";
                    break;
                case Keys.Back:
                    if (Game1.input.Length > 0) //Prevent it from crashing if the value is null;
                    {
                        Game1.input = Game1.input.Remove(Game1.input.Length - 1);
                    }
                    break;
                case Keys.Enter:
                    if (Game1.input.Length > 0)
                    {
                        Game1.NewTextEntry(Game1.input);
                        Game1.input = Game1.input.Remove(Game1.input.Length - Game1.input.Length);
                    }
                    
                    break;
                default:
                    
                    break;
            }
        }

        private void OnKeyUp(Keys key)
        {
            //do stuff
        }
    }
}
