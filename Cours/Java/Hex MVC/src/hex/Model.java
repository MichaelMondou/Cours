package hex;

import java.awt.Color;
import java.awt.Point;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Observable;

public class Model extends Observable {

	private Grille plateau;

	private ArrayList<Joueur> joueur;

	private int tourJoueur=1;

	public void nextData() {

	}

	public Model() {
		plateau = new Grille();
		joueur = new ArrayList<Joueur>();
		Joueur j1 = new Joueur("joueur1", Color.BLACK);
		Joueur j2 = new Joueur("joueur2", Color.WHITE);
		joueur.add(j1);
		joueur.add(j2);

	}

	public Grille getPlateau() {
		return plateau;
	}

	public void setPlateau(Grille plateau) {
		this.plateau = plateau;
	}

	public void modifyColor(Point p) {
		for (int i = 0; i < getPlateau().getCellules().size(); i++) {
			for (int j = 0; j < getPlateau().getCellules().get(i).size(); j++) {
				if (getPlateau().getCellules().get(i).get(j).contains(p)
						&& !(getPlateau().getCellules().get(i).get(j).isModify())) {
					/*
					 * if (tourJoueur == 1) {
					 * getPlateau().getCellules().get(i).get(j).setCouleur(Color
					 * .BLACK);
					 * getPlateau().getCellules().get(i).get(j).setModify(true);
					 * tourJoueur = 2;
					 * //System.out.println(getPlateau().cellules.get(i).get(j).
					 * getL()+" "+getPlateau().cellules.get(i).get(j).getC());
					 * 
					 * setChanged(); notifyObservers(); } else {
					 * getPlateau().getCellules().get(i).get(j).setCouleur(Color
					 * .WHITE);
					 * getPlateau().getCellules().get(i).get(j).setModify(true);
					 * tourJoueur = 1; setChanged(); notifyObservers();
					 */
					
				   
				   
				   
					getPlateau().getCellules().get(i).get(j).setCouleur(joueur.get(tourJoueur-1).getCouleur());
					getPlateau().getCellules().get(i).get(j).setModify(true);
					joueur.get(tourJoueur-1).ajoutCellule(getPlateau().getCellules().get(i).get(j));
					changeTourJoueur();
					setChanged();
					notifyObservers();
				}
			}
		}
	}

	private void changeTourJoueur() {
		if (tourJoueur == 1)
			tourJoueur = 2;
		else
			tourJoueur = 1;

	}
}
