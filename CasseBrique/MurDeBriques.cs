using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CasseBrique
{
    class MurDeBriques : GameComponent
    {
        public List<Brique> briques;
        public int nbBriques = 10;
        public int nbBriqueVitesse = 5;


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

            
            for (int i = 0; i < this.nbBriqueVitesse; i++)
            {
                BriqueDeVitesse brique = new BriqueDeVitesse(base.Game, "Textures/wall");
                briques.Add(brique);
                this.Game.Components.Add(brique);
            }
        } 
    }
}
