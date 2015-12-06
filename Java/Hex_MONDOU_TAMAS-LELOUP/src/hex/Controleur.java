/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Point;
import java.awt.event.MouseEvent;

public class Controleur {

	/**
	 * Modèle du jeu calculant les données nécessaires au fonctionnement du jeu
	 */
	private Modele modele;

	public Controleur(Modele modele) {
		this.modele = modele;
	}

	/**
	 * Cette action permet de gérer les événements entrants créés dans la vue.
	 * Elle a pour but d'appeler l'action qu'il faut dans le modèle. Dans le cas
	 * présent, il n'y a qu'un seul événement (le joueur clique).
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
