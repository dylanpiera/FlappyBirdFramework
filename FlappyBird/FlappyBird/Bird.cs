using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Bird : RotatingSpriteGameObject
    {
        private Vector2 startPosition;

        public Bird(string assetname = "spr_bird", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Origin = this.Sprite.Center;
            this.StartPosition = new Vector2(FlappyBird.Screen.X / 2, FlappyBird.Screen.Y / 2);
            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();
            this.Position = StartPosition;
            this.Velocity = Vector2.Zero;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            this.Velocity = new Vector2(0, this.Velocity.Y + 20);
            this.AngularDirection = new Vector2(100,this.Velocity.Y);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if(inputHelper.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                this.Velocity = new Vector2(0, -450);
            }
        }

        public Vector2 StartPosition
        {
            get
            {
                return startPosition;
            }

            set
            {
                startPosition = value;
            }
        }
    }
}
