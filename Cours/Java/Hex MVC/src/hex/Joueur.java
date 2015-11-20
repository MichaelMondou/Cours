package hex;

import java.awt.Color;
import java.util.ArrayList;

public class Joueur {
	
	private String nom;
	private Color couleur;
	private ArrayList<Cellule> cellules_joueur;
	
	public Joueur(String nom, Color couleur)
	{
		this.nom=nom;
		this.couleur=couleur;
		cellules_joueur=new ArrayList<Cellule>();
	}
	
	public void ajoutCellule(Cellule cellule)
	{
		this.cellules_joueur.add(cellule);
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
	public ArrayList<Cellule> getCellules_joueur() {
		return cellules_joueur;
	}
	public void setCellules_joueur(ArrayList<Cellule> cellules_joueur) {
		this.cellules_joueur = cellules_joueur;
	}

}
