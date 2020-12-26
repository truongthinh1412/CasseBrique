using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasseBrique
{
    class Balle : Element2D
    {
        Raquette raquette;
        public Balle(Raquette r, Game game, String texture) : base(game, texture, new Vector2(0,0))
        {
            raquette = r;
        }

        public override void Initialize()
        {
            this.frame = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {

            position.X = (int)raquette.position.X;
            position.Y = (int)raquette.position.Y - texture2D.Height;
            base.Update(gameTime);
        }

        public Rectangle get_rectangle()
        {
            return new Rectangle((int)this.position.X, (int)this.position.Y, this.texture2D.Width, this.texture2D.Height);
        }
    }
}
