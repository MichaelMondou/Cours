using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasseBrique
{
    class Balle : PictureBox
    {
        private int deplacementX, deplacementY;
        private bool toucheBloc = false; // vrai si la balle a touché un bloc au tour actuel

        private Point Centre;

        //Initialisation de la balle
        public Balle()
        {
            this.Image = global::CasseBrique.Properties.Resources.balle;
            this.BackColor = Color.Transparent;
            this.Size = new Size(Constantes.TAILLE_BALLE, Constantes.TAILLE_BALLE);
            this.Centre = new Point(this.Location.X + ((this.Location.X + this.Width - this.Location.X) / 2), (this.Location.Y + (this.Location.Y + this.Height - this.Location.Y) / 2));
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = 1;
            deplacementY = -1;
            this.Location = new Point(Constantes.LARGEUR_ECRAN_JEU / 2 - (Constantes.TAILLE_BALLE / 2), Constantes.HAUTEUR_ECRAN_JEU - 115);
        }

        public void bouger()
        {
            Location = new Point(Location.X + (int)deplacementX, Location.Y + (int)deplacementY);
            this.Centre = new Point(this.Location.X + ((this.Location.X + this.Width - this.Location.X) / 2), (this.Location.Y + (this.Location.Y + this.Height - this.Location.Y) / 2));
        }

        public void toucherFenetre(int largeurFenetre, int hauteurFenetre) // Savoir si la balle sort de la fenêtre
        {
            if (Location.X + Constantes.TAILLE_BALLE >= largeurFenetre - Constantes.TAILLE_BALLE)
            {
                deplacementX = -1 * deplacementX;
            }
            if (Location.X < 0)
            {
                deplacementX = -1 * deplacementX;
            }
            if (Location.Y < 25)
            {
                deplacementY = -1 * deplacementY;
            }
        }

        public void toucherBarre(Barre barre) // Savoir si la balle touche la barre
        {
            if (this.Location.Y + this.Size.Height > barre.Location.Y &&
               this.Location.Y < barre.Location.Y &&
               this.Location.X + this.Size.Width < barre.Location.X + barre.Size.Width &&
               this.Location.X > barre.Location.X)
            {
                deplacementY = -1 * deplacementY;
            }
        }

        public bool sortie()
        {
            if (Location.Y > Constantes.HAUTEUR_ECRAN_JEU)
            {
                return true;
            }
            return false;
        }

        public int toucheDuBloc(Bloc bloc)
        {
            int nb = 0;
            /**
             *Verifie si un des coins de la balle rentre dans la brique
             **/
            if (coinSupDroit(bloc) || CoinSupGauche(bloc) || CoinInfGauche(bloc) || CoinInfDroit(bloc))
            {
                /**
                * Si le centre de la balle est à gauche ou à droite de la brique
                **/

                if ((this.Centre.Y <= bloc.Location.Y) || (this.Centre.Y >= bloc.Location.Y + bloc.Height))
                {
                    deplacementY = -1 * deplacementY;
                }
                else if ((this.Centre.X <= bloc.Location.X) || (this.Centre.X >= bloc.Location.X + bloc.Width))
                {
                    deplacementX = -1 * deplacementX;
                }

                nb = Constantes.SCORE_BRIQUE;
                bloc.Visible = false;
                toucheBloc = true;
            }
            return nb;
        }

        private bool CoinInfDroit(Bloc bloc)
        {
            bool rentre = false;
            if (((bloc.Location.Y <= this.Location.Y + this.Height) && (this.Location.Y + this.Height <= bloc.Location.Y + bloc.Height)) &&
                ((bloc.Location.X <= this.Location.X + this.Width) && (this.Location.X <= bloc.Location.X + bloc.Width)))
            {
                rentre = true;
            }
            return rentre;
        }

        private bool CoinInfGauche(Bloc bloc)
        {
            bool rentre = false;
            if (((bloc.Location.Y <= this.Location.Y + this.Height) && (this.Location.Y + this.Height <= bloc.Location.Y + bloc.Height)) &&
                ((bloc.Location.X <= this.Location.X) && (this.Location.X <= bloc.Location.X + bloc.Width)))
            {
                rentre = true;
            }
            return rentre;
        }

        private bool CoinSupGauche(Bloc bloc)
        {
            bool rentre = false;
            if (((bloc.Location.Y <= this.Location.Y) && (this.Location.Y <= bloc.Location.Y + bloc.Height)) &&
                ((bloc.Location.X <= this.Location.X) && (this.Location.X <= bloc.Location.X + bloc.Width)))
            {
                rentre = true;
            }
            return rentre;
        }

        private bool coinSupDroit(Bloc bloc)
        {
            bool rentre = false;
            if (((bloc.Location.Y <= this.Location.Y) && (this.Location.Y <= bloc.Location.Y + bloc.Height)) &&
                ((bloc.Location.X <= this.Location.X + this.Width) && (this.Location.X <= bloc.Location.X + bloc.Width)))
            {
                rentre = true;
            }
            return rentre;
        }

        public int DeplacementY
        {
            get { return deplacementY; }
            set { deplacementY = value; }
        }

        public int DeplacementX
        {
            get { return deplacementX; }
            set { deplacementX = value; }
        }

        public bool ToucheBloc
        {
            get { return toucheBloc; }
            set { toucheBloc = value; }
        }

    }
}
