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
    public partial class JPO : Form
    {

        #region LES VARIABLES DU JEUX : On déclare ici les variables nécessaires au bon fonctionnement du jeu

        private Bloc[][] blocs;                 // Tableau de blocs
        private Color[] couleurs;               // Tableau de couleur des blocs
        private int vies_joueur;                // Nombre de vie du joueur
        private int score;                      // Score du joueur

        private Balle balle;                    // La balle du jeu

        private Barre barre;                    // La barre du jeu

        public enum Etat { PAUSE, JOUE, RELANCE };     // Les différents états du jeu
        public Etat etat_du_jeu = Etat.PAUSE;          // L'état initial du jeu

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

        #region GESTION DES EVENEMENTS


        private void timer1_Tick(object sender, EventArgs e)
        {
            balle.bouger();
            balle.toucherFenetre(this.Size.Width, this.Size.Height);

            #region Bloc touché par la balle

            for (int i = 0; i < Constantes.NB_BLOCS_HAUTEUR; i++)
                for (int j = 0; j < Constantes.NB_BLOCS_LARGEUR; j++)
                {
                    if (!balle.ToucheBloc)    // Si la balle n'a pas encore touché de bloc
                    {
                        if (blocs[i][j].Visible)
                        {
                            score += balle.toucheDuBloc(blocs[i][j]); // fonction qui retourne le nombre de point gagné si le bloc est touché, 0 sinon
                        }

                    }
                }
            balle.ToucheBloc = false;// fin de la phase de collision, toucheBloc est réinitialisé pour le prochain tour

            #endregion

            #region Colision de la balle avec les autres élements

/*            if (balle.sortie(this.Size.Height))
            {
                timer1.Enabled = false;
                if (vies_joueur > 0)        //reste-t-il des vies au joueur ?
                {
                    //perdreVie();
                    // emplacement de la balle au demarage
                    this.balle.Location = new Point(978 / 2 - (Constantes.TAILLE_BALLE / 2), 500);
                    etat_du_jeu = Etat.RELANCE;
                }
                else
                {
                    perdu();
                    this.Dispose(true);
                }

            }
*/     


            // on vérifie si la balle a touché la barre 
            // la méthode ajuste les prochains déplacements
            //balle.toucheBarre(this.barre);      // voir class : "Balle.cs"

            #endregion

            #region verification de fin de jeu

            /*  bool fini = true;
            // On vérifie si tous les block sont détruits
            foreach (Bloc[] ligne in blocs)
                foreach (Bloc colonne in ligne)
                {
                    if (colonne.Visible == true)//Si un block est visible(donc restant), alors la partie continue.
                    {
                        fini = false;
                        break;
                    }
                }
            if (fini)//si il ne reste aucun block, alors on affiche les événements de victoire
            {
                this.timer1.Stop();
                MessageBox.Show("Bravo !");
                this.Dispose(true);
            }*/
            #endregion

        #endregion
        }
    }
}