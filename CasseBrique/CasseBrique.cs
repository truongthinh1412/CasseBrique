using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace CasseBrique
{
    public class CasseBrique : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        readonly List<Balle> balles = new List<Balle>(); 


        public CasseBrique()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            Raquette raquette;
            Hud hud;
            MurDeBriques mu;
            hud = new Hud(this, "score", new Vector2(10, 10));
            this.Components.Add(hud);

            raquette = new Raquette(this, "Textures/whiteSquare");
            this.Components.Add(raquette);

            mu = new MurDeBriques(this);
            this.Components.Add(mu);

            Balle balle1 = new Balle(raquette, this, "Textures/ball", mu);
            balles.Add(balle1);
            this.Components.Add(balle1);

            base.Initialize();
            this._graphics.IsFullScreen = false;
            this._graphics.PreferredBackBufferWidth = 800;
            this._graphics.PreferredBackBufferHeight = 600;
            this._graphics.ApplyChanges();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGreen);
            base.Draw(gameTime);
        }
    }
}
