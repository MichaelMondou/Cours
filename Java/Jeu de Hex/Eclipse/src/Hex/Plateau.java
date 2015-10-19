package Hex;

import java.awt.Color;
import java.util.ArrayList;

public class Plateau {

	static final int longueur = 7;
	static final int hauteur = 7;

	ArrayList<ArrayList<Cellule>> cellules = new ArrayList();

	public Plateau() {
		ArrayList<Cellule> cellules_temp = new ArrayList();

		for (int i = 0; i < longueur; i++) {
			for (int j = 0; j < hauteur; j++) {
				cellules_temp.add(new Cellule(10+i*5, 10+j*10, i, j, Color.BLACK));
			}
			cellules.add(cellules_temp);
			cellules_temp.clear();
		}

	}

}
