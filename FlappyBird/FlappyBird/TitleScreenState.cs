using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class TitleScreenState : GameObjectList
    {
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                FlappyBird.GameStateManager.SwitchTo(FlappyBird.playingState);
            }
        }
    }
}
