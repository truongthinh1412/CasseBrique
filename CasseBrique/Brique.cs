using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CasseBrique
{
    class Brique : Element2D
    {
        int x;
        int y;

        public Brique(Game game, String texture) : base(game, texture, new Vector2(0, 0))
        {
            Random _random = new Random();
            int maxX = 800 / texture2D.Width;
            x = _random.Next(0, maxX) * texture2D.Width;
            y = _random.Next(0, 4) * texture2D.Height + 15;
        }

        public override void Initialize()
        { 
            this.frame = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            base.Initialize();

        }

        public override void Update(GameTime gameTime)
        {
            position.X = x;
            position.Y = y;
        }

        public Rectangle get_rectangle()
        {
            return new Rectangle((int)this.position.X, (int)this.position.Y, this.texture2D.Width, this.texture2D.Height);
        }

        protected static int GenerateRandomInt(int minVal, int maxVal)
        {
            var rnd = new byte[4];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(rnd);
            var i = Math.Abs(BitConverter.ToInt32(rnd, 0));
            return Convert.ToInt32(i % (maxVal - minVal + 1) + minVal);
        }
    }
}
