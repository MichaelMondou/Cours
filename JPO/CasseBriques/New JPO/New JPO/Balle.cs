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

        private const int SCORE_BRIQUE = 25;
        public bool toucheBloc = false; // vrai si la balle a touché un bloc au tour actuel

        //Initialisation de la balle
        public Balle()
        {
            this.vitesse_deplacement = Constantes.VITESSE_BALLE;
            this.BackColor = Constantes.COULEUR_BALLE;
            this.Size = new Size(Constantes.TAILLE_BALLE, Constantes.TAILLE_BALLE);
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

        public int toucheDuBloc(Bloc bloc, bool haut, bool bas, bool gauche, bool droite)
        {

            int pointBrique = 0;

            int xBalle = Location.X;
            int yBalle = Location.Y;

            if (bloc.Visible == true) // Si le bloc est visible
            {
                //il faut que la balle ne soit entrée en collision qu'avec un seul côté du bloc
                if (CompteTouches(bloc, haut, bas, gauche, droite) > 1)
                {
                    int i = 0;
                    int x = Location.X;
                    int y = Location.Y;
                    //On fait progressivement reculer la balle pour voir quel est le premier côté du block qu'elle a touché
                    while (CompteTouches(bloc, haut, bas, gauche, droite) > 0)
                    {

                        i++;
                        xBalle = x;
                        yBalle = y;
                        if (Math.Abs(x - Location.X) <= Math.Abs(deplacementX))
                            x -= 1 * Math.Sign(deplacementX);

                        if (Math.Abs(y - Location.Y) <= Math.Abs(deplacementY))
                            y -= 1 * Math.Sign(deplacementY);
                    }
                }

                /*On détermine si la bille a touché un bloc en fonction des coordonnées de la balle et du bloc courant, des blocs voisins au bloc courant et du sens de déplacement de la balle */
                /* par le bas  */
                if (Location.X + this.Size.Width > bloc.Location.X &&
                  Location.X < bloc.Location.X + bloc.getLargeur() &&
                  Location.Y + this.Size.Height > bloc.Location.Y + bloc.getHauteur() &&
                  Location.Y < bloc.Location.Y + bloc.getHauteur() && !bas && Math.Sign(deplacementY) == -1)
                {
                    deplacementY = -1 * deplacementY;


                    bloc.Visible = false;
                    pointBrique += SCORE_BRIQUE;
                    toucheBloc = true;
                }
                else
                {
                    /* par la droite */
                    if (Location.X + this.Size.Width > bloc.Location.X + bloc.getLargeur() &&
                        Location.X < bloc.Location.X + bloc.getLargeur() &&
                        Location.Y + this.Size.Height > bloc.Location.Y &&
                        Location.Y < bloc.Location.Y + bloc.getHauteur() && !droite && Math.Sign(deplacementX) == -1)
                    {
                        deplacementX = -1 * deplacementX;
                        bloc.Visible = false;
                        pointBrique += SCORE_BRIQUE;
                        toucheBloc = true;

                    }

                    else
                    {
                        /* par la gauche */
                        if (Location.X + this.Size.Width > bloc.Location.X &&
                            Location.X < bloc.Location.X &&
                            Location.Y + this.Size.Height > bloc.Location.Y &&
                            Location.Y < bloc.Location.Y + bloc.getHauteur() && !gauche && Math.Sign(deplacementX) == 1)
                        {
                            deplacementX = -1 * deplacementX;
                            bloc.Visible = false;
                            pointBrique += SCORE_BRIQUE;
                            toucheBloc = true;

                        }
                        else
                        {
                            /* par le haut */
                            if (Location.X + this.Size.Width > bloc.Location.X &&
                                Location.X < bloc.Location.X + bloc.getLargeur() &&
                                Location.Y + this.Size.Height > bloc.Location.Y &&
                                Location.Y < bloc.Location.Y && !haut && Math.Sign(deplacementY) == 1)
                            {
                                deplacementY = -1 * deplacementY;
                                bloc.Visible = false;

                                pointBrique += SCORE_BRIQUE;
                                toucheBloc = true;
                            }
                        }
                    }
                }
            }
            return pointBrique;
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
