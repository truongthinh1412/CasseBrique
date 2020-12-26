using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasseBrique
{
    class Raquette : Element2D
    {
        public Raquette(Game game, String texture) : base(game, texture, new Vector2(0, 0))
        {

        }

        public override void Initialize()
        {
            this.frame = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            MouseState current_mouse = Mouse.GetState();

            position.X = current_mouse.X;
            position.Y = 550;

            if (position.X > this.Game.GraphicsDevice.PresentationParameters.BackBufferWidth - (texture2D.Width / 2))
            {
                position.X = this.Game.GraphicsDevice.PresentationParameters.BackBufferWidth - (texture2D.Width / 2);
            }
            else if (position.X < -(texture2D.Width / 2))
            {
                position.X = -(texture2D.Width / 2);
            }

            base.Update(gameTime);
        }

        public Rectangle get_rectangle()
        {
            return new Rectangle((int)this.position.X, (int)this.position.Y, this.texture2D.Width, this.texture2D.Height);
        }
    }
}
