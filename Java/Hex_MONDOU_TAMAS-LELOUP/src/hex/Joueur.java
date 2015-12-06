/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Color;
import java.util.ArrayList;

public class Joueur {

	/**
	 * Nom du joueur
	 */
	private String nom;
	/**
	 * Identité du joueur permettant de savoir si c'est le joueur 1 ou le joueur 2
	 */
	private int identite;
	/**
	 * Couleur des cellules du joueur
	 */
	private Color couleur;
	/**
	 * Les cellules du joueur
	 */
	private ArrayList<Cellule> cellules_du_joueur;
	/**
	 * Zone de la cellule
	 */
	private int zone = 1;
	/**
	 * Cet attribut permet d'attribuer une identité au joueur (0 ou 1)
	 */
	private static int id = 0;

	public Joueur(String nom, Color couleur) {
		this.nom = nom;
		this.couleur = couleur;
		cellules_du_joueur = new ArrayList<Cellule>();
		this.identite = id;
		id++;
	}

	/**
	 * Permet d'ajouter la cellule sélectionnée par le joueur dans les cellules du joueur
	 */
	public void ajouterCellule(Cellule cellule) {
		this.cellules_du_joueur.add(cellule);
	}
	
	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public Color getCouleur() {
		return couleur;
	}

	public void setCouleur(Color couleur) {
		this.couleur = couleur;
	}

	public ArrayList<Cellule> getCellulesDuJoueur() {
		return cellules_du_joueur;
	}

	public void setCellulesDuJoueur(ArrayList<Cellule> cellules_du_joueur) {
		this.cellules_du_joueur = cellules_du_joueur;
	}

	public int getZone() {
		return zone;
	}

	public void setZone(int zone) {
		this.zone = zone;
	}

	public void incrementationZone() {
		this.zone = zone + 1;
	}

	public int getIdentite() {
		return identite;
	}

	public void setIdentite(int identite) {
		this.identite = identite;
	}
}
