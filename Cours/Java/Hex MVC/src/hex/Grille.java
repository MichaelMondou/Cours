package hex;

import java.awt.Color;
import java.util.ArrayList;

public class Grille {

	static final int nbLignes = 7;
	static final int nbColonnes = 7;

	private ArrayList<ArrayList<Cellule>> cellules = new ArrayList<ArrayList<Cellule>>();

	public Grille() {
		int abscisse = 0;
		int ordonn�e = 0;

		for (int i = 0; i < nbLignes; i++) {
			ArrayList<Cellule> cellules_temporaires = new ArrayList<Cellule>();
			for (int j = 0; j < nbColonnes; j++) {
				abscisse = 170 + i * 49;
				ordonn�e = 250 + j * 55;
				cellules_temporaires.add(new Cellule(abscisse, ordonn�e, j, i, Color.GRAY));
			}
			getCellule().add(cellules_temporaires);
		}
		parametrerLaGrille();
	}

	/**
	 * Permet de mettre le plateau en d�cal�
	 */
	public void parametrerLaGrille() {
		for (int i = 0; i < Grille.nbLignes; i++) {
			for (int j = 0; j < Grille.nbColonnes; j++) {
				int ordonnee = this.getCellule().get(i).get(j).getY();
				ordonnee -= 27 * i;
				this.getCellule().get(i).get(j).setY(ordonnee);
				this.getCellule().get(i).get(j).creerPolygon();
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
