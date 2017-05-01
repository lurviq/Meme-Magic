using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Text;

namespace Meme_Magic
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        //Misc
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KbHandler kbHandler = new KbHandler();
        static TextConsole txtConsole;
        int currentIndex = 0; //What line we are currently on on the console.
        Entity player;
        //Fonts
        public static SpriteFont font;
<<<<<<< HEAD
=======

>>>>>>> 537a73c152c057bbabf2701c3bd849859ca8029e
        //Sprites
        Texture2D background;
        Texture2D frame;
        Texture2D heartIcon;
        Texture2D autismIcon;

        //Strings
        public static string input = "";

        private static string WrapText(SpriteFont spriteFont, string txt, float maxLineWidth)
        {
            string[] words = txt.Split(' ');
            StringBuilder sb = new StringBuilder();
            float lineWidth = 0f;
            float spaceWidth = spriteFont.MeasureString(" ").X;

            foreach (string word in words)
            {
                Vector2 size = spriteFont.MeasureString(word);

                if (lineWidth + size.X < maxLineWidth)
                {
                    sb.Append(word + " ");
                    lineWidth += size.X + spaceWidth;
                }
                else
                {
                    sb.Append("\n" + word + " ");
                    lineWidth = size.X + spaceWidth;
                }
            }

            return sb.ToString();
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
			
        }

        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = 800;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 600;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            txtConsole = new TextConsole();
            
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //Load Fonts
            font = Content.Load<SpriteFont>("Console");
            //Load Sprites
            background = Content.Load<Texture2D>("Sprites\\bg");
            frame = Content.Load<Texture2D>("Sprites\\frame");
            autismIcon = Content.Load<Texture2D>("Sprites\\autismicon");
            heartIcon = Content.Load<Texture2D>("Sprites\\hpicon");
            txtConsole.Add("This is a really, really long string. This is a really, really long string. This is a really, really long string. This is a really, really long string. This is a really, really long string. This is a really, really long string. ");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            kbHandler.Update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            
            //Draw the background first
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            //Then strings inbetween frame and background
            spriteBatch.DrawString(font, ">" + input, new Vector2(240, 544 + 8), Color.White);
            //Draw icons and the rest.
            spriteBatch.Draw(autismIcon, new Rectangle(34, 512, 32, 32), Color.White);
            spriteBatch.Draw(heartIcon, new Rectangle(32, 544, 32, 32), Color.White);
            if (txtConsole.list.Count > 0) 
            {
                foreach (Text text in txtConsole.list) //Draw each line of text in the console.
                {
                    spriteBatch.DrawString(font, text.txt, text.position, Color.White);
                }
            }
            

            //Then frame.
            spriteBatch.Draw(frame, new Rectangle(0, 0, 800, 600), Color.White);
            
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public static void ExecuteCommand(string command)
        {
            
        }

        public static void NewTextEntry(string text)
        {
            switch (text)
            {
                default:
                    WrapText(font, text, 0.2f);
                    

                    txtConsole.Add(text);
                    break;
            }
        }

        
    }
}
