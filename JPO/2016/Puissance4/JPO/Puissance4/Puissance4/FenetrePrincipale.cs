using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class FenetrePrincipale : Form
    {
        #region VARIABLES DU JEU
        // Le joueur a effectue un clic
        private bool clicEffectue = false;

        private Grille grille;
        private Jeton jeton;//Jeton que l'on déplace en haut de la grille
        private Point[] jetonsGagnants;

        //Nombre de victoire des joueurs
        private int joueurdarkVador;
        private int joueurluke;

        //Nombre d'utiliations de bombes restantes de chaque joueur
        private int bombesVadorRestantes = Constantes.NB_BOMBES;
		private int bombeslukeRestantes = Constantes.NB_BOMBES;

        private int nbJetons;
        private static int numeroJoueurQuiCommence = 0;
        #endregion

        #region FONCTION DE CONSTRUCTION : On déclare ici les fonction 
        public FenetrePrincipale()
        {
            InitializeComponent();

            ClientSize = new System.Drawing.Size(Constantes.WIDTH - 6, Constantes.HEIGHT + Constantes.SIZE_H + Constantes.MARGIN_TOP + Constantes.MARGIN_BOTTOM - 6);
            this.grille = new Grille();
            this.jeton = new Jeton(Constantes.WIDTH / 2 - Constantes.SIZE_W / 2, 0);
            initBarreScores();
            initManche();

            Refresh();
        }

        // Cette action initialise la partie (lorsque le jeu se lance ou lorsqu'on clique sur "Nouvelle partie")
        private void initManche()
        {
            jetonsGagnants = null;
            string joueur;

            if (numeroJoueurQuiCommence == 0)
            {
                joueur = "darkVador"; // Nom du joueur qui doit commencer
            }
            else
            {
                joueur = "luke";
            }
            numeroJoueurQuiCommence++;
            if (numeroJoueurQuiCommence > 1)
            {
                numeroJoueurQuiCommence = 0;
            }

            jeton.setNomJoueur(joueur);
            grille.init();
            nbJetons = 0;
        }

        // Cette action remet à zéro la barre des scores
        private void initBarreScores()
        {
            toolStripStatusLabel1.Text = "Dark Vador : 0";
            toolStripStatusLabel2.Text = "Luke : 0";
        }

        private void resetPartie()
        {
            joueurdarkVador = 0;
            joueurluke = 0;
            bombesVadorRestantes = Constantes.NB_BOMBES;
            bombeslukeRestantes = Constantes.NB_BOMBES;
            initManche();
            initBarreScores();
        }

        private void Puissance4_Paint(object sender, PaintEventArgs e)
        {
            // On affiche des carrés bleux en haut de la fenêtre
            Grille.dessinerLigneHaut(e);

            // On affiche le jeton s'il se déplace et la grille
            jeton.dessiner(e.Graphics);
            grille.dessiner(e.Graphics);

            // Si un clic de souris est détecté, on affiche des carrés au dessus du jeton pour avoir un aspect visuel plus sympathique
            if (clicEffectue)
            {
                Grille.dessinerLigneHaut(e);
            }

            if (jetonsGagnants != null)
            {
                Jeton.dessinerTrait(e.Graphics, jetonsGagnants);
            }
        }

        private void gestionBonus()
        {
            if (jeton.getNomJoueur() == "darkVador" && bombesVadorRestantes > 0)
            {
                bombesVadorRestantes--;
                jeton.setNomJoueur("bombeVador");
            }
            else if (jeton.getNomJoueur() == "luke" && bombeslukeRestantes > 0)
            {
                bombeslukeRestantes--;
                jeton.setNomJoueur("bombeLuke");
            }
            Refresh();
        }

        private void gestionClic(object sender, MouseEventArgs e)
        {
            clicEffectue = true;

            #region MouseCLick
            int i = ((MouseEventArgs)e).X / Constantes.SIZE_W;

            if (i >= Constantes.NB_COLS)
            {
                i = Constantes.NB_COLS - 1;
            }

            if (grille[i, 0].getNomJoueur() != null)
            {
                return;
            }
            int j = grille.ligneInsertion(i);
            int y = 0;

            while (y <= Constantes.HEIGHT - (Constantes.NB_ROWS - j - 1) * Constantes.SIZE_H)
            {
                jeton.setPositionY(y);
                y++;

                if (y % Constantes.SPEED == 0)
                {
                    Refresh();
                }
            }

            if (jeton.getNomJoueur() == "bombeVador" || jeton.getNomJoueur() == "bombeLuke")
            {
                Refresh();
                System.Threading.Thread.Sleep(100);

                if (j + 1 <= Constantes.NB_ROWS)
                {
                    switch (jeton.getNomJoueur())
                    {
                        case "bombeVador":
                            grille[i, j + 1].setNomJoueur("darkVador");
                            break;
                        case "bombeLuke":
                            grille[i, j + 1].setNomJoueur("luke");
                            break;
                    }
                }
                // On teste si le jeton remplacé fait gagner le joueur
                jetonsGagnants = grille.jetonGagnant(i, j + 1);
            }
            else
            {
                grille[i, j].setNomJoueur(jeton.getNomJoueur());
                jetonsGagnants = grille.jetonGagnant(i, j);
            }
            #endregion

            Puissance4_MouseMove(sender, (MouseEventArgs)e);

            Refresh();

            if (jetonsGagnants != null)
            {
                Refresh();//Permet d'afficher quels jetons sont gagnants

                if (jeton.getNomJoueur() == "darkVador")
                {
                    joueurdarkVador++;
                    toolStripStatusLabel1.Text = "Dark Vador : " + joueurdarkVador.ToString();
                    MessageBox.Show("Manche terminée !\nVictoire du joueur Dark Vador");
                }
                else if (jeton.getNomJoueur() == "luke")
                {
                    joueurluke++;
                    toolStripStatusLabel2.Text = "Luke Skywalker : " + joueurluke.ToString();
                    MessageBox.Show("Manche terminée !\nVictoire du joueur Luke Skywalker");
                }

                initManche();
            }
            else if (++nbJetons == Constantes.NB_COLS * Constantes.NB_ROWS)
            {
                MessageBox.Show("Egalité !");
                joueurdarkVador++;
                joueurluke++;
                toolStripStatusLabel1.Text = "Dark Vador : " + joueurdarkVador.ToString();
                toolStripStatusLabel2.Text = "Luke Skywalker : " + joueurluke.ToString();

                initManche();
            }
            else
            {
                jeton.joueurSuivant();
            }
            clicEffectue = false;
        }
        #endregion

        #region GESTION DES EVENEMENTS : On déclare ici les fonction gérant les évènements (clics, mouvement de souris, appui sur des touches du clavier)
        private void Puissance4_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (e.X / Constantes.SIZE_W) * Constantes.SIZE_W;

            if (x < 0)
            {
                x = 0;
            }
            else if (x > Constantes.WIDTH - Constantes.SIZE_W)
            {
                x = Constantes.WIDTH - Constantes.SIZE_W;
            }

            jeton.setPotision(x, 0);
            Refresh();
        }

        private void FenetrePrincipale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'b' || e.KeyChar == 'B')
            {
                // Code du bonus
            }
        }
        #endregion
    }
}