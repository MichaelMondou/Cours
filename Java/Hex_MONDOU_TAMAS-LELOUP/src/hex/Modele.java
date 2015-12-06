/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Color;
import java.awt.Point;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Observable;

import exception.NbLignesColonnesException;

public class Modele extends Observable {

	/**
	 * Le grille du jeu contenant des cellules
	 */
	private Grille grille;

	/**
	 * Les joueurs
	 */
	private ArrayList<Joueur> joueurs;

	/**
	 * Tour courant
	 */
	private int tour_du_joueur = 0;

	/**
	 * Sert � savoir s'il y a un gagnant
	 */
	public Evenement qui_est_le_gagnant;

	public Modele() {
		try {
			grille = new Grille();
		} catch (NbLignesColonnesException ligne_colonne_exception) {
			System.err.println(ligne_colonne_exception);
		}
		joueurs = new ArrayList<Joueur>();
		Joueur j1 = new Joueur("joueur1", Color.BLACK);
		Joueur j2 = new Joueur("joueur2", Color.WHITE);
		joueurs.add(j1);
		joueurs.add(j2);

		qui_est_le_gagnant = Evenement.PAS_DE_GAGNANT;
	}

	/**
	 * Cette action sert � encha�ner les diff�rentes actions n�cessaires au
	 * fonctionnement du jeu
	 * 
	 * @param p
	 */
	public void prochainesDonnees(Point p) {
		for (int i = 0; i < grille.getCellule().size(); i++) {
			for (int j = 0; j < grille.getCellule().get(i).size(); j++) {
				if (estDansLaCellule(p, grille.getCellule().get(i).get(j))) {
					joueurs.get(tour_du_joueur).ajouterCellule(grille.getCellule().get(i).get(j));
					affecterZone(grille.getCellule().get(i).get(j), joueurs.get(tour_du_joueur));
					modifierCouleur(grille.getCellule().get(i).get(j));
					partieTerminee(joueurs.get(tour_du_joueur));
					changerTourDuJoueur();
					setChanged();
					notifyObservers();
				}
			}
		}
	}

	/**
	 * Cette fonction sert � d�tecter si un point p se trouve dans une cellule
	 */
	public boolean estDansLaCellule(Point p, Cellule cellule) {
		if (cellule.contains(p) && !(cellule.estModifiee())) {
			return true;
		}
		return false;
	}

	/**
	 * Cette action sert � g�rer l'affectation d'une zone sur la cellule pass�e
	 * en param�tre en fonction du nombre de ses voisins.
	 */
	public void affecterZone(Cellule cellule, Joueur joueur) {

		// Si la cellule a un ou des voisins
		if (voisinsAutour(cellule, joueur).size() > 0) {
			// On met � jour le nouveau groupe de cellule
			miseAJourDesVoisins(cellule, joueur);

		} else {
			// Sinon on attribue une nouvelle zone � la cellule
			cellule.setZone(joueur.getZone());
			joueur.incrementationZone();
		}
		reinitialiserCellules();
	}

	/**
	 * Cette action permet d'attribuer une zone � la cellule pass�e en param�tre
	 * en fonction des zones de ses voisins puis met � jour les zones de ses
	 * voisins.
	 */
	public void miseAJourDesVoisins(Cellule cellule, Joueur joueur) {
		ArrayList<Cellule> voisins = new ArrayList<Cellule>();
		// On cr�� une ArrayList des voisins (tri�s) de la cellule
		voisins = voisinsAutour(cellule, joueur);
		// La cellule prend la plus petite zone de ses voisins
		cellule.setZone(voisins.get(0).getZone());
		cellule.setZoneChangee(true);
		// On appelle cette action r�cursivement pour tous les voisins de la
		// cellule
		if (voisins.size() > 1) {
			for (int i = 1; i < voisins.size(); i++) {
				if (!voisins.get(i).zoneEstChangee())
					miseAJourDesVoisins(voisins.get(i), joueur);
			}
		}
	}

	/**
	 * Cette fonction sert � d�terminer si la cellule a des voisins. Si c'est le
	 * cas, elle retourne ses voisins.
	 */

	@SuppressWarnings("unchecked")
	public ArrayList<Cellule> voisinsAutour(Cellule cellule, Joueur joueur) {

		// On regarde les lignes et colonnes autour de la cellule
		int gauche = cellule.getColonne() - 1;
		int droite = cellule.getColonne() + 1;
		int haut = cellule.getLigne() - 1;
		int bas = cellule.getLigne() + 1;

		// On cr�� une ArrayList de voisins
		ArrayList<Cellule> voisins = new ArrayList<Cellule>();

		// On parcourt les cellules du joueur
		for (int i = 0; i < joueur.getCellulesDuJoueur().size(); i++) {
			int ligne = joueur.getCellulesDuJoueur().get(i).getLigne();
			int colonne = joueur.getCellulesDuJoueur().get(i).getColonne();

			// On remplit l'ArrayList avec les voisins autour de la cellule
			if (colonne == gauche && ligne == cellule.getLigne()) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			} else if (colonne == droite && ligne == cellule.getLigne()) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			} else if (ligne == haut && colonne == cellule.getColonne()) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			} else if (ligne == bas && colonne == cellule.getColonne()) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			} else if (colonne == gauche && ligne == haut) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			} else if (colonne == droite && ligne == bas) {
				voisins.add(joueur.getCellulesDuJoueur().get(i));
			}
		}

		// On trie l'ArrayList de fa�on � avoir le voisin de plus petite zone en
		// premier
		Collections.sort(voisins);
		return voisins;
	}

	/**
	 * Cette action sert � r�initialiser le bool�en de chaque zone. Ce dernier
	 * indiquant si la zone de la cellule a d�j� �t� mise � jour.
	 */
	public void reinitialiserCellules() {
		for (int i = 0; i < grille.getCellule().size(); i++)
			for (int j = 0; j < grille.getCellule().get(i).size(); j++)
				grille.getCellule().get(i).get(j).setZoneChangee(false);
	}

	/**
	 * Cette action sert � modifier la couleur de la cellule pass�e en param�tre
	 */
	public void modifierCouleur(Cellule cellule) {
		cellule.setCouleur(joueurs.get(tour_du_joueur).getCouleur());
		cellule.setModifie(true);
	}

	/**
	 * Cette fonction sert � d�tecter si la partie est finie en regardant les
	 * premi�re et derni�re colonne si c'est le premier joueur et les premi�re
	 * et derni�re lignes si c'est le second joueur.
	 */

	public void partieTerminee(Joueur joueur) {

		// On cr�� une ArrayList des zones gagnantes des joueurs
		ArrayList<Integer> zones_gagnantes_joueur1 = new ArrayList<Integer>();
		ArrayList<Integer> zones_gagnantes_joueur2 = new ArrayList<Integer>();

		// Si c'est le premier joueur
		if (joueur.getIdentite() == 0) {
			// On parcourt les cellules du joueur
			for (int i = 0; i < joueur.getCellulesDuJoueur().size(); i++) {
				// Si la cellule est situ�e dans la premi�re colonne
				if (joueur.getCellulesDuJoueur().get(i).getColonne() == 0)
					// On ajoute la zone de la cellule aux zones gagnantes du
					// joueur
					zones_gagnantes_joueur1.add(joueur.getCellulesDuJoueur().get(i).getZone());
			}
			// On parcourt les cellules du joueur
			for (int j = 0; j < joueur.getCellulesDuJoueur().size(); j++) {
				// Si la cellule est situ�e dans la derni�re colonne
				if (joueur.getCellulesDuJoueur().get(j).getColonne() == Grille.nbColonnes - 1) {
					// On parcourt les zones gagnantes du joueur
					for (Integer z : zones_gagnantes_joueur1) {
						// Si il y a une zone de la premi�re colonne identique �
						// la zone de la cellule
						if (z == joueur.getCellulesDuJoueur().get(j).getZone())
							qui_est_le_gagnant = Evenement.JOUEUR_UN_GAGNANT;
					}
				}
			}
		} else {
			for (int i = 0; i < joueur.getCellulesDuJoueur().size(); i++) {
				if (joueur.getCellulesDuJoueur().get(i).getLigne() == 0)
					zones_gagnantes_joueur2.add(joueur.getCellulesDuJoueur().get(i).getZone());
			}
			for (int j = 0; j < joueur.getCellulesDuJoueur().size(); j++) {
				if (joueur.getCellulesDuJoueur().get(j).getLigne() == Grille.nbLignes - 1) {
					for (Integer z : zones_gagnantes_joueur2) {
						if (z == joueur.getCellulesDuJoueur().get(j).getZone())
							qui_est_le_gagnant = Evenement.JOUEUR_DEUX_GAGNANT;
					}
				}
			}
		}
	}

	/**
	 * Cette action sert � changer de tour
	 */
	public void changerTourDuJoueur() {
		if (tour_du_joueur == 0)
			tour_du_joueur = 1;
		else
			tour_du_joueur = 0;
	}

	/**
	 * Cette action sert � r�initialiser tous les param�tres du jeu pour
	 * commencer une nouvelle partie
	 */
	public void redemarrer() {
		try {
			grille = new Grille();
		} catch (NbLignesColonnesException ligne_colonne_exception) {
			System.err.println(ligne_colonne_exception);
		}
		joueurs = new ArrayList<Joueur>();
		Joueur j1 = new Joueur("player1", Color.BLACK);
		Joueur j2 = new Joueur("player2", Color.WHITE);
		j1.setIdentite(0);
		j2.setIdentite(1);
		joueurs.add(j1);
		joueurs.add(j2);
		qui_est_le_gagnant = Evenement.PAS_DE_GAGNANT;

		setChanged();
		notifyObservers();
	}

	public Grille getGrille() {
		return grille;
	}

	public void setGrille(Grille grille) {
		this.grille = grille;
	}

	public ArrayList<Joueur> getJoueurs() {
		return joueurs;
	}

	public void setJoueurs(ArrayList<Joueur> joueurs) {
		this.joueurs = joueurs;
	}

	public Evenement getQuiEstLeGagnant() {
		return qui_est_le_gagnant;
	}

	public void setQuiEstLeGagnant(Evenement qui_est_le_gagnant) {
		this.qui_est_le_gagnant = qui_est_le_gagnant;
	}

	public int getTourDuJoueur() {
		return tour_du_joueur;
	}

	public void setTourDuJoueur(int tour_du_joueur) {
		this.tour_du_joueur = tour_du_joueur;
	}

}