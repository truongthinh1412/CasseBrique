using Microsoft.Xna.Framework;
using System;

namespace CasseBrique
{
    class Hud : ElementText2D
    {
        public Hud(Game game, String text, Vector2 position) : base(game, text, position)
        {

        }

        public void update_text(string text)
        {
            this.text = text;
        }
    }
}
