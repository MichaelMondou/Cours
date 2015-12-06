/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Color;
import java.util.ArrayList;

import exception.NbLignesColonnesException;

public class Grille {

	/**
	 * Nombre de lignes dans le jeu
	 */
	public static final int nbLignes = 7;
	/**
	 * Nombre de colonnes dans le jeu
	 */
	public static final int nbColonnes = 7;
	/**
	 * Les cellules du plateau du jeu
	 */
	private ArrayList<ArrayList<Cellule>> cellules = new ArrayList<ArrayList<Cellule>>();

	@SuppressWarnings("unused")
	public Grille() throws NbLignesColonnesException {

		if (nbLignes <= 0)
			throw new NbLignesColonnesException(nbLignes);
		else if (nbColonnes <= 0)
			throw new NbLignesColonnesException(nbColonnes);
		else {
			int abscisse = 0;
			int ordonnée = 0;
			for (int i = 0; i < nbColonnes; i++) {
				ArrayList<Cellule> cellules_temporaires = new ArrayList<Cellule>();
				for (int j = 0; j < nbLignes; j++) {
					abscisse = 170 + i * 49;
					ordonnée = 250 + j * 55;
					cellules_temporaires.add(new Cellule(abscisse, ordonnée, j, i, Color.GRAY));
				}
				getCellule().add(cellules_temporaires);
			}
			parametrerLaGrille();
		}
	}

	/**
	 * Permet de modifier la disposition des cellules en les décalant tel le jeu
	 * de Hex
	 */
	public void parametrerLaGrille() {
		for (int i = 0; i < Grille.nbColonnes; i++) {
			for (int j = 0; j < Grille.nbLignes; j++) {
				int ordonnee = this.getCellule().get(i).get(j).getY();
				ordonnee -= 27 * i;
				this.getCellule().get(i).get(j).setY(ordonnee);
				this.getCellule().get(i).get(j).creerPolygone();
			}
		}
	}

	public ArrayList<ArrayList<Cellule>> getCellule() {
		return cellules;
	}

	public void setCellules(ArrayList<ArrayList<Cellule>> cellules) {
		this.cellules = cellules;
	}
}
