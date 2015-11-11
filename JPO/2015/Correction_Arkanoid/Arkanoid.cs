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
    public partial class Arkanoid : Form
    {

#region LES VARIABLES DU JEUX
        Block[][] blocks = new Block[10][]; // Nos briques, contenues dans un tableau
        const int NBR_VIES_INITIAL = 3;     // nombre de vie en d�but de partie
        enum Etat{ATTENTE,JOUE,RELANCE};    // les diff�rents etats du jeux
        Etat etat_du_jeu = Etat.ATTENTE;    // etat du jeux
        int nbr_vie;                        // les vie restantes du joueur
        int score;                          // le score du joueur
       

#endregion

#region FONCTIONS DE CONSTRUCTION

        public Arkanoid()    //On initialise nos �l�ment contenus dans notre fentere.
        {
           InitializeComponent();//Les composants
           InitializeBlock(); //Les blocks
            nbr_vie = NBR_VIES_INITIAL;
            score = 0;
            txtvie.Text = ("Vie : " + nbr_vie);
            txtNiveau.Text = ("Niveau : Moyen");
        }


        private void InitializeBlock()  //Cette fonction initialise nos blocks
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            int absX = (this.Size.Width-1) / 10;
            int absY = BarreDoutil.Size.Height;

            // CONSTRUCTION DE TOUS LES BLOCS SUR UNE GRILLE DE 10 X 5
            // I REPRESENTE L'INDICE DES LIGNES
            // J REPRESENTE L'INDICE DES COLONNES
            for (int i = 0; i < 10; i++)
            {
                blocks[i] = new Block[5];//Tableau de blocks
                for (int j = 0; j < 5; j++) 
                {
                    this.blocks[i][j] = new Block(i, j, absX, absY, resources);   //on ajoute un nouveau block au tableau de Block en indiquant la taille de la barre d'outil
                    this.blocks[i][j].BorderStyle = BorderStyle.Fixed3D;       // modifie le style des block
                    this.Controls.Add(this.blocks[i][j]); // on ajoute le block aux composants ("contr�les") de la fenetre
                }
            }
            for(int k = 0; k < 10; k++)
                this.blocks[k][0].setVar(true);
        }

#endregion


#region GESTION DES EVENEMENTS

        // Verification de tous les �venements possibles � chaque fin de temps donn�e ( les Ticks )
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Dans tous les cas possibles, la balle est en mouvement
            balle.bouger();

#region block touch� par la balle

            // On parcourt tous les blocks contenue dans le tableau pour connaitre ceux touch� par la balle
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 5; j++)
                {
                    if(!balle.toucheBl)//la balle ne peut toucher qu'un bloc par tour
                    {
                        bool haut = false, bas = false, droite = false, gauche = false;// on d�termine si le block � des blocks voisins
                        if (i > 0)
                            if (blocks[i-1][j].Visible)
                                gauche = true;
                        if (i < 9)
                            if (blocks[i + 1][j].Visible)
                                droite = true;
                        if (j > 0)
                            if (blocks[i][j-1].Visible)
                                haut = true;
                        if (j < 4)
                            if (blocks[i][j+1].Visible)
                                bas = true;

                        score += balle.toucheBlock(blocks[i][j],haut,bas,gauche,droite); // fonction qui retourne le nombre de point gagn� si le block est touch�, 0 sinon
                    }

                }
                balle.toucheBl = false;// fin de la phase de collision, toucheBl est r�initialis� pour le prochain tour
                txtscore.Text = ("Score : " + score);           // mise a jours de l'affichage du score
#endregion

#region colision de la balle avec les autres element

            if (balle.toucheFenetre(this.Size.Width, this.Size.Height) == Balle.TOUCHE_BAS)
            {
                timer1.Enabled = false;
                if (nbr_vie > 0)//reste-t-il des vies au joueur ?
                {
                    perdreVie();
                    // emplacement de la balle au demarage
                    this.balle.Location = new Point(150, 450);
                    etat_du_jeu = Etat.RELANCE;
                }
                else
                {
                    perdu();
                    this.Dispose(true);
                }
            }


            // on v�rifie si la balle a touch� la barre 
            // la m�thode ajuste les prochains d�placements
            balle.toucheBarre(this.barre);      // voir class : "Balle.cs"
#endregion

#region verification de fin de jeu

            bool fini = true;
            // On v�rifie si tous les block sont d�truits
            foreach(Block[] ligne in blocks)
                foreach(Block colonne in ligne)
                {
                    if (colonne.Visible == true)//Si un block est visible(donc restant), alors la partie continue.
                    {
                        fini = false; 
                        break;
                    }
                }
            if (fini)//si il ne reste aucun block, alors on affiche les �v�nements de victoire
            {
                this.timer1.Stop();
                MessageBox.Show("Bravo !");
                this.Dispose(true);
            }

#endregion

        }

#endregion


#region BARRE D'OUTIL

        //On a cliqu� sur "pause"
        private void appelPause(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.etat_du_jeu = Etat.RELANCE;
        }

        //On veut relancer le jeu
        private void appelReprendre(object sender, EventArgs e)
        {
            this.timer1.Start();
            etat_du_jeu = Etat.JOUE;
        }


        //On a cliqu� sur "D�marrer"
        private void pauseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            instruction.Location = new Point(1000, 1000);
            demarrerJeu();      // voir region : "ACTION DANS LE JEU"
        }


        //Mode de jeu d�butant.
        private void DebutantMod_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 30;
            this.DebutantMod.Checked = true;
            this.MoyenMod.Checked = false;
            this.Confirm�Mod.Checked = false;
            txtNiveau.Text = ("Niveau : D�butant");
        }
        //Mode de jeu moyen
        private void MoyenMod_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 20;
            this.barre.Size = new Size(60, 5);
            this.DebutantMod.Checked = false;
            this.MoyenMod.Checked = true;
            this.Confirm�Mod.Checked = false;
            txtNiveau.Text = ("Niveau : Moyen");

        }
        //Mode de jeu Confirm�
        private void Confirm�Mod_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            //this.barre.Size = new Size(40, 5);
            this.DebutantMod.Checked = false;
            this.MoyenMod.Checked = false;
            this.Confirm�Mod.Checked = true;
            txtNiveau.Text = ("Niveau : Confirm�");
        }
#endregion 


#region GESTION DES ACTIONS CLAVIER SOURIS

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
    // si on presse la barre d'espace quand le jeu se relance
            if (e.KeyCode == Keys.Space && etat_du_jeu==Etat.RELANCE)
            {
                etat_du_jeu = Etat.JOUE;
                timer1.Enabled = true;
            }

    // si on presse F2 pour pour d�marrer la partie
            if (e.KeyCode == Keys.F2)
            {
                instruction.Location = new Point(1000, 1000);
                demarrerJeu();  
            }
            if (e.KeyCode == Keys.P && etat_du_jeu == Etat.JOUE)
                appelPause(etat_du_jeu, e);

            else if (e.KeyCode == Keys.P && etat_du_jeu == Etat.RELANCE)
                appelReprendre(etat_du_jeu, e);
        }

        //On a d�plac� la souris
        private void arkanoid_MouseMove(object sender, MouseEventArgs souris)
        {
            //Il faut donc d�placer la barre en fonction de la position de la souris
            int moitie = barre.Size.Width / 2;
            barre.Location = new System.Drawing.Point(souris.X - moitie, barre.Location.Y);
        }

#endregion

#region ACTION DANS LE JEU

// lorsque on a plus de vie
        private void perdu()
        {
            MessageBox.Show("Oh ! Vous n'avez plus de vie ! Game Over");
            musiquePerdu();
            timer1.Enabled = false;     // le mouvement de la balle est arr�t�
        }

//d�mmarre une nouvelle partie
        private void demarrerJeu()
        {
            switch (etat_du_jeu)
            {
                case Etat.ATTENTE:
                {
                    this.timer1.Start();
                    this.etat_du_jeu = Etat.JOUE;
                    break;
                }
                case Etat.RELANCE:
                {
                    this.timer1.Start();
                    break;
                }
            }
        }

// lors qu'on perd une vie
        private void perdreVie()
        {
            nbr_vie--;
            txtvie.Text = ("Vie : " + nbr_vie);
        }

#endregion

#region SON DU JEU

        private void musiquePerdu()
        {
            int[] partition = { 330, 500, 294, 90, 330, 290, 294, 450, 262, 
                                  450, 330, 450, 222, 90, 222, 90, 222, 90, 222, 90 };
           
            for (int i = 0; i < partition.Length; i += 2)
            {
                Console.Beep(partition[i], partition[i + 1]);
                Thread.Sleep(15);
            }
           
        }

#endregion

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

    }
}