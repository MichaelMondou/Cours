package Hex;

import java.awt.Color;
import java.util.ArrayList;

public class Model extends Observable{
	
	private ArrayList<Controller> model_controllers = new ArrayList<Controller>();
	private ArrayList<View> views = new ArrayList<View>();//pourquoi ya plusieurs vu?
	
	private Grille plateau;

	public void nextData() {

	}
	public Model(){
		plateau = new Grille();
	}
	/*public void initialisation(){
		plateau = new Plateau();
	}*/
	
	public Grille getPlateau() {
		return plateau;
	}

	public void setPlateau(Grille plateau) {
		this.plateau = plateau;
	}
	

}
