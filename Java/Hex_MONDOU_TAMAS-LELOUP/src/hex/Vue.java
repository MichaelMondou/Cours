/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.util.Observer;

import javax.swing.JPanel;

import general.Fenetre;

public abstract class Vue implements Observer {

	/**
	 * Modèle du jeu calculant les données nécessaires au fonctionnement du jeu
	 */
	private Modele modele;
	/**
	 * Contrôleur du jeu permettant de gérer les événements du jeu
	 */
	private Controleur controleur;

	/**
	 * Fenêtre du jeu
	 */
	protected Fenetre fenetre;
	/**
	 * Panel du jeu contenant les éléments graphiques du jeu
	 */
	protected JPanel panel;

	Vue(Fenetre fenetre, Modele modele, Controleur controleur) {
		this.setModele(modele);
		modele.addObserver(this);
		this.setControleur(controleur);
		this.fenetre = fenetre;
		panel = fenetre.getPanel();
	}

	public Modele getModele() {
		return modele;
	}

	public void setModele(Modele modele) {
		this.modele = modele;
	}

	public Controleur getControleur() {
		return controleur;
	}

	public void setControleur(Controleur controleur) {
		this.controleur = controleur;
	}
}
