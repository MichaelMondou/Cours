package hex;

import java.util.Observable;

public class Model extends Observable{
	
	private Grille plateau;

	public void nextData() {

	}
	public Model(){
		plateau = new Grille();
	}
	
	public Grille getPlateau() {
		return plateau;
	}

	public void setPlateau(Grille plateau) {
		this.plateau = plateau;
		setChanged();
		notifyObservers();
	}

}
