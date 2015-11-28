using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace arkanoid.V4
{
    class Balle : PictureBox
    {
        private int deplacementX, deplacementY ;
        private const int SCORE_BRIQUE = 25;
        public const int TOUCHE_BAS = 1;
        public bool toucheBl=false;// vrai si la balle a touché un block au tour actuel

        //Initialisation de la balle
        public Balle()
        {
           deplacementX = -4;
           deplacementY = -4;
        }

        public void bouger()
        {
            /* Nouvelle position de la balle */
            Location = new System.Drawing.Point(Location.X + deplacementX, Location.Y + deplacementY);
        }

        public int toucheFenetre(int largeurFenetre, int hauteurFenetre)
       {
           /* La bille touche un bord de la fenetre */
           //Bord droit
           if (Location.X +Size.Width >= largeurFenetre-8)
           {
               Console.Beep(1000, 20);
               deplacementX = -1 * deplacementX;
           }
           //Bord gauche
           if (Location.X < 0)
           {
               Console.Beep(1000, 20);
               deplacementX = -1 * deplacementX;
           }
           //Bord Bas
           if (Location.Y + Size.Height > hauteurFenetre - 60)
           {
               Console.Beep(1000, 20);
               deplacementY = -1 * deplacementY;
               return TOUCHE_BAS;
           }
           //Bord Haut
           if (Location.Y +10 < 0)
           {
               Console.Beep(1000, 20);
               deplacementY = -1 * deplacementY;
           }

           
           
           return ~TOUCHE_BAS;
       }

        private int CompteTouches(int xBalle,int yBalle,int xBlock ,int yBlock, int hBlock, int wBlock,
            bool haut, bool bas,bool gauche,bool droite)
            // Compte le nombre de côtés du bloc touchés par la balle en fonction des coordonnées de la balle et du block,
            // des blocks voisins au block courant et du sens de déplacement de la balle
        {
            int nbTouche = 0;
            /* par le bas */
            if (xBalle + this.Size.Width > xBlock &&
                 xBalle < xBlock + wBlock &&
                 yBalle + this.Size.Height > yBlock + hBlock &&
                 yBalle < yBlock + hBlock && !bas && Math.Sign(deplacementY)== -1)
            {
                nbTouche++;
            }
              
            /* par le haut */
            if (xBalle + this.Size.Width > xBlock &&
                xBalle < xBlock + wBlock &&
                yBalle + this.Size.Height > yBlock &&
                yBalle < yBlock && !haut && Math.Sign(deplacementY)== 1)
            {
                nbTouche++;
            }
            
            /* par la gauche */
            if (xBalle + this.Size.Width > xBlock &&
                xBalle < xBlock &&
                yBalle + this.Size.Height > yBlock  &&
                yBalle < yBlock + hBlock && !gauche && Math.Sign(deplacementX)== 1)
            {
                nbTouche++;
            }
                      
            /* par la droite */
            if (xBalle + this.Size.Width > xBlock + wBlock &&
                xBalle < xBlock + wBlock &&
                yBalle + this.Size.Height > yBlock &&
                yBalle < yBlock + hBlock && !droite && Math.Sign(deplacementX)== -1)
            {
                nbTouche++;
            }
            return nbTouche;
        }

        public int toucheBlock(Block block,bool haut, bool bas,bool gauche,bool droite)
       {
           int xBalle = Location.X, yBalle = Location.Y ,
               xBlock = block.Location.X, yBlock = block.Location.Y,
           hBlock = block.Size.Height, wBlock=block.Size.Width;

           int pointBrique = 0; 

           

           if (block.Visible == true)
           {
               //il faut que la balle ne soit entrée en collision qu'avec un seul côté du block
               if (CompteTouches(xBalle, yBalle, xBlock, yBlock, hBlock, wBlock, haut, bas, gauche, droite) > 1)
               {
                   int i = 0;
                   int x = xBalle, y = yBalle;
                   //On fait progressivement reculer la balle pour voir quel est le premier côté du block qu'elle a touché
                   while (CompteTouches(x, y, xBlock, yBlock, hBlock, wBlock, haut, bas, gauche, droite) > 0)
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

               /*On détermine si la bille a touché un block en fonction des coordonnées de la balle et du block courant, des blocks voisins au block courant et du sens de déplacement de la balle */
               /* par le bas  */
               if (xBalle + this.Size.Width > xBlock &&
                 xBalle < xBlock + wBlock &&
                 yBalle + this.Size.Height > yBlock + hBlock &&
                 yBalle < yBlock + hBlock && !bas && Math.Sign(deplacementY)== -1)
               {
                   Console.Beep(220, 10);
                   deplacementY = -1 * deplacementY;


                   block.Visible = false;
                   pointBrique += SCORE_BRIQUE;
                   toucheBl = true;
               }
               else
               {
                   /* par la droite */
                   if (xBalle + this.Size.Width > xBlock + wBlock &&
                       xBalle < xBlock + wBlock &&
                       yBalle + this.Size.Height > yBlock &&
                       yBalle < yBlock + hBlock && !droite && Math.Sign(deplacementX)== -1)
                   {
                       Console.Beep(220, 10);
                       deplacementX = -1 * deplacementX;
                       block.Visible = false;
                       pointBrique += SCORE_BRIQUE;
                       toucheBl = true;

                   }
                   
                   else
                   {
                       /* par la gauche */
                       if (xBalle + this.Size.Width > xBlock &&
                           xBalle < xBlock &&
                           yBalle + this.Size.Height > yBlock &&
                           yBalle < yBlock + hBlock && !gauche && Math.Sign(deplacementX)== 1)
                       {
                           Console.Beep(220, 10);
                           deplacementX = -1 * deplacementX;
                           block.Visible = false;
                           pointBrique += SCORE_BRIQUE;
                           toucheBl = true;

                       }
                       else
                       {
                           /* par le haut */
                           if (xBalle + this.Size.Width > xBlock &&
                            xBalle < xBlock + wBlock &&
                            yBalle + this.Size.Height > yBlock &&
                            yBalle < yBlock && !haut && Math.Sign(deplacementY)== 1)
                           {
                               Console.Beep(220, 10);
                               deplacementY = -1 * deplacementY;
                               block.Visible = false;

                               pointBrique += SCORE_BRIQUE;
                               toucheBl = true;
                           }
                       }
                   }
               }
           }
           else if (block.Visible == false && block.getVar() == true)
                block.Visible = true;

           
           return pointBrique;
       }


        public void toucheBarre(Barre barre)
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

    }
}
