using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_JPO
{
    // Les différents états du jeu
    public enum Etat { PAUSE, JOUE, PERDU };

    public enum Bonus { RIEN, MULTIBALLES };
    // Les différents niveaux du jeu        
    public enum Niveau { DEBUTANT, INTERMEDIAIRE, EXPERT };

    public partial class JPO : Form
    {
        #region LES VARIABLES DU JEU : On déclare ici les variables nécessaires au bon fonctionnement du jeu

        private Bloc[][] blocs;                                         // Tableau de blocs
        private Color[] couleurs;                                       // Tableau de couleur des blocs
        private int vies_joueur;                                        // Nombre de vie du joueur
        private int score;                                              // Score du joueur

        private Balle balle;                                            // La balle du jeu

        private Balle balle2;                                           // La balle du bonus multiballes
        private Balle balle3;                                           // La deuxième balle du bonus multiballe

        private Barre barre;                                            // La barre du jeu

        private bool bonus_activation = false;                          // Limite l'activation du bonus à une fois

        public Etat etat_du_jeu = Etat.PAUSE;                           // L'état initial du jeu
        public Niveau niveau_du_jeu = Niveau.DEBUTANT;                  // Le niveau initial du jeu
        public Bonus bonus;

        #endregion

        #region FONCTIONS DE CONSTRUCTION : On met en place ici les différents éléments du casse brique

        public JPO()
        {
            InitializeComponent();

            miseEnPlaceDesCouleurs();
            miseEnPlaceDesBlocs();
            miseEnPlaceDeLaBalle();
            miseEnPlaceDuMultiBalles();
            miseEnPlaceDeLaBarre();

            vies_joueur = Constantes.NB_VIES;
            score = 0;
        }

        public void miseEnPlaceDesBlocs()  // Cette action met en place les blocs
        {
            System.ComponentModel.ComponentResourceManager ressources = new System.ComponentModel.ComponentResourceManager(typeof(JPO));

            blocs = new Bloc[Constantes.NB_BLOCS_LARGEUR][];

            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                blocs[i] = new Bloc[Constantes.NB_BLOCS_LARGEUR];

                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    this.blocs[i][j] = new Bloc(i, j, couleurs[i], ressources);
                    this.blocs[i][j].BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(this.blocs[i][j]);
                }
            }
        }

        public void miseEnPlaceDesCouleurs() // Cette action met en place les couleurs à associer aux blocs
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            couleurs = new Color[Constantes.NB_BLOCS_HAUTEUR];

            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
            {
                couleurs[i] = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }
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
            this.label1.Text = "Score : " + score;
            this.label4.Text = "Vies : " + vies_joueur;
        }

        public void sortieDeBalle()
        {
            if (bonus == Bonus.MULTIBALLES)
            {
                if (balle.sortie() && balle2.sortie() && balle3.sortie())
                {
                    etat_du_jeu = Etat.PAUSE;
                    balle.initialisation();
                    balle.miseAJourNiveau(niveau_du_jeu);
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
                balle.miseAJourNiveau(niveau_du_jeu);
                vies_joueur--;
            }
        }

        public void jeuEnPause()
        {
            if (etat_du_jeu == Etat.PAUSE)
            {
                this.label2.Visible = true;
                this.label2.Text = "PAUSE";
                this.label3.Text = "Cliquez ou entrez pour jouer";
                this.label5.Visible = false;
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
                            if (niveau_du_jeu == Niveau.DEBUTANT)
                                score += b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.INTERMEDIAIRE)
                                score += 2 * b.toucheDuBloc(blocs[i][j]);
                            else if (niveau_du_jeu == Niveau.EXPERT)
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
                this.label1.Text = "Score : " + score;
                this.label2.Visible = false;
                this.label3.Text = "Appuyez sur la touche Echap pour mettre en pause";
                this.label5.Visible = false;
                balle.bouger();

                collisionBlocs(balle);
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
                this.label5.Visible = true;
                this.label5.Text = "FIN DE PARTIE";
                this.label3.Text = "Appuyez sur la touche Espace pour rejouer";
            }
        }

        public void bonusActifs()
        {
            if (bonus == Bonus.MULTIBALLES && etat_du_jeu == Etat.JOUE)
            {
                balle2.Visible = true;
                balle3.Visible = true;
                balle2.bouger();
                balle3.bouger();
                balle2.toucherFenetre(this.Size.Width, this.Size.Height);
                balle2.toucherBarre(this.barre);
                balle3.toucherFenetre(this.Size.Width, this.Size.Height);
                balle3.toucherBarre(this.barre);

                collisionBlocs(balle2);
                collisionBlocs(balle3);
            }

        }

        #endregion

        #region INTERACTIONS AVEC LE JEU

        private void JPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                barre.deplacer(-1);
            if (e.KeyCode == Keys.Right)
                barre.deplacer(1);
            if (e.KeyCode == Keys.Escape)
            {
                etat_du_jeu = Etat.PAUSE;
            }
            if (e.KeyCode == Keys.Enter)
            {
                etat_du_jeu = Etat.JOUE;
            }
            if (e.KeyCode == Keys.Space && etat_du_jeu == Etat.PERDU)
            {
                balle.initialisation();
                balle.miseAJourNiveau(niveau_du_jeu);
                barre.initialisation();
                reinitialisation();
                miseEnPlaceDesCouleurs();
                vies_joueur = Constantes.NB_VIES;
                score = 0;
                etat_du_jeu = Etat.JOUE;
            }

            if (e.KeyCode == Keys.P)
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
            niveau_du_jeu = Niveau.DEBUTANT;
            balle.miseAJourNiveau(niveau_du_jeu);
            balle2.miseAJourNiveau(niveau_du_jeu);
            balle3.miseAJourNiveau(niveau_du_jeu);
            barre.miseAJourNiveau(niveau_du_jeu);
        }

        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.INTERMEDIAIRE;
            balle.miseAJourNiveau(niveau_du_jeu);
            balle2.miseAJourNiveau(niveau_du_jeu);
            balle3.miseAJourNiveau(niveau_du_jeu);
            barre.miseAJourNiveau(niveau_du_jeu);
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.EXPERT;
            balle.miseAJourNiveau(niveau_du_jeu);
            balle2.miseAJourNiveau(niveau_du_jeu);
            balle3.miseAJourNiveau(niveau_du_jeu);
            barre.miseAJourNiveau(niveau_du_jeu);
        }

        private void JPO_MouseMove(object sender, MouseEventArgs souris)
        {
            //Il faut donc déplacer la barre en fonction de la position de la souris
            int moitie = barre.Size.Width / 2;
            barre.Location = new System.Drawing.Point(souris.X - moitie, barre.Location.Y);
        }

        private void JPO_MouseClick(object sender, MouseEventArgs e)
        {
            if(etat_du_jeu == Etat.PAUSE)
                etat_du_jeu = Etat.JOUE;
        }

        #endregion
    }
}