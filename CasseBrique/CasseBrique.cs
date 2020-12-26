using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CasseBrique
{
    public class CasseBrique : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private HUD hud;
        private Raquette raquette;
        private Balle balle1;
        private Balle balle2;
        private Balle balle3;


        public CasseBrique()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            this.hud = new HUD(this, new Vector2(10, 10));
            this.Components.Add(this.hud);

            this.raquette = new Raquette(this, "Textures/raquette");
            this.Components.Add(this.raquette);

            this.balle1 = new Balle(raquette, this, "Textures/ball");
            this.Components.Add(this.balle1);
            base.Initialize();
            this._graphics.IsFullScreen = false;
            this._graphics.PreferredBackBufferWidth = 800;
            this._graphics.PreferredBackBufferHeight = 600;
            this._graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}
