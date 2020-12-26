using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasseBrique
{
    class MurDeBriques : GameComponent
    {
        public List<Brique> briques;
        public int nbBriques = 10;


        public MurDeBriques(Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            this.briques = new List<Brique>();
            for (int i = 0; i < this.nbBriques; i++)
            {
                Brique brique = new Brique(base.Game, "Textures/wall");
                briques.Add(brique);
                this.Game.Components.Add(brique);
            }
        } 


        public override void Update(GameTime gameTime)
        {


            base.Update(gameTime);
        }
    }
}
