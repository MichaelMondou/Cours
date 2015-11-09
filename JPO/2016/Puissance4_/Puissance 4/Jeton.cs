using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Puissance_4
{
    class Jeton
    {
        private string couleur;
        private Point position;
        
        public static void dessinerTrait(Graphics g, Point[] p)
        {
            g.DrawLine(new Pen(Color.RoyalBlue, 10),
                        new Point(p[0].X * Puissance4.SIZE_W + Puissance4.SIZE_W / 2, Puissance4.MARGIN_TOP + ((p[0].Y + 1) * Puissance4.SIZE_H + Puissance4.SIZE_H / 2)),
                        new Point(p[1].X * Puissance4.SIZE_W + Puissance4.SIZE_W / 2, Puissance4.MARGIN_TOP + ((p[1].Y + 1) * Puissance4.SIZE_H + Puissance4.SIZE_H / 2)));
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
                Image image = (Bitmap)Properties.Resources.ResourceManager.GetObject(this.couleur);
                g.DrawImage(image, new Rectangle(this.position.X, Puissance4.MARGIN_TOP + this.position.Y, Puissance4.SIZE_W, Puissance4.SIZE_H));
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
            if (this.couleur == "rouge")
            {
                this.couleur = "jaune";
            }
            else if (this.couleur == "jaune")
            {
                this.couleur = "rouge";
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
    }
}
