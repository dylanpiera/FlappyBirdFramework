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
        private Score score;

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

        internal Bird Bird
        {
            get
            {
                return bird;
            }

            set
            {
                bird = value;
            }
        }

        public PlayingState()
        {
            bird = new Bird();
            pipes = new GameObjectList();
            score = new Score();
            frameCount = 0;

            score.Position = new Vector2(300, 50);


            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
            this.Add(pipes);
            this.Add(score);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            bool isGameOver = false;
            int pipeScoreCount = 0;

            if(((this.Bird.Position.Y > FlappyBird.Screen.Y) || (this.Bird.Position.Y < 0) || (this.Bird.Position.X < 0) || (this.Bird.Position.X > FlappyBird.Screen.X)))
            {
                isGameOver = true;
            }
            foreach (Pipe pipe in this.pipes.Objects)
            {
                if (pipe.Position.X < this.Bird.Position.X) pipeScoreCount++;

                if (this.Bird.CollidesWith(pipe))
                {
                    isGameOver = true;
                }
            }
            
            
            score.Text = "Score: " + pipeScoreCount;

            frameCount++;

            if(frameCount >= 100)
            {
                frameCount = 0;
                this.Pipes.Add(new Pipe());
            }

            if (isGameOver) SetGameOver();
        }

        public void SetGameOver()
        {
            this.Pipes.Objects.Clear();
            this.frameCount = 0;
            this.bird.Reset();
        }
    }
}
