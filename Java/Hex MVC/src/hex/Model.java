package hex;

import java.awt.Color;
import java.awt.Point;
import java.util.Observable;

public class Model extends Observable {

	private Grille plateau;

	private int joueur;
	
	

	public void nextData() {

	}

	public Model() {
		plateau = new Grille();
		joueur = 1;
		
	}

	public Grille getPlateau() {
		return plateau;
	}

	public void setPlateau(Grille plateau) {
		this.plateau = plateau;
	}

	public void modifyColor(Point p) {
		for (int i = 0; i < getPlateau().cellules.size(); i++) {
			for (int j = 0; j < getPlateau().cellules.get(i).size(); j++) {
				if (getPlateau().cellules.get(i).get(j).contains(p) && !(getPlateau().cellules.get(i).get(j).isModify())) {
					if (joueur == 1) {
						getPlateau().cellules.get(i).get(j).setCouleur(Color.BLACK);
						getPlateau().cellules.get(i).get(j).setModify(true);
						joueur = 2;
						setChanged();
						notifyObservers();
					} else {
						getPlateau().cellules.get(i).get(j).setCouleur(Color.WHITE);
						getPlateau().cellules.get(i).get(j).setModify(true);
						joueur = 1;
						setChanged();
						notifyObservers();
					}
				}
			}
		}
	}

}
