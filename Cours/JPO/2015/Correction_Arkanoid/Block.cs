using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace arkanoid.V4
{
    class Block : PictureBox
    {
        bool estIncassable = false;

        static string[] imagesFond = 
        { 
            "pictureBoxVert.BackgroundImage", 
            "pictureBoxBleu.BackgroundImage",
            "pictureBoxRouge.BackgroundImage",
            "pictureBoxOrange.BackgroundImage",
            "pictureBoxJaune.BackgroundImage"
        };

        public Block(int i, int j,int absX, int addY,System.ComponentModel.ComponentResourceManager resources)
        {
            //tous les blocks d'une même ligne (paramètre 'j') 
            // auront une même couleur
            
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject(imagesFond[j])));

            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(i * absX, j * 20 + addY);
            this.Name = "blocks";
            this.Size = new System.Drawing.Size(30, 20);
            this.TabIndex = 0;
            this.TabStop = false;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }

        public void setVar(bool v) { estIncassable = v; }
        public bool getVar() { return estIncassable; }

    }
}
