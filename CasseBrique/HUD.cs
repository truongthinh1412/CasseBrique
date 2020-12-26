using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasseBrique
{
    class HUD : ElementText2D
    {
        public HUD(Game game, Vector2 position) : base(game, "Score", position)
        {

        }

        public void update_text(string text)
        {
            this.text = text;
        }
    }
}
