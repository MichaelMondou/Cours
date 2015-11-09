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
        private int deplacementX;
        private int vitesse_deplacement;


        public Barre()
        {
            this.vitesse_deplacement = Constantes.VITESSE_BARRE;
            this.BackColor = Constantes.COULEUR_BARRE;
            this.Size = new Size(Constantes.LARGEUR_BARRE, Constantes.HAUTEUR_BARRE);
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = vitesse_deplacement;
            this.Location = new Point(978 / 2 - (Constantes.LARGEUR_BARRE / 2), 510);
        }
        public void deplacer(int direction)
        {
            if (this.Location.X > Constantes.LARGEUR_BARRE && this.Location.X + this.Width < 978 - Constantes.LARGEUR_BARRE)
            {
                this.Location = new Point(direction * (this.Location.X + vitesse_deplacement), 510);
            }
        }

    }
}
