/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

import general.Fenetre;

public class Principal {

	public static void main(String[] args) throws ClassNotFoundException, InstantiationException, IllegalAccessException, UnsupportedLookAndFeelException {
		
		
		UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());

		Fenetre fenetre = new Fenetre("Hex - MONDOU - TAMAS_LELOUP - S3B", 640, 720);
		Modele modele = new Modele();
		Controleur controleur = new Controleur(modele);
		VueHex vue = new VueHex(fenetre, modele, controleur);
		modele.addObserver(vue);

	}
}
