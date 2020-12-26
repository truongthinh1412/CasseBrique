using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CasseBrique
{
    abstract class ElementText2D : DrawableGameComponent
    {
        protected Vector2 position;
        protected string text;
        protected SpriteBatch spriteBatch;
        private SpriteFont _font;

        protected ElementText2D(Game game, String text, Vector2 position) : base(game)
        {
            this.text = text;
            this.position = position;
        }

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch((this.Game).GraphicsDevice);
            this._font = this.Game.Content.Load<SpriteFont>("SpriteFont/Score");
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
            this.spriteBatch.DrawString(_font, this.text, this.position, Color.Black);
            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
