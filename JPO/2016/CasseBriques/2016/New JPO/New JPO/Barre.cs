using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_JPO
{
    class Barre : PictureBox
    {
        private double deplacementX;


        public Barre()
        {
            this.BackgroundImage = global::New_JPO.Properties.Resources.raquette;
            this.BackColor = Color.Transparent;
            this.Size = new Size(Constantes.LARGEUR_BARRE, Constantes.HAUTEUR_BARRE);
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = Constantes.VITESSE_BARRE;
            this.Location = new Point(Constantes.LARGEUR_ECRAN_JEU / 2 - (Constantes.LARGEUR_BARRE / 2), Constantes.HAUTEUR_ECRAN_JEU);
        }

        public void miseAJourNiveau(Niveau niveau_du_jeu)
        {
            switch (niveau_du_jeu)
            {
                case Niveau.DEBUTANT:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BARRE;
                    else
                        deplacementX = -Constantes.VITESSE_BARRE;
                    break;
                case Niveau.INTERMEDIAIRE:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BARRE * 1.5;
                    else
                        deplacementX = -Constantes.VITESSE_BARRE * 1.5;
                    break;
                case Niveau.EXPERT:
                    if (deplacementX > 0)
                        deplacementX = Constantes.VITESSE_BARRE * 2.0;
                    else
                        deplacementX = -Constantes.VITESSE_BARRE * 2.0;
                    break;
            }
        }

        public void deplacer(int direction)
        {
            if(direction == -1)
                if (this.Location.X > 0)
                    this.Location = new Point(this.Location.X - (int)deplacementX, Constantes.HAUTEUR_ECRAN_JEU);
            if(direction == 1)
                if (this.Location.X + this.Width < Constantes.LARGEUR_ECRAN_JEU - Constantes.LARGEUR_BARRE)
                    this.Location = new Point(this.Location.X + (int)deplacementX, Constantes.HAUTEUR_ECRAN_JEU);
        }
        public double DeplacementX
        {
            get { return deplacementX; }
            set { deplacementX = value; }
        }
    }
}
