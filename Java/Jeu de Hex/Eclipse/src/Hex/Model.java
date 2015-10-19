package Hex;

import java.awt.Color;
import java.util.ArrayList;

public class Model extends Observable{
	
	private ArrayList<Controller> model_controllers = new ArrayList<Controller>();
	private ArrayList<View> views = new ArrayList<View>();
	
	private Plateau plateau;

	public void nextData() {

	}
	
	public void initialisation(){
		plateau = new Plateau();
	}
	
	public Plateau getPlateau() {
		return plateau;
	}

	public void setPlateau(Plateau plateau) {
		this.plateau = plateau;
	}
	

}
