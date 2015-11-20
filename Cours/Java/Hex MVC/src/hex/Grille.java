package hex;

import java.awt.Color;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class Grille {

	static final int longueur = 7;
	static final int hauteur = 7;

	private ArrayList<ArrayList<Cellule>> cellules = new ArrayList<ArrayList<Cellule>>();

	public Grille() {
		int abscisse = 0;
		int ordon�e = 0;

		for (int i = 0; i < longueur; i++) {
			ArrayList<Cellule> cellules_temp = new ArrayList<Cellule>();
			for (int j = 0; j < hauteur; j++) {
				abscisse = 170 + i * 49;
				ordon�e = 250 + j * 55;
				cellules_temp.add(new Cellule(abscisse, ordon�e, j, i, Color.GRAY));
			}
			getCellules().add(cellules_temp);
		}
		miseEnPlace();
	}

	/**
	 * Permet de mettre le plateau en d�cal�
	 */
	public void miseEnPlace() {
		for (int i = 0; i < Grille.longueur; i++) {
			for (int j = 0; j < Grille.hauteur; j++) {
				int ordon�e = this.getCellules().get(i).get(j).getY();
				ordon�e -= 27 * i;
				this.getCellules().get(i).get(j).setY(ordon�e);
				this.getCellules().get(i).get(j).creerPolygone();
			}
		}
	}

	public void affecterZone(Cellule cellule, Joueur joueur) {
		if (cellule.getC() == 0)
			cellule.setZone(1);
		/*else if()
		{*/
			this.update(cellule, joueur);
		//}

	}

	private void update(Cellule cellule, Joueur joueur) {
		// TODO Auto-generated method stub
		ArrayList<Cellule>neighbors=new ArrayList<Cellule>();
		neighbors=this.around(cellule, joueur);
		cellule.setZone(neighbors.get(0).getZone());
		update(neighbors.get(1),joueur);

	}

	private ArrayList<Cellule> around(Cellule cellule, Joueur joueur) {
		// TODO Auto-generated method stub
		int left = cellule.getC() - 1;
		int right = cellule.getC() + 1;
		int top = cellule.getL() - 1;
		int bottom = cellule.getL() + 1;

		ArrayList<Cellule> neighbors = new ArrayList<Cellule>();
		for (int i = 0; i < joueur.getCellules_joueur().size(); i++) {
			int ligne = joueur.getCellules_joueur().get(i).getL();
			int colonne = joueur.getCellules_joueur().get(i).getC();

			if (colonne == left && ligne == cellule.getL()) {
				// regarder gauche
				neighbors.add(joueur.getCellules_joueur().get(i));
			}

			else if (colonne == right && ligne == cellule.getL()) {
				// regarder droite
				neighbors.add(joueur.getCellules_joueur().get(i));
			}

			else if (ligne == top && colonne == cellule.getC()) {
				// regarder haut
				neighbors.add(joueur.getCellules_joueur().get(i));
			} else if (ligne == bottom && colonne == cellule.getC()) {
				// regarder bas
				neighbors.add(joueur.getCellules_joueur().get(i));
			} else if (colonne == left && ligne == top) {
				// gerer diag gauche
				neighbors.add(joueur.getCellules_joueur().get(i));
			} else if (colonne == right && ligne == bottom) {
				// gerer diag droite
				neighbors.add(joueur.getCellules_joueur().get(i));
			}
		}

		Collections.sort(neighbors);
		return neighbors;


	}

	public ArrayList<ArrayList<Cellule>> getCellules() {
		return cellules;
	}

	public void setCellules(ArrayList<ArrayList<Cellule>> cellules) {
		this.cellules = cellules;
	}
}
