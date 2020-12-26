using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasseBrique
{
    class Balle : Element2D
    {
        private Raquette raquette;
        private Boolean start;
        protected int vitesseX;
        protected int vitesseY;

        public Balle(Raquette r, Game game, String texture) : base(game, texture, new Vector2(0,0))
        {
            raquette = r;
            vitesseX = 1;
            vitesseY = 1;
        }

        public override void Initialize()
        {
            this.frame = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            MouseState current_mouse = Mouse.GetState();

            if (current_mouse.LeftButton == ButtonState.Pressed)
            {
                start = true;
            }
            
            if (!start) {
                position.X = (int)raquette.position.X;
                position.Y = (int)raquette.position.Y - texture2D.Height;
                
            } else
            {
                if (position.X < 0 || position.X > 800)
                {
                    vitesseX = 0 - vitesseX;
                }
                position.X += vitesseX;

                if (position.Y < 0 || position.Y > 600)
                {
                    vitesseY = 0 - vitesseY;
                }
                position.Y += vitesseY;
            }
            base.Update(gameTime);
        }


        public Rectangle get_rectangle()
        {
            return new Rectangle((int)this.position.X, (int)this.position.Y, this.texture2D.Width, this.texture2D.Height);
        }
    }
}
