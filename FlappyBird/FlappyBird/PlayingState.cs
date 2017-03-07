using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FlappyBird
{
    class PlayingState : GameObjectList
    {
        private Bird bird;
        private GameObjectList pipes;
        private int frameCount;

        public GameObjectList Pipes
        {
            get
            {
                return pipes;
            }

            set
            {
                pipes = value;
            }
        }

        public PlayingState()
        {
            bird = new Bird();
            pipes = new GameObjectList();
            frameCount = 0;



            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
            this.Add(pipes);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            frameCount++;

            if(frameCount >= 100)
            {
                frameCount = 0;
                this.Pipes.Add(new Pipe());
            }
        }
    }
}
