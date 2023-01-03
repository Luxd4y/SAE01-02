using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Content;
using MonoGame.Extended.Serialization;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace SAE
{
    internal class Zombies
    {
        private AnimatedSprite _zombie;
        private Vector2 _positionZombie;
        private int largeurZombie, hauteurZombie, vieZombie, vitesseZombie;
        private string typeZombie;
        public const int VIE_NORMAL = 25, VIE_GROS  = 50, VIE_RAPIDE = 10;
        public const int VITESSE_NORMAL = 25, VITESSE_GROS = 10, VITESSE_RAPIDE = 50;

        public Zombies(int largeurZombie, int hauteurZombie, int vieZombie, int vitesseZombie, string typeZombie, AnimatedSprite zombie, Vector2 positionZombie)
        {
            this.LargeurZombie = largeurZombie;
            this.HauteurZombie = hauteurZombie;
            this.TypeZombie = typeZombie;
            this.Zombie = zombie;
            this.PositionZombie = positionZombie;
        }

        public int LargeurZombie
        {
            get
            {
                return this.largeurZombie;
            }

            set
            {
                this.largeurZombie = value;
            }
        }

        public int HauteurZombie
        {
            get
            {
                return this.hauteurZombie;
            }

            set
            {
                this.hauteurZombie = value;
            }
        }

        public int VieZombie
        {
            get
            {
                return this.vieZombie;
            }

            set
            {
                this.vieZombie = value;
            }
        }

        public int VitesseZombie
        {
            get
            {
                return this.vitesseZombie;
            }

            set
            {
                this.vitesseZombie = value;
            }
        }

        public string TypeZombie
        {
            get
            {
                return this.typeZombie;
            }

            set
            {
                this.typeZombie = value;
            }
        }

        public AnimatedSprite Zombie
        {
            get
            {
                return this._zombie;
            }

            set
            {
                this._zombie = value;
            }
        }

        public Vector2 PositionZombie
        {
            get
            {
                return this._positionZombie;
            }

            set
            {
                this._positionZombie = value;
            }
        }

        public void SpawnZombie()
        {
            if (this.TypeZombie == "Normal")
            {
                this.vieZombie = Zombies.VIE_NORMAL;
                this.VitesseZombie = Zombies.VITESSE_NORMAL;
            }
            if (this.TypeZombie == "Gros")
            {
                this.vieZombie = Zombies.VIE_GROS;
                this.VitesseZombie = Zombies.VITESSE_GROS;
            }
            if (this.TypeZombie == "Rapide")
            {
                this.vieZombie = Zombies.VIE_RAPIDE;
                this.VitesseZombie = Zombies.VITESSE_RAPIDE;
            }
        }
    }
}
