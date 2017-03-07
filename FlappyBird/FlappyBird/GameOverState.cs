using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class GameOverState : GameObjectList
    {
        public GameOverState()
        {
            TextGameObject text = new TextGameObject("GameFont"), text2 = new TextGameObject("GameFont"), text3 = new TextGameObject("GameFont");
            text.Text = "Press Space";
            text2.Text = "To Continue.";
            text3.Text = "Gameover!";
            text.Color = Color.Black;
            text2.Color = Color.Black;
            text3.Color = Color.Black;
            text.Position = new Vector2(((FlappyBird.Screen.X/2) - (text.Size.X/2)), ((FlappyBird.Screen.Y / 2)));
            text2.Position = new Vector2(((FlappyBird.Screen.X / 2) - (text2.Size.X / 2)), ((FlappyBird.Screen.Y / 2) + (text3.Size.Y/2)));
            text3.Position = new Vector2(((FlappyBird.Screen.X / 2) - (text3.Size.X / 2)), ((FlappyBird.Screen.Y / 2) - (text3.Size.Y)));

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(text);
            this.Add(text2);
            this.Add(text3);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if(inputHelper.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                FlappyBird.GameStateManager.SwitchTo(FlappyBird.titleScreenState);
            }
        }
    }
}
