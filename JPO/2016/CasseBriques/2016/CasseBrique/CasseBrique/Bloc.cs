using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasseBrique
{
    class Bloc : PictureBox
    {
        private int largeur = Constantes.LARGEUR_ECRAN_JEU / Constantes.NB_BLOCS_LARGEUR;
        private int hauteur = Constantes.HAUTEUR_BLOCS;

        public Bloc(int i, int j, Image image_bloc)
        {
            this.BackgroundImage = image_bloc;

            this.BorderStyle = BorderStyle.FixedSingle;

            this.Location = new Point(largeur * j, hauteur * i + 28);

            this.Size = new Size(largeur, hauteur);
        }

    }
}
