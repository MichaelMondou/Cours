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
            this.BackgroundImage = global::CasseBrique.Properties.Resources.raquette;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Transparent;
            this.Size = new Size(Constantes.LARGEUR_BARRE, Constantes.HAUTEUR_BARRE);
            initialisation();
        }

        // Cette action sert à initialiser la barre
        public void initialisation()
        {
            deplacementX = Constantes.VITESSE_BARRE;
            this.Location = new Point(Constantes.LARGEUR_ECRAN_JEU / 2 - (this.Width / 2), Constantes.HAUTEUR_ECRAN_JEU - 100);
        }
    }
}
