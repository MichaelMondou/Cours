using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Puissance_4
{
    class Grille
    {
        private Jeton[][] jetons = new Jeton[Puissance4.NB_COLS][];

        public Grille()
        {
            init();
        }

        public void init()
        {
            for (int i = 0; i < Puissance4.NB_COLS; i++)
            {
                this.jetons[i] = new Jeton[Puissance4.NB_COLS];

                for (int j = 0; j < Puissance4.NB_COLS; j++)
                {
                    this.jetons[i][j] = new Jeton(null, i * Puissance4.SIZE_W, j * Puissance4.SIZE_H + Puissance4.SIZE_H);
                }
            }
        }

        public void dessiner(Graphics g)
        {
            for (int i = 0; i < Puissance4.NB_COLS; i++)
                for (int j = 0; j < Puissance4.NB_ROWS; j++)
                {
                    dessinerJetons(g, i, j);
                    dessinerCase(g, i, j);
                }
        }

        private void dessinerJetons(Graphics g, int i, int j)
        {
            this.jetons[i][j].dessiner(g);
        }

        private void dessinerCase(Graphics g, int x, int y)
        {
            Image image = Properties.Resources._case;
            g.DrawImage(image, new Rectangle(x * Puissance4.SIZE_W, Puissance4.MARGIN_TOP + y * Puissance4.SIZE_H + Puissance4.SIZE_H, Puissance4.SIZE_W, Puissance4.SIZE_H));
        }

        public int ligneInsertion(int i)
        {
            int j = 0;

            while (j < Puissance4.NB_ROWS && this.jetons[i][j].getCouleur() == null)
            {
                j++;
            }

            return j - 1;
        }

        public Jeton this[int i, int j]
        {
            get
            {
                return this.jetons[i][j];
            }

            set
            {
                this.jetons[i][j] = value;
            }
        }

        public Point[] jetonGagnant(int i, int j)
        {
            Point[] jetons;

            if ((jetons = verifierColonne(i, j)) != null)
            {
                return jetons;
            }
            else if ((jetons = verifierLigne(i, j)) != null)
            {
                return jetons;
            }
            else if ((jetons = verifierDiagonaleNO_SE(i, j)) != null)
            {
                return jetons;
            }
            else if ((jetons = verifierDiagonaleNE_SO(i, j)) != null)
            {
                return jetons;
            }
            else
            {
                return null;
            }
        }

        private Point[] verifierColonne(int col, int lig)
        {
            String couleur = this.jetons[col][lig].getCouleur();

            int j = lig + 1;
            int cpt = 1;

            if (lig <= Puissance4.NB_ROWS - Puissance4.PUISSANCE)
            {
                while (j < Puissance4.NB_ROWS && couleur == this.jetons[col][j++].getCouleur())
                {
                    cpt++;
                }

                if (cpt >= Puissance4.PUISSANCE)
                {
                    Point p1 = new Point(col, lig);
                    Point p2 = new Point(col, lig + Puissance4.PUISSANCE - 1);

                    return new Point[] { p1, p2 };
                }
            }

            return null;
        }

        private Point[] verifierLigne(int col, int lig)
        {
            String couleur = this.jetons[col][lig].getCouleur();

            int cpt = 1;
            
            Point p1 = new Point(col, lig);
            Point p2 = new Point(col, lig);

            //Comptage à droite
            int i = col;
            while (i < Puissance4.NB_COLS - 1 && couleur == this.jetons[++i][lig].getCouleur())
            {
                p2.X = i;
                cpt++;
            }

            //Comptage à gauche
            i = col;
            while (i > 0 && couleur == this.jetons[--i][lig].getCouleur())
            {
                p1.X = i;
                cpt++;
            }

            if (cpt >= Puissance4.PUISSANCE)
            {
                return new Point[] { p1, p2 };
            }

            return null;
        }

        private Point[] verifierDiagonaleNO_SE(int col, int lig)
        {
            String couleur = this.jetons[col][lig].getCouleur();

            int cpt = 1;
            
            Point p1 = new Point(col, lig);
            Point p2 = new Point(col, lig);

            //Vers le bas
            int i = col;
            int j = lig;
            while (i < Puissance4.NB_COLS - 1 && j < Puissance4.NB_ROWS - 1 && couleur == this.jetons[++i][++j].getCouleur())
            {
                p1.X = i;
                p1.Y = j;
                cpt++;
            }
                        
            //Vers le haut
            i = col;
            j = lig;
            while (i > 0 && j > 0 && couleur == this.jetons[--i][--j].getCouleur())
            {
                p2.X = i;
                p2.Y = j ;
                cpt++;
            }

            if (cpt >= Puissance4.PUISSANCE)
            {
                return new Point[] { p1, p2 };
            }         

            return null;
        }

        private Point[] verifierDiagonaleNE_SO(int col, int lig)
        {
            String couleur = this.jetons[col][lig].getCouleur();

            int cpt = 1;
            
            Point p1 = new Point(col, lig);
            Point p2 = new Point(col, lig);

            //Vers le bas
            int i = col;
            int j = lig;
            while (i > 0 && j < Puissance4.NB_ROWS - 1 && couleur == this.jetons[--i][++j].getCouleur())
            {
                p1.X = i;
                p1.Y = j;
                cpt++;
            }

            //Vers le haut
            i = col;
            j = lig;
            while (i < Puissance4.NB_COLS - 1 && j > 0 && couleur == this.jetons[++i][--j].getCouleur())
            {
                p2.X = i;
                p2.Y = j;
                cpt++;
            }

            if (cpt >= Puissance4.PUISSANCE)
            {
                return new Point[] { p1, p2 };
            }

            return null;
        }
    }
}
