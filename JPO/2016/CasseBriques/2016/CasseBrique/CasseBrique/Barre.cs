using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasseBrique
{
    class Barre : PictureBox
    {
        private double deplacementX;

        public Barre()
        {
            this.BackgroundImage = global::CasseBrique.Properties.Resources.raquette_debutant;
            this.BackColor = Color.Transparent;
            this.Size = new Size(Constantes.LARGEUR_BARRE_DEBUTANT, Constantes.HAUTEUR_BARRE_DEBUTANT);
            initialisation();
        }

        public void initialisation()
        {
            deplacementX = Constantes.VITESSE_BARRE;
            this.Location = new Point(Constantes.LARGEUR_ECRAN_JEU / 2 - (this.Width / 2), Constantes.HAUTEUR_ECRAN_JEU - 100);
        }

        public void deplacer(int direction)
        {
            if (direction == -1)
                if (this.Location.X > 0)
                    this.Location = new Point(this.Location.X - (int)deplacementX, Constantes.HAUTEUR_ECRAN_JEU);
            if (direction == 1)
                if (this.Location.X + this.Width < Constantes.LARGEUR_ECRAN_JEU - this.Width)
                    this.Location = new Point(this.Location.X + (int)deplacementX, Constantes.HAUTEUR_ECRAN_JEU);
        }

    }
}
