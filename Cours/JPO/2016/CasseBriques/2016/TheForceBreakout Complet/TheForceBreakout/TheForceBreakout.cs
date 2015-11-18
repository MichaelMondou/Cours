using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TheForceBreakout
{
    // Les différents états du jeu
    public enum Etat { PAUSE, JOUE, PERDU, GAGNE };
    // Les différents bonus du jeu
    public enum Bonus { RIEN, MULTIBALLES };
    // Les différents niveaux du jeu        
    public enum Niveau { begginner, medium, expert };

    public partial class TheForceBreakout : Form
    {

        #region LES VARIABLES DU JEU : On déclare ici les variables nécessaires au bon fonctionnement du jeu

        // Tableau de blocs
        private Bloc[][] blocs;

        // Nombre de blocs
        private int nb_blocs;

        // Nombre de blocs touchés par la balle
        private int nb_blocs_touches;

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

        // Musique du jeu
        private SoundPlayer musique_fond;

        // Sert à savoir si la chanson est lancée ou non
        private bool play;

        // L'état initial du jeu
        public Etat etat_du_jeu = Etat.PAUSE;

        // Le niveau initial du jeu
        public Niveau niveau_du_jeu = Niveau.begginner;

        // Bonus initial (il n'y en a pas)
        public Bonus bonus = Bonus.RIEN;

        #endregion

        #region FONCTIONS DE CONSTRUCTION : On met en place ici les différents éléments du casse brique

        public TheForceBreakout()
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
            nb_blocs = Constantes.NB_BLOCS_HAUTEUR * Constantes.NB_BLOCS_LARGEUR;
            nb_blocs_touches = 0;

            musique_fond = new SoundPlayer(global::TheForceBreakout.Properties.Resources.StarWars_Theme);
            musique_fond.Play();
            play = true;
        }

        // Cette action sert à mettre en place l'image d'arrière-plan du jue parmi les fonds d'écran disponibles dans les ressources.
        public void miseEnPlaceDuBackground()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int x = rnd.Next(1, 4);
            switch (x)
            {
                case 1:
                    this.BackgroundImage = global::TheForceBreakout.Properties.Resources.background_1;
                    break;
                case 2:
                    this.BackgroundImage = global::TheForceBreakout.Properties.Resources.background_2;
                    break;
                case 3:
                    this.BackgroundImage = global::TheForceBreakout.Properties.Resources.background_3;
                    break;
            }
        }

        // Cette action sert à mettre en place les blocs du jeu
        public void miseEnPlaceDesBlocs()
        {

            blocs = new Bloc[Constantes.NB_BLOCS_HAUTEUR][];

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

            Image[] images = new Image[5];

            int j = 0;

            images[0] = global::TheForceBreakout.Properties.Resources.bloc_1;
            images[1] = global::TheForceBreakout.Properties.Resources.bloc_2;
            images[2] = global::TheForceBreakout.Properties.Resources.bloc_3;
            images[3] = global::TheForceBreakout.Properties.Resources.bloc_4;
            images[4] = global::TheForceBreakout.Properties.Resources.bloc_5;

            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                if (j == 5)
                    j = 0;
                images_blocs[i] = images[j];
                j++;
            }
        }

        // Cette action sert à mettre en place la balle
        public void miseEnPlaceDeLaBalle()
        {
            balle = new Balle();
            this.Controls.Add(this.balle);
        }

        // Cette action sert à mettre en place le multi-balles
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

        // Cette action sert à mettre en place la barre
        public void miseEnPlaceDeLaBarre()
        {
            barre = new Barre();
            this.Controls.Add(this.barre);
        }


        #endregion

        #region EVENEMENTS : On appelle les différents événements du jeu
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

        #region GESTION DES EVENEMENTS : On gère les différents événements du jeu

        // Cette action permet d'afficher les labels dynamiquement
        public void afficherLabels()
        {
            this.score_label.Text = "score : " + score;
            this.vies_label.Text = "lifes : " + vies_joueur;
            this.niveau_label.Text = "level : " + niveau_du_jeu;
        }

        // Cette action permet de savoir si la (ou les) balle(s) est (sont) sortie(s)
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

        // Cette action permet de détecter si la balle est en collision avec un bloc
        private void collisionBlocs(Balle b)
        {
            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    // Si la balle n'a pas encore touché de bloc
                    if (!b.ToucheBloc)
                    {
                        if (blocs[i][j].Visible)
                        {
                            if (niveau_du_jeu == Niveau.begginner)
                                score += b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.medium)
                                score += 2 * b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.expert)
                                score += 3 * b.toucheDuBloc(blocs[i][j]);
                        }
                        if (b.ToucheBloc)
                        {
                            nb_blocs_touches++;
                        }

                    }
                }
            }
            // Fin de la phase de collision, toucheBloc est réinitialisé pour le prochain tour
            b.ToucheBloc = false;
        }

        // Cette action permet d'afficher ce qu'il faut lorsque le jeu est en état de pause
        public void jeuEnPause()
        {
            if (etat_du_jeu == Etat.PAUSE)
            {
                this.etat_label.Visible = true;
                this.etat_label.Text = "pause";
                this.instructions_label.Text = "click or enter to play";
                this.fin_label.Visible = false;
            }
        }

        // Cette action permet d'afficher ce qu'il faut lorsque le jeu est en état de marche
        public void jeuEnMarche()
        {
            if (etat_du_jeu == Etat.JOUE)
            {
                this.fin_label.Text = "score : " + score;
                this.etat_label.Text = "in game";
                this.instructions_label.Text = "press escape to pause";
                for (int i = 0; i < vitesse_balle; i++)
                {
                    balle.bouger();
                    collisionBlocs(balle);
                }
            }
        }

        // Cette action permet d'afficher ce qu'il faut lorsque la partie est finie
        public void finDePartie()
        {
            if (vies_joueur == 0)
            {
                etat_du_jeu = Etat.PERDU;
            }

            if (nb_blocs_touches == nb_blocs)
            {
                etat_du_jeu = Etat.GAGNE;
            }

            if (etat_du_jeu == Etat.PERDU)
            {
                this.etat_label.Visible = false;
                this.fin_label.Visible = true;
                this.fin_label.Text = "game over";
                this.victoire_label.Visible = true;
                this.victoire_label.Text = "you don't know the power \n       of the darkside";
                this.instructions_label.Text = "press space to replay";
            }

            if (etat_du_jeu == Etat.GAGNE)
            {
                this.etat_label.Visible = false;
                this.victoire_label.Visible = true;
                this.victoire_label.Text = "the force is strong with you";
                this.instructions_label.Text = "press space to replay";
            }
        }

        // Cette action permet de réinitialiser les blocs du jeu
        public void reinitialisation()
        {
            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    blocs[i][j].Visible = true;
                }
            }
            nb_blocs_touches = 0;
        }

        // Cette action permet d'exécuter le bonus du multi-balles
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

        #region INTERACTIONS AVEC LE JEU : On gère les intéractions Clavier / Souris / Joueur

        //Cette action permet de détecter les événements clavier
        private void TheForceBreakout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                etat_du_jeu = Etat.PAUSE;
            }
            if (e.KeyCode == Keys.Enter && etat_du_jeu != Etat.PERDU)
            {
                etat_du_jeu = Etat.JOUE;
            }
            if (e.KeyCode == Keys.Space && (etat_du_jeu == Etat.PERDU || etat_du_jeu == Etat.GAGNE))
            {
                balle.initialisation();
                barre.initialisation();
                reinitialisation();
                miseEnPlaceDesCouleurs();
                vies_joueur = Constantes.NB_VIES;
                score = 0;
                this.fin_label.Visible = false;
                this.victoire_label.Visible = false;
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

        // Cette action permet de détecter l'appuie de la touche quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cette action permet de détecter l'appuie de la touche Débutant
        private void débutantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.begginner;
            vitesse_balle = Constantes.VITESSE_BALLE_DEBUTANT;
            barre.Width = Constantes.LARGEUR_BARRE;
            barre.Height = Constantes.HAUTEUR_BARRE;
        }

        // Cette action permet de détecter l'appuie de la touche Intermédiaire
        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.medium;
            vitesse_balle = Constantes.VITESSE_BALLE_INTERMEDIAIRE;
            barre.Width = Constantes.LARGEUR_BARRE;
            barre.Height = Constantes.HAUTEUR_BARRE;
        }

        // Cette action permet de détecter l'appuie de la touche Expert
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.expert;
            vitesse_balle = Constantes.VITESSE_BALLE_INTERMEDIAIRE;
            barre.Width = Constantes.LARGEUR_BARRE / 2;
            barre.Height = Constantes.HAUTEUR_BARRE / 2;
        }

        // Cette action permet de bouger la raquette en fonction du mouvement de la souris
        private void TheForceBreakout_MouseMove(object sender, MouseEventArgs souris)
        {
            int x;
            if (souris.X < barre.Width / 2)
                x = 0;
            else if (souris.X > Constantes.LARGEUR_ECRAN_JEU - barre.Width / 2)
                x = Constantes.LARGEUR_ECRAN_JEU - barre.Width;
            else x = souris.X - barre.Width / 2;
            barre.Location = new System.Drawing.Point(x, barre.Location.Y);
        }

        // Cette action permet de détecter le click de la souris et de commencer ainsi la partie
        private void TheForceBreakout_MouseClick(object sender, MouseEventArgs e)
        {
            if (etat_du_jeu == Etat.PAUSE)
                etat_du_jeu = Etat.JOUE;
        }

        // Cette action permet d'activer ou non la chanson du jeu
        private void sound_button_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                musique_fond.Stop();
                sound_button.BackgroundImage = global::TheForceBreakout.Properties.Resources.haut_parleur_2;
                play = false;
            }
            else
            {
                musique_fond.Play();
                sound_button.BackgroundImage = global::TheForceBreakout.Properties.Resources.haut_parleur;
                play = true;
            }
        }

        #endregion
    }
}
