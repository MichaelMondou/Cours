/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import general.Fenetre;

public class Principal {

	public static void main(String[] args) {

		Fenetre fenetre = new Fenetre("Hex - MONDOU - TAMAS_LELOUP - S3B", 640, 720);

		Modele modele = new Modele();
		Controleur controleur = new Controleur(modele);
		VueHex vue = new VueHex(fenetre, modele, controleur);
		modele.addObserver(vue);

	}
}
