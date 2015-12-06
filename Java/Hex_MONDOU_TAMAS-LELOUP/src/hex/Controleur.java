/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Point;
import java.awt.event.MouseEvent;

public class Controleur {

	/**
	 * Mod�le du jeu calculant les donn�es n�cessaires au fonctionnement du jeu
	 */
	private Modele modele;

	public Controleur(Modele modele) {
		this.modele = modele;
	}

	/**
	 * Cette action permet de g�rer les �v�nements entrants cr��s dans la vue.
	 * Elle a pour but d'appeler l'action qu'il faut dans le mod�le. Dans le cas
	 * pr�sent, il n'y a qu'un seul �v�nement (le joueur clique).
	 */
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
