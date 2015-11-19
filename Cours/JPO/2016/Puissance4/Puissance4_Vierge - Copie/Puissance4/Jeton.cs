using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    class Jeton
    {
        private string couleur;
        private Point position;

        public static void dessinerTrait(Graphics g, Point[] p)
        {
            g.DrawLine(new Pen(Color.GhostWhite, 10),
                        new Point(p[0].X * Constantes.SIZE_W + Constantes.SIZE_W / 2, Constantes.MARGIN_TOP + ((p[0].Y + 1) * Constantes.SIZE_H + Constantes.SIZE_H / 2)),
                        new Point(p[1].X * Constantes.SIZE_W + Constantes.SIZE_W / 2, Constantes.MARGIN_TOP + ((p[1].Y + 1) * Constantes.SIZE_H + Constantes.SIZE_H / 2)));
        }

        public Jeton(String couleur, int x, int y)
        {
            this.couleur = couleur;
            this.position = new Point(x, y);
        }

        public void dessiner(Graphics g)
        {
            if (this.couleur != null)
            {
                Image image = (Image)Properties.Resources.ResourceManager.GetObject(couleur);
                g.DrawImage(image, new Rectangle(this.position.X, Constantes.MARGIN_TOP + this.position.Y, Constantes.SIZE_W, Constantes.SIZE_H));
            }
        }

        public void setPotision(int x, int y)
        {
            this.position = new Point(x, y);
        }

        public void setPositionY(int y)
        {
            this.position = new Point(this.position.X, y);
        }

        public void inverserCouleur()
        {
            if (this.couleur == "darkVador" || this.couleur == "bombeVador")
            {
                this.couleur = "luke";
            }
            else if (this.couleur == "luke" || this.couleur == "bombeLuke")
            {
                this.couleur = "darkVador";
            }
        }

        public String getCouleur()
        {
            return this.couleur;
        }

        public void setCouleur(String couleur)
        {
            this.couleur = couleur;
        }

		public Point getPosition()
		{
			return position;
		}
    }
}
