package hex;

import java.awt.Color;
import java.util.ArrayList;

public class Grille {

	static final int longueur = 7;
	static final int hauteur = 7;

	ArrayList<ArrayList<Cellule>> cellules = new ArrayList<ArrayList<Cellule>>();

	public Grille() {
		int abscisse = 0;
		int ordon�e = 0;

		for (int i = 0; i < longueur; i++) {
			ArrayList<Cellule> cellules_temp = new ArrayList<Cellule>();
			for (int j = 0; j < hauteur; j++) {
				abscisse = 500 + i * 49;
				ordon�e = 300 + j * 55;
				cellules_temp.add(new Cellule(abscisse, ordon�e, i, j, Color.GRAY));
			}
			cellules.add(cellules_temp);
		}
		miseEnPlace();
	}

	/**
	 * Permet de mettre le plateau en d�cal�
	 */
	public void miseEnPlace() {
		for (int i = 0; i < Grille.longueur; i++) {
			for (int j = 0; j < Grille.hauteur; j++) {
				int ordon�e = this.cellules.get(i).get(j).getY();
				ordon�e -= 27 * i;
				this.cellules.get(i).get(j).setY(ordon�e);
			}
		}
	}
}