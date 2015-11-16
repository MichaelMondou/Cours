﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasseBrique
{
    // Les différents états du jeu
    public enum Etat { PAUSE, JOUE, PERDU };
    // Les différents bonus du jeu
    public enum Bonus { RIEN, MULTIBALLES };
    // Les différents niveaux du jeu        
    public enum Niveau { debutant, intermediaire, expert };

    public partial class Casse_Brique : Form
    {

        #region LES VARIABLES DU JEU : On déclare ici les variables nécessaires au bon fonctionnement du jeu

        // Tableau de blocs
        private Bloc[][] blocs;

        // Tableau de couleur des blocs
        private Image[] images_blocs;

        // Nombre de vie du joueur
        private int vies_joueur;

        // Score du joueur
        private int score;

        // Balle du jeu
        private Balle balle;

        // Balles du bonus Multi-balles
        private Balle balle2;
        private Balle balle3;

        // Barre du jeu
        private Barre barre;

        // Vitesse de la balle
        private int vitesse_balle;

        // Limite l'activation du bonus à une fois
        private bool bonus_activation = false;

        // L'état initial du jeu
        public Etat etat_du_jeu = Etat.PAUSE;

        // Le niveau initial du jeu
        public Niveau niveau_du_jeu = Niveau.debutant;

        // Bonus initial (il n'y en a pas)
        public Bonus bonus = Bonus.RIEN;

        #endregion

        #region FONCTIONS DE CONSTRUCTION : On met en place ici les différents éléments du casse brique

        public Casse_Brique()
        {
            InitializeComponent();

            miseEnPlaceDuBackground();

            miseEnPlaceDesCouleurs();
            miseEnPlaceDesBlocs();
            miseEnPlaceDeLaBalle();
            miseEnPlaceDuMultiBalles();
            miseEnPlaceDeLaBarre();

            vitesse_balle = Constantes.VITESSE_BALLE_DEBUTANT;
            vies_joueur = Constantes.NB_VIES;
            score = 0;
        }

        // Cette action sert à mettre en place l'image d'arrière-plan du jue parmi les fonds d'écran disponibles dans les ressources.
        public void miseEnPlaceDuBackground()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int x = rnd.Next(1, 4);
            switch (x)
            {
                case 1:
                    this.BackgroundImage = global::CasseBrique.Properties.Resources.background_1;
                    break;
                case 2:
                    this.BackgroundImage = global::CasseBrique.Properties.Resources.background_2;
                    break;
                case 3:
                    this.BackgroundImage = global::CasseBrique.Properties.Resources.background_3;
                    break;
            }
        }

        // Cette action sert à mettre en place les blocs du jeu
        public void miseEnPlaceDesBlocs()
        {

            blocs = new Bloc[Constantes.NB_BLOCS_LARGEUR][];

            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                blocs[i] = new Bloc[Constantes.NB_BLOCS_LARGEUR];

                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    this.blocs[i][j] = new Bloc(i, j, images_blocs[i]);
                    this.Controls.Add(this.blocs[i][j]);
                }
            }
        }

        // Cette action sert à mettre en place les couleurs à associer aux blocs
        public void miseEnPlaceDesCouleurs()
        {
            images_blocs = new Image[Constantes.NB_BLOCS_HAUTEUR];

            images_blocs[0] = global::CasseBrique.Properties.Resources.bloc_1;
            images_blocs[1] = global::CasseBrique.Properties.Resources.bloc_2;
            images_blocs[2] = global::CasseBrique.Properties.Resources.bloc_3;
            images_blocs[3] = global::CasseBrique.Properties.Resources.bloc_4;
            images_blocs[4] = global::CasseBrique.Properties.Resources.bloc_5;
        }

        public void miseEnPlaceDeLaBalle() // Cette action met en place la balle
        {
            balle = new Balle();
            this.Controls.Add(this.balle);
        }

        public void miseEnPlaceDuMultiBalles()
        {
            balle2 = new Balle();
            balle3 = new Balle();
            balle2.DeplacementX *= -1;
            balle3.DeplacementY *= 2;
            this.Controls.Add(this.balle2);
            this.Controls.Add(this.balle3);
            balle2.Visible = false;
            balle3.Visible = false;
        }

        public void miseEnPlaceDeLaBarre() // Cette action met en place la barre
        {
            barre = new Barre();
            this.Controls.Add(this.barre);
        }


        #endregion

        #region EVENEMENTS
        private void timer1_Tick(object sender, EventArgs e)
        {
            afficherLabels();
            jeuEnMarche();
            balle.toucherFenetre(this.Size.Width, this.Size.Height);
            balle.toucherBarre(this.barre);
            bonusActifs();
            sortieDeBalle();
            jeuEnPause();
            finDePartie();
        }
        #endregion

        #region GESTION DES EVENEMENTS

        public void reinitialisation()
        {
            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    blocs[i][j].Visible = true;
                }
            }
        }

        public void afficherLabels()
        {
            this.score_label.Text = "score : " + score;
            this.vies_label.Text = "vies : " + vies_joueur;
            this.niveau_label.Text = "niveau : " + niveau_du_jeu;
        }

        public void sortieDeBalle()
        {
            if (bonus == Bonus.MULTIBALLES)
            {
                if (balle.sortie() && balle2.sortie() && balle3.sortie())
                {
                    etat_du_jeu = Etat.PAUSE;
                    balle.initialisation();
                    vies_joueur--;
                    bonus = Bonus.RIEN;
                    bonus_activation = false;
                    balle2.Visible = false;
                    balle3.Visible = false;
                    miseEnPlaceDuMultiBalles();
                }
            }
            else if (balle.sortie())
            {
                etat_du_jeu = Etat.PAUSE;
                balle.initialisation();
                vies_joueur--;
            }
        }

        public void jeuEnPause()
        {
            if (etat_du_jeu == Etat.PAUSE)
            {
                this.etat_label.Visible = true;
                this.etat_label.Text = "pause";
                this.instructions_label.Text = "cliquez ou entrez pour jouer";
                this.fin_label.Visible = false;
            }
        }

        private void collisionBlocs(Balle b)
        {
            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    if (!b.ToucheBloc)    // Si la balle n'a pas encore touché de bloc
                    {
                        if (blocs[i][j].Visible)
                        {
                            if (niveau_du_jeu == Niveau.debutant)
                                score += b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.intermediaire)
                                score += 2 * b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.expert)
                                score += 3 * b.toucheDuBloc(blocs[i][j]);
                        }

                    }
                }
            }
            b.ToucheBloc = false;// fin de la phase de collision, toucheBloc est réinitialisé pour le prochain tour
        }

        public void jeuEnMarche()
        {
            if (etat_du_jeu == Etat.JOUE)
            {
                this.fin_label.Text = "score : " + score;
                this.etat_label.Visible = false;
                this.instructions_label.Text = "appuyez sur la touche echap pour mettre en pause";
                this.fin_label.Visible = false;
                for (int i = 0; i < vitesse_balle; i++)
                {
                    balle.bouger();
                    collisionBlocs(balle);
                }
            }
        }

        public void finDePartie()
        {
            if (vies_joueur == 0)
            {
                etat_du_jeu = Etat.PERDU;
            }

            if (etat_du_jeu == Etat.PERDU)
            {
                this.etat_label.Visible = false;
                this.fin_label.Visible = true;
                this.fin_label.Text = "fin de partie";
                this.instructions_label.Text = "appuyez sur la touche espace pour rejouer";
            }
        }

        public void bonusActifs()
        {
            if (bonus == Bonus.MULTIBALLES && etat_du_jeu == Etat.JOUE)
            {
                balle2.Visible = true;
                balle3.Visible = true;
                balle2.toucherFenetre(this.Size.Width, this.Size.Height);
                balle2.toucherBarre(this.barre);
                balle3.toucherFenetre(this.Size.Width, this.Size.Height);
                balle3.toucherBarre(this.barre);

                for (int i = 0; i < vitesse_balle; i++)
                {
                    balle2.bouger();
                    balle3.bouger();
                    collisionBlocs(balle2);
                    collisionBlocs(balle3);
                }
            }
        }

        #endregion

        #region INTERACTIONS AVEC LE JEU

        private void CasseBrique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                barre.deplacer(-1);
            if (e.KeyCode == Keys.Right)
                barre.deplacer(1);
            if (e.KeyCode == Keys.Escape)
            {
                etat_du_jeu = Etat.PAUSE;
            }
            if (e.KeyCode == Keys.Enter && etat_du_jeu != Etat.PERDU)
            {
                etat_du_jeu = Etat.JOUE;
            }
            if (e.KeyCode == Keys.Space && etat_du_jeu == Etat.PERDU)
            {
                balle.initialisation();
                barre.initialisation();
                reinitialisation();
                miseEnPlaceDesCouleurs();
                vies_joueur = Constantes.NB_VIES;
                score = 0;
                etat_du_jeu = Etat.JOUE;
            }

            if (e.KeyCode == Keys.M)
            {
                if (bonus_activation == false)
                {
                    bonus = Bonus.MULTIBALLES;
                    bonus_activation = true;
                }
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void débutantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.debutant;
            vitesse_balle = Constantes.VITESSE_BALLE_DEBUTANT;
            barre.Width = Constantes.LARGEUR_BARRE_DEBUTANT;
            barre.Height = Constantes.HAUTEUR_BARRE_DEBUTANT;
            barre.BackgroundImage = global::CasseBrique.Properties.Resources.raquette_debutant;
        }

        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.intermediaire;
            vitesse_balle = Constantes.VITESSE_BALLE_INTERMEDIAIRE;
            barre.Width = Constantes.LARGEUR_BARRE_DEBUTANT;
            barre.Height = Constantes.HAUTEUR_BARRE_DEBUTANT;
            barre.BackgroundImage = global::CasseBrique.Properties.Resources.raquette_debutant;
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.expert;
            vitesse_balle = Constantes.VITESSE_BALLE_INTERMEDIAIRE;
            barre.Width = Constantes.LARGEUR_BARRE_EXPERT;
            barre.Height = Constantes.HAUTEUR_BARRE_EXPERT;
            barre.BackgroundImage = global::CasseBrique.Properties.Resources.raquette_expert;
        }

        private void CasseBrique_MouseMove(object sender, MouseEventArgs souris)
        {
            int x;
            if (souris.X < 0)
                x = 0;
            else if (souris.X > Constantes.LARGEUR_ECRAN_JEU - barre.Width)
                x = Constantes.LARGEUR_ECRAN_JEU - barre.Width;
            else x = souris.X;
            barre.Location = new System.Drawing.Point(x, barre.Location.Y);
        }

        private void CasseBrique_MouseClick(object sender, MouseEventArgs e)
        {
            if (etat_du_jeu == Etat.PAUSE)
                etat_du_jeu = Etat.JOUE;
        }

        #endregion
    }
}
