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
        public static int SIZE_W = 97;
        public static int SIZE_H = 97;

        public static int NB_COLS = 7;//7
        public static int NB_ROWS = 6;//6

        public static int MARGIN_TOP = 25;//Marge du haut (taille du menu en px)
        public static int MARGIN_BOTTOM = 25;//Marge du bas (taille de la barre en px)

        public static int WIDTH = SIZE_W * NB_COLS;
        public static int HEIGHT = SIZE_H * NB_ROWS;

        public static int SPEED = 25;

        public static int PUISSANCE = 4;

        private bool clicEffectue = false;

        private Grille grille;
        private Jeton jeton;//Jeton que l'on déplace en haut de la grille
        private Point[] jetons_gagnants;

        //Nombre de victoire des joueurs
        private int joueurRouge = 0;
        private int joueurJaune = 0;

        private String joueur = "rouge";//Couleur du joueur qui doit jouer

        private int nbJetons = 0;//Nombre de jeton posés

        public Puissance4()
        {
            #region Puissance4
            InitializeComponent();

            ClientSize = new System.Drawing.Size(WIDTH - 6, HEIGHT + SIZE_H + MARGIN_TOP + MARGIN_BOTTOM - 6);

            this.grille = new Grille();
            this.jeton = new Jeton(joueur, WIDTH / 2 - SIZE_W / 2, 0);
            #endregion

            toolStripStatusLabel1.Text = "Rouge : 0";
            toolStripStatusLabel2.Text = "Jaune : 0";

            Refresh();
            
        }

        private void init()
        {
            grille.init();

            joueur = "rouge";

            jeton.setCouleur(joueur);
            jetons_gagnants = null;

            nbJetons = 0;

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
            for (int x = 0; x < Puissance4.NB_COLS; x++)
            {
                e.Graphics.DrawImage(Properties.Resources.caseBleue, new Rectangle(x * Puissance4.SIZE_W, Puissance4.MARGIN_TOP, Puissance4.SIZE_W, Puissance4.SIZE_H));
            }
        }

        private void Puissance4_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (e.X / SIZE_W) * SIZE_W;

            if (x < 0)
            {
                x = 0;
            }
            else if (x > WIDTH - SIZE_W)
            {
                x = WIDTH - SIZE_W;
            }

            jeton.setPotision(x, 0);
            Refresh();
        }

        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous commencer une nouvelle partie ?", "Nouvelle partie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                joueurRouge = 0;
                joueurJaune = 0;
                toolStripStatusLabel1.Text = "Rouge : 0";
                toolStripStatusLabel2.Text = "Jaune : 0";
                init();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Apropos about = new Apropos();
            about.ShowDialog();
        }

        private void Puissance4_Load(object sender, EventArgs e)
        {

        }

        private void Puissance4_MouseClick(object sender, MouseEventArgs e)
        {
            clicEffectue = true;

            #region MouseCLick
            int i = ((MouseEventArgs)e).X / SIZE_W;

            if (i >= NB_COLS)
            {
                i = NB_COLS - 1;
            }

            if (grille[i, 0].getCouleur() != null)
            {
                return;
            }
            int j = grille.ligneInsertion(i);
            int y = 0;

            while (y <= HEIGHT - (NB_ROWS - j - 1) * SIZE_H)
            {
                jeton.setPositionY(y);
                y++;

                if (y % SPEED == 0)
                {
                    Refresh();
                }
            }

            grille[i, j].setCouleur(jeton.getCouleur());
            Puissance4_MouseMove(sender, (MouseEventArgs)e);
            jeton.inverserCouleur();

            Refresh();
            #endregion

            jetons_gagnants = grille.jetonGagnant(i, j);
            if (jetons_gagnants != null)
            {
                Refresh();//Permet d'afficher quels jetons sont gagnants

                MessageBox.Show("Partie finie !\nVictoire du joueur " + joueur);

                if (joueur == "rouge")
                {
                    joueurRouge++;
                    toolStripStatusLabel1.Text = "Rouge : " + joueurRouge.ToString();
                }
                else if (joueur == "jaune")
                {
                    joueurJaune++;
                    toolStripStatusLabel2.Text = "Jaune : " + joueurJaune.ToString();
                }

                init();
            }
            else if (++nbJetons == NB_COLS * NB_ROWS)
            {
                MessageBox.Show("Egalité !");
                joueurRouge++;
                joueurJaune++;
                toolStripStatusLabel1.Text = "Rouge : " + joueurRouge.ToString();
                toolStripStatusLabel2.Text = "Jaune : " + joueurJaune.ToString();

                init();
            }
            else
            {
                if (joueur == "rouge")
                {
                    joueur = "jaune";
                }
                else if (joueur == "jaune")
                {
                    joueur = "rouge";
                }
            }
            clicEffectue = false;
        }
    }
}
