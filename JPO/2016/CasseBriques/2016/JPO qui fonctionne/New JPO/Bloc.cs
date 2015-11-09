using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace New_JPO
{
    class Bloc : PictureBox
    {

        private int largeur = 978 / Constantes.NB_BLOCS_LARGEUR;
        private int hauteur = Constantes.HAUTEUR_BLOCS;

        public Bloc(int i, int j, Color couleur, System.ComponentModel.ComponentResourceManager ressources)
        {
            this.BackColor = couleur;

            this.BorderStyle = BorderStyle.FixedSingle;

            this.Location = new Point(largeur * j, hauteur * i + 28);

            this.Size = new Size(largeur, hauteur);

            // Vérifier si c'est vraiment utile
            this.Name = "Blocs";
            this.TabIndex = 0;
            this.TabStop = false;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            //*********************************
        }

        public int getLargeur(){
            return largeur;
        }

        public int getHauteur(){
            return hauteur;
        }
    }
}
