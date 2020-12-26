using Microsoft.Xna.Framework;
using System;

namespace CasseBrique
{
    class BriqueDeVitesse: Brique

    {
        public BriqueDeVitesse(Game game, String texture) : base(game, texture)
        {
            Random _random = new Random();
            int maxX = 800 / texture2D.Width;
            x = _random.Next(0, maxX) * texture2D.Width;
            y = _random.Next(0, 4) * texture2D.Height + 15;
        }
        public override void Initialize()
        {
            frame = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            base.Initialize();

        }
        public override void Update(GameTime gameTime)
        {
            if (position.X < 800)
            {
                position.X += 5;
            }
            else
            {
                position.X = 0;
            }
            
            base.Update(gameTime);
        }
    }
}
