/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Point;
import java.awt.event.MouseEvent;

public class Controleur {
	
	private Modele modele;

	public Controleur(Modele modele) {
		this.modele = modele;
	}
	
	public void Action(Vue objet, MouseEvent evenement) {
		switch (evenement.getID()) {
		case MouseEvent.MOUSE_CLICKED:
			Point p = new Point(evenement.getX(), evenement.getY());
			modele.prochainesDonnees(p);
			break;
		default:
			break;
		}
	}

}
