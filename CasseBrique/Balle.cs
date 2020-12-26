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
            vitesseX = 3;
            vitesseY = -3;
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
                if (position.X < 0 || position.X > 800 - texture2D.Width)
                {
                    vitesseX = 0 - vitesseX;
                }
                

                if (position.Y < 0 || position.Y > 600 - texture2D.Height)
                {
                    vitesseY = 0 - vitesseY;
                }

                if(raquette.position.X < position.X + (texture2D.Width / 2)  && position.X + (texture2D.Width / 2) < raquette.position.X + raquette.texture2D.Width)
                {
                    if(position.Y + texture2D.Height > raquette.position.Y)
                    {
                        vitesseY = 0 - vitesseY;
                    }
                }

                

                position.X += vitesseX;
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
