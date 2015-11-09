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
        private int deplacementX, deplacementY;
        private int vitesse_deplacement;
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
            this.vitesse_deplacement = Constantes.VITESSE_BALLE;
            this.BackColor = Constantes.COULEUR_BALLE;
            this.Size = new Size(Constantes.TAILLE_BALLE, Constantes.TAILLE_BALLE);
            this.Centre = new Point(this.Location.X + ((this.Location.X + this.Width - this.Location.X) / 2), (this.Location.Y + (this.Location.Y + this.Height - this.Location.Y) / 2));
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = vitesse_deplacement;
            deplacementY = -vitesse_deplacement;
            this.Location = new Point(978 / 2 - (Constantes.TAILLE_BALLE / 2), 500);
        }

        public void bouger()
        {
            Location = new Point(Location.X + deplacementX, Location.Y + deplacementY);
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

        public bool sortie(int hauteurFenetre)
        {
            if (Location.Y > hauteurFenetre - 3 * Constantes.TAILLE_BALLE)
            {
                initialisation();
                return true;
            }
            return false;
        }


        // Compte le nombre de côtés du bloc touchés par la balle en fonction des coordonnées de la balle et du bloc,
        // des blocs voisins au bloc courant et du sens de déplacement de la balle
        public int CompteTouches(Bloc bloc, bool haut, bool bas, bool gauche, bool droite)
        {
            int nbTouche = 0;

            /* par le bas */
            if (Location.X + this.Size.Width > bloc.Location.X &&
                    Location.X < bloc.Location.X + bloc.getLargeur() &&
                        Location.Y + this.Size.Height > bloc.Location.Y + bloc.getHauteur() &&
                            Location.Y < bloc.Location.Y + bloc.getHauteur() && !bas && Math.Sign(deplacementY) == -1)
            {
                nbTouche++;
            }

            /* par le haut */
            if (Location.X + this.Size.Width > bloc.Location.X &&
                Location.X < bloc.Location.X + bloc.getLargeur() &&
                Location.Y + this.Size.Height > bloc.Location.Y &&
                Location.Y < bloc.Location.Y && !haut && Math.Sign(deplacementY) == 1)
            {
                nbTouche++;
            }

            /* par la gauche */
            if (Location.X + this.Size.Width > bloc.Location.X &&
                Location.X < bloc.Location.X &&
                Location.Y + this.Size.Height > bloc.Location.Y &&
                Location.Y < bloc.Location.Y + bloc.getHauteur() && !gauche && Math.Sign(deplacementX) == 1)
            {
                nbTouche++;
            }

            /* par la droite */
            if (Location.X + this.Size.Width > bloc.Location.X + bloc.getLargeur() &&
                Location.X < bloc.Location.X + bloc.getLargeur() &&
                Location.Y + this.Size.Height > bloc.Location.Y &&
                Location.Y < bloc.Location.Y + bloc.getHauteur() && !droite && Math.Sign(deplacementX) == -1)
            {
                nbTouche++;
            }
            return nbTouche;
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

        /*       public void toucheBarre(Barre barre)
               {
                   // on definit la zone ou la balle fait un rebond
                   if (this.Location.Y + this.Size.Height > barre.Location.Y &&
                       this.Location.Y < barre.Location.Y &&
                       this.Location.X + this.Size.Width > barre.Location.X &&
                       this.Location.X < barre.Location.X + barre.Size.Width)
                   {
                       Console.Beep(330, 20);
                       deplacementY = -1 * deplacementY;
                   }
               }
               */



    }
}
