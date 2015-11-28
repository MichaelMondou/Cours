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

		private string joueur;
        private int nbJetons;
        #endregion

        #region FONCTION DE CONSTRUCTION : On déclare ici les fonction 
        public FenetrePrincipale()
        {
            #region Puissance4
            InitializeComponent();

            ClientSize = new System.Drawing.Size(Constantes.WIDTH - 6, Constantes.HEIGHT + Constantes.SIZE_H + Constantes.MARGIN_TOP + Constantes.MARGIN_BOTTOM - 6);

            this.grille = new Grille();
            this.jeton = new Jeton(joueur, Constantes.WIDTH / 2 - Constantes.SIZE_W / 2, 0);
            #endregion

            initBarreScores();
            initManche();
            Refresh();
        }

        // Cette action initialise la partie (lorsque le jeu se lance ou lorsqu'on clique sur "Nouvelle partie")
        private void initManche()
        {
            jetonsGagnants = null;
            joueur = "darkVador"; // Nom du joueur qui doit commencer
            jeton.setCouleur(joueur);
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

        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous commencer une nouvelle partie ?", "Nouvelle partie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resetPartie();
            }
        }

        private void Puissance4_MouseClick(object sender, MouseEventArgs e)
        {
            clicEffectue = true;

            #region MouseCLick
            int i = ((MouseEventArgs)e).X / Constantes.SIZE_W;

            if (i >= Constantes.NB_COLS)
            {
                i = Constantes.NB_COLS - 1;
            }

            if (grille[i, 0].getCouleur() != null)
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

            if (joueur == "bombeVador" || joueur == "bombeLuke")
            {
                Refresh();
                System.Threading.Thread.Sleep(100);

                if (j + 1 <= Constantes.NB_ROWS)
                {
					switch (joueur)
					{
						case "bombeVador":
							grille[i, j + 1].setCouleur("darkVador");
							break;
						case "bombeLuke":
							grille[i, j + 1].setCouleur("luke");
							break;
					}
                }

                switch (joueur)
                {
                    case "bombeVador":
                        joueur = "darkVador";
                        break;
                    case "bombeLuke":
                        joueur = "luke";
                        break;
                }
				// On teste si le jeton remplacé fait gagner le joueur
				jetonsGagnants = grille.jetonGagnant(i, j+1);
            }
            else
            {
                grille[i, j].setCouleur(jeton.getCouleur());
				jetonsGagnants = grille.jetonGagnant(i, j);
            }

            Puissance4_MouseMove(sender, (MouseEventArgs)e);
            jeton.inverserCouleur();

            Refresh();
            #endregion

            if (jetonsGagnants != null)
            {
                Refresh();//Permet d'afficher quels jetons sont gagnants

                if (joueur == "darkVador")
                {
                    joueurdarkVador++;
                    toolStripStatusLabel1.Text = "Dark Vador : " + joueurdarkVador.ToString();
                    MessageBox.Show("Partie finie !\nVictoire du joueur Dark Vador");
                }
                else if (joueur == "luke")
                {
                    joueurluke++;
                    toolStripStatusLabel2.Text = "Luke Skywalker : " + joueurluke.ToString();
                    MessageBox.Show("Partie finie !\nVictoire du joueur Luke Skywalker");
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
                if (joueur == "darkVador")
                {
                    joueur = "luke";
                }
                else if (joueur == "luke")
                {
                    joueur = "darkVador";
                }
            }
            clicEffectue = false;
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
