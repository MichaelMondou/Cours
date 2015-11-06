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
    public enum Etat { PAUSE, JOUE, PERDU };                               // Les différents états du jeu
    public enum Niveau { DEBUTANT, INTERMEDIAIRE, EXPERT };         // Les différents états du jeu
    public partial class JPO : Form
    {

        #region LES VARIABLES DU JEUX : On déclare ici les variables nécessaires au bon fonctionnement du jeu

        private Bloc[][] blocs;                                         // Tableau de blocs
        private Color[] couleurs;                                       // Tableau de couleur des blocs
        private int vies_joueur;                                        // Nombre de vie du joueur
        private int score;                                              // Score du joueur

        private Balle balle;                                            // La balle du jeu

        private Barre barre;                                            // La barre du jeu

        public Etat etat_du_jeu = Etat.PAUSE;                           // L'état initial du jeu
        public Niveau niveau_du_jeu = Niveau.DEBUTANT;                  // L'état initial du jeu

        #endregion

        #region FONCTIONS DE CONSTRUCTION

        public JPO()
        {
            InitializeComponent();

            miseEnPlaceDesCouleurs();
            miseEnPlaceDesBlocs();
            miseEnPlaceDeLaBalle();
            miseEnPlaceDeLaBarre();

            vies_joueur = Constantes.NB_VIES;
            score = 0;
        }

        public void miseEnPlaceDesBlocs()  // Cette fonction met en place les blocs
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

        public void miseEnPlaceDeLaBalle()
        {
            balle = new Balle();
            this.Controls.Add(this.balle);
        }

        public void miseEnPlaceDeLaBarre()
        {
            barre = new Barre();
            this.Controls.Add(this.barre);
        }


        #endregion

        public void afficherLabels()
        {
            this.label1.Text = "Score : " + score;
            this.label4.Text = "Vies : " + vies_joueur;
        }

        public void sortieDeBalle()
        {
            if (balle.sortie())
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
                this.label2.Visible = true;
                this.label2.Text = "PAUSE";
                this.label3.Text = "Appuyez sur la touche Entrée pour jouer";
                this.label5.Visible = false;
            }
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

                #region Bloc touché par la balle

                for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
                    for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                    {
                        if (!balle.ToucheBloc)    // Si la balle n'a pas encore touché de bloc
                        {
                            if (blocs[i][j].Visible)
                            {
                                if (niveau_du_jeu == Niveau.DEBUTANT)
                                    score += balle.toucheDuBloc(blocs[i][j]);
                                else if (niveau_du_jeu == Niveau.INTERMEDIAIRE)
                                    score += 2 * balle.toucheDuBloc(blocs[i][j]);
                                else if (niveau_du_jeu == Niveau.EXPERT)
                                    score += 3 * balle.toucheDuBloc(blocs[i][j]);
                            }

                        }
                    }
                balle.ToucheBloc = false;// fin de la phase de collision, toucheBloc est réinitialisé pour le prochain tour
            }
                #endregion
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

        #region GESTION DES EVENEMENTS
        private void timer1_Tick(object sender, EventArgs e)
        {
            afficherLabels();
            jeuEnMarche();
            balle.toucherFenetre(this.Size.Width, this.Size.Height);
            balle.toucherBarre(this.barre);
            sortieDeBalle();
            jeuEnPause();
            finDePartie();
        }
        #endregion

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
                barre.initialisation();
                miseEnPlaceDesBlocs();
                miseEnPlaceDesCouleurs();
                vies_joueur = Constantes.NB_VIES;
                score = 0;
                etat_du_jeu = Etat.JOUE;

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
            barre.miseAJourNiveau(niveau_du_jeu);
        }

        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.INTERMEDIAIRE;
            balle.miseAJourNiveau(niveau_du_jeu);
            barre.miseAJourNiveau(niveau_du_jeu);
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            niveau_du_jeu = Niveau.EXPERT;
            balle.miseAJourNiveau(niveau_du_jeu);
            barre.miseAJourNiveau(niveau_du_jeu);
        }
    }
}