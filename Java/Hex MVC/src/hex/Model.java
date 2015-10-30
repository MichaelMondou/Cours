package hex;

import java.awt.Color;
import java.util.Observable;

public class Model extends Observable{
	
	private Grille plateau;

	public void nextData() {

	}
	public Model(){
		plateau = new Grille();
	}
	
	public void modifyColor(){
		for (int i = 0; i < plateau.cellules.size(); i++) {
			for (int j = 0; j < plateau.cellules.get(i).size(); j++) {
				plateau.cellules.get(i).get(j).creerPolygone();
				plateau.cellules.get(i).get(j).setCouleur(Color.ORANGE);
			}
		}
		setChanged();
		notifyObservers();
	}
	
	public Grille getPlateau() {
		return plateau;
	}

	public void setPlateau(Grille plateau) {
		this.plateau = plateau;
	}

}
