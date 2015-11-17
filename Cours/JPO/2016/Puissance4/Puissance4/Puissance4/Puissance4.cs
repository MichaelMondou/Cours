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
    public partial class Puissance4 : Form
    {
        private bool clicEffectue = false;

        private Grille grille;
        private Jeton jeton;//Jeton que l'on déplace en haut de la grille
        private Point[] jetons_gagnants;

        //Nombre de victoire des joueurs
        private int joueurdarkVador = 0;
        private int joueurluke = 0;

        //Nombre d'utiliations de bombes restantes de chaque joueur
        private int bombesVadorRestantes = 1;
        private int bombeslukeRestantes = 1;

        public enum Joueurs { darkVador, luke, bombeVador, bombeLuke };
        private Joueurs joueur = Joueurs.darkVador;//Nom du joueur qui doit jouer

        private int nbJetons = 0;//Nombre de jeton posés

        public Puissance4()
        {
            #region Puissance4
            InitializeComponent();

            ClientSize = new System.Drawing.Size(Constantes.WIDTH - 6, Constantes.HEIGHT + Constantes.SIZE_H + Constantes.MARGIN_TOP + Constantes.MARGIN_BOTTOM - 6);

            this.grille = new Grille();
            this.jeton = new Jeton(joueur.ToString(), Constantes.WIDTH / 2 - Constantes.SIZE_W / 2, 0);
            #endregion

            toolStripStatusLabel1.Text = "Dark Vador : 0";
            toolStripStatusLabel2.Text = "Luke : 0";

            Refresh();     
        }

        private void init()
        {
            grille.init();

            joueur = Joueurs.darkVador;

            jeton.setCouleur(joueur.ToString());
            jetons_gagnants = null;

            nbJetons = 0;
			bombesVadorRestantes = 1;
			bombeslukeRestantes = 1;

            Refresh();
        }

        private void Puissance4_Paint(object sender, PaintEventArgs e)
        {
            // On affiche des carrés bleux en haut de la fenêtre
            afficherLigneHaut(e);

            // On affiche le jeton s'il se déplace et la grille
            jeton.dessiner(e.Graphics);
            grille.dessiner(e.Graphics);

            // Si un clic de souris est détecté, on affiche des carrés au dessus du jeton pour avoir un aspect visuel plus sympathique
            if (clicEffectue)
            {
                afficherLigneHaut(e);
            }

            if (jetons_gagnants != null)
            {
                Jeton.dessinerTrait(e.Graphics, jetons_gagnants);
            }
        }

        private void afficherLigneHaut(PaintEventArgs e)
        {
            for (int x = 0; x < Constantes.NB_COLS; x++)
            {
                e.Graphics.DrawImage(Properties.Resources.casePleine, new Rectangle(x * Constantes.SIZE_W, Constantes.MARGIN_TOP, Constantes.SIZE_W, Constantes.SIZE_H));
            }
        }

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
                joueurdarkVador = 0;
                joueurluke = 0;
                toolStripStatusLabel1.Text = "Dark Vador : 0";
                toolStripStatusLabel2.Text = "Luke : 0";
                init();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Apropos about = new Apropos();
            about.ShowDialog();
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

            if (joueur == Joueurs.bombeVador || joueur == Joueurs.bombeLuke)
            {
                Refresh();
                System.Threading.Thread.Sleep(100);

                if (j + 1 <= Constantes.NB_ROWS)
                {
                    grille[i, j+1].setCouleur(null);
                }

                switch (joueur)
                {
                    case Joueurs.bombeVador:
                        joueur = Joueurs.darkVador;
                        break;
                    case Joueurs.bombeLuke:
                        joueur = Joueurs.luke;
                        break;
                }
            }
            else
            {
                grille[i, j].setCouleur(jeton.getCouleur());
                jetons_gagnants = grille.jetonGagnant(i, j);
            }

            Puissance4_MouseMove(sender, (MouseEventArgs)e);
            jeton.inverserCouleur();

            Refresh();
            #endregion

            if (jetons_gagnants != null)
            {
                Refresh();//Permet d'afficher quels jetons sont gagnants

                if (joueur == Joueurs.darkVador)
                {
                    joueurdarkVador++;
                    toolStripStatusLabel1.Text = "Dark Vador : " + joueurdarkVador.ToString();
                    MessageBox.Show("Partie finie !\nVictoire du joueur Dark Vador");
                }
                else if (joueur == Joueurs.luke)
                {
                    joueurluke++;
                    toolStripStatusLabel2.Text = "Luke Skywalker : " + joueurluke.ToString();
                    MessageBox.Show("Partie finie !\nVictoire du joueur Luke Skywalker");
                }

                init();
            }
            else if (++nbJetons == Constantes.NB_COLS * Constantes.NB_ROWS)
            {
                MessageBox.Show("Egalité !");
                joueurdarkVador++;
                joueurluke++;
                toolStripStatusLabel1.Text = "Dark Vador : " + joueurdarkVador.ToString();
                toolStripStatusLabel2.Text = "Luke Skywalker : " + joueurluke.ToString();

                init();
            }
            else
            {
                if (joueur == Joueurs.darkVador)
                {
                    joueur = Joueurs.luke;
                }
                else if (joueur == Joueurs.luke)
                {
                    joueur = Joueurs.darkVador;
                }
            }
            clicEffectue = false;
        }

        private void Puissance4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'b' || e.KeyChar == 'B')
            {
                if(joueur == Joueurs.darkVador && bombesVadorRestantes > 0)
				{
                    bombesVadorRestantes--;
                    joueur = Joueurs.bombeVador;
					jeton = new Jeton(joueur.ToString(), jeton.getPosition().X, jeton.getPosition().Y);
                }
                else if (joueur == Joueurs.luke && bombeslukeRestantes > 0)
                {
                    bombeslukeRestantes--;
                    joueur =  Joueurs.bombeLuke;
					jeton = new Jeton(joueur.ToString(), jeton.getPosition().X, jeton.getPosition().Y);
                }
				Refresh();
            }
        }
    }
}
