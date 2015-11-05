using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace New_JPO
{
    class Balle : PictureBox
    {
        private double deplacementX, deplacementY;
        private bool toucheBloc = false; // vrai si la balle a touché un bloc au tour actuel
        private Point Centre;

        public bool ToucheBloc
        {
            get { return toucheBloc; }
            set { toucheBloc = value; }
        }

        //Initialisation de la balle
        public Balle()
        {
            this.BackColor = Constantes.COULEUR_BALLE;
            this.Size = new Size(Constantes.TAILLE_BALLE, Constantes.TAILLE_BALLE);
            this.Centre = new Point(this.Location.X + ((this.Location.X + this.Width - this.Location.X) / 2), (this.Location.Y + (this.Location.Y + this.Height - this.Location.Y) / 2));
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = Constantes.VITESSE_BALLE;
            deplacementY = -Constantes.VITESSE_BALLE;
            this.Location = new Point(978 / 2 - (Constantes.TAILLE_BALLE / 2), 480);
        }

        public void miseAJourNiveau(Niveau niveau_du_jeu)
        {
            switch (niveau_du_jeu)
            {
                case Niveau.DEBUTANT:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BALLE;
                    else
                        deplacementX = -Constantes.VITESSE_BALLE;
                    if (deplacementY > 0)
                        deplacementY = Constantes.VITESSE_BALLE;
                    else
                        deplacementY = -Constantes.VITESSE_BALLE;
                    break;
                case Niveau.INTERMEDIAIRE:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BALLE * 1.5;
                    else
                        deplacementX = -Constantes.VITESSE_BALLE * 1.5;
                    if (deplacementY > 0)
                        deplacementY = Constantes.VITESSE_BALLE * 1.5;
                    else
                        deplacementY = -Constantes.VITESSE_BALLE * 1.5;
                    break;
                case Niveau.EXPERT:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BALLE * 2.0;
                    else
                        deplacementX = -Constantes.VITESSE_BALLE * 2.0;
                    if (deplacementY > 0)
                        deplacementY = Constantes.VITESSE_BALLE * 2.0;
                    else
                        deplacementY = -Constantes.VITESSE_BALLE * 2.0;
                    break;
            }
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

            //Temporaire
            if (Location.Y + this.Size.Height > hauteurFenetre)
            {
                deplacementY = -1 * deplacementY;
            }

        }

        public void toucherBarre(Barre barre) // Savoir si la balle touche la barre
        {
            if (this.Location.Y + this.Size.Height > barre.Location.Y &&
               this.Location.Y < barre.Location.Y &&
               this.Location.X + this.Size.Width > barre.Location.X &&
               this.Location.X < barre.Location.X + barre.Size.Width)
            {
                deplacementY = -1 * deplacementY;
            }
        }

        public bool sortie(int hauteurFenetre)
        {
            if (Location.Y > hauteurFenetre - 3 * Constantes.TAILLE_BALLE)
            {
                initialisation();
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
                ToucheBloc = true;
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

        public double DeplacementY
        {
            get { return deplacementY; }
            set { deplacementY = value; }
        }

        public double DeplacementX
        {
            get { return deplacementX; }
            set { deplacementX = value; }
        }


    }
}
