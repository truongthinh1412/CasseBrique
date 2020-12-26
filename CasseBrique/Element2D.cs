using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CasseBrique
{
    abstract class Element2D : DrawableGameComponent
    {
        protected Vector2 position;
        protected SpriteBatch spriteBatch;
        protected Texture2D texture2D;
        protected Rectangle frame;

        protected Element2D(Game game, String texture, Vector2 position) : base(game)
        {
            this.position = position;
            this.texture2D = ((Game) this.Game).Content.Load<Texture2D>(texture);
        }

        public override void Initialize()
        {
            this.spriteBatch = new SpriteBatch((this.Game).GraphicsDevice);
            this.active = true;
            base.Initialize();
        }

        public override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
                this.spriteBatch.Draw(texture2D,
                    this.position,
                    this.frame,
                    Color.White);
            this.spriteBatch.End();

            base.Draw(gameTime);
        }

        public bool active { get; set; }
    }
}
