/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package tests;

import static org.junit.Assert.*;

import java.awt.Color;
import java.awt.Point;
import java.util.ArrayList;

import org.junit.Test;

import hex.Cellule;
import hex.Evenement;
import hex.Grille;
import hex.Joueur;
import hex.Modele;

public class TestModele {

	Modele modele = new Modele();
	Grille grille = new Grille();

	/**
	 * Teste si on a bien deux joueurs.
	 */
	@Test
	public void testConstructeurModele() {
		assertEquals(modele.getJoueurs().size(), 2);
	}

	/**
	 * Teste si la fonction permettant de savoir si un point est contenu dans
	 * une cellule fonctionne.
	 */
	@Test
	public void testEstDansLaCellule() {
		Point point = new Point(50, 50);
		Cellule cellule = new Cellule(50, 50, 50, 50, Color.BLACK);
		cellule.creerPolygon();
		assertTrue(modele.estDansLaCellule(point, cellule));
		point.setLocation(new Point(50, 101));
		assertFalse(modele.estDansLaCellule(point, cellule));
	}

	/**
	 * Teste si la fonction permettant de connaître les voisins d'une cellule
	 * fonctionne.
	 */
	@Test
	public void testVoisinsAutour() {
		ArrayList<Cellule> cellules = grille.getCellule().get(0);
		Joueur joueur = modele.getJoueurs().get(0);
		joueur.ajouterCellule(cellules.get(0));

		assertEquals(modele.voisinsAutour(cellules.get(0), joueur).size(), 0);

		ArrayList<Cellule> voisins = new ArrayList<Cellule>();
		voisins.add(cellules.get(1));
		joueur.ajouterCellule(cellules.get(1));

		assertEquals(modele.voisinsAutour(cellules.get(0), joueur), voisins);

		voisins.add(cellules.get(5));
		joueur.ajouterCellule(cellules.get(5));

		assertEquals(modele.voisinsAutour(cellules.get(0), joueur).size(), 1);
	}

	/**
	 * Teste si l'action de réinitialisation des cellules fonctionne
	 */
	@Test
	public void testReinitialiserCellules() {
		modele.getGrille().getCellule().get(0).get(0).setZoneChangee(true);
		modele.getGrille().getCellule().get(1).get(0).setZoneChangee(true);

		assertTrue(modele.getGrille().getCellule().get(0).get(0).zoneEstChangee());

		modele.reinitialiserCellules();

		assertFalse(modele.getGrille().getCellule().get(0).get(0).zoneEstChangee());
		assertFalse(grille.getCellule().get(1).get(0).zoneEstChangee());
	}

	/**
	 * Teste si l'action permettant de savoir si la partie est finie fonctionne.
	 */
	@Test
	public void testPartieTerminee() {
		Joueur joueur = modele.getJoueurs().get(0);
		joueur.setIdentite(0);
		ArrayList<ArrayList<Cellule>> cellules = modele.getGrille().getCellule();
		Evenement gagnant = Evenement.JOUEUR_UN_GAGNANT;

		for (int i = 0; i < Grille.nbLignes; i++) {
			for (int j = 0; j < Grille.nbColonnes; j++) {
				joueur.ajouterCellule(cellules.get(i).get(j));
				modele.affecterZone(cellules.get(i).get(j), joueur);
			}
		}
		modele.partieTerminee(joueur);

		assertEquals(modele.qui_est_le_gagnant, gagnant);
	}

}
