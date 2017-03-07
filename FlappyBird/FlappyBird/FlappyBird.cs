using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FlappyBird
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class FlappyBird : GameEnvironment
    {
        public const String playingState = "playingState", titleScreenState = "titleScreenState", gameOverState = "gameOverState";
        
        public FlappyBird()
        {            
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen.X = 640;
            screen.Y = 480;
            SetFullScreen(false);

            gameStateManager.AddGameState(playingState, new PlayingState());
            gameStateManager.AddGameState(titleScreenState, new TitleScreenState());
            gameStateManager.AddGameState(gameOverState, new GameOverState());
            gameStateManager.SwitchTo(titleScreenState);

            // TODO: use this.Content to load your game content here
        }
       
    }
}
