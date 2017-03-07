using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Pipe : SpriteGameObject
    {
        public Pipe(string assetname = "spr_pipe", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Origin = this.Sprite.Center;
            this.Velocity = new Vector2(-300, 0);
            this.Position = new Vector2(700,this.RandomStart());
        }

        private int RandomStart()
        {
            return FlappyBird.Random.Next(200, 400);
        }
    }
}
