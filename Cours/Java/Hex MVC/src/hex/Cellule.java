package hex;

import java.awt.Color;
import java.awt.Polygon;

@SuppressWarnings({ "serial", "rawtypes" })
public class Cellule extends Polygon implements Comparable {

	/**
	 * Coordonn�e X de la cellule
	 */
	private int x;
	/**
	 * Coordonn�e Y de la cellule
	 */
	private int y;
	/**
	 * Position de la cellule (ligne)
	 */
	private int l;
	/**
	 * Position de la cellule (colonne)
	 */
	private int c;
	/**
	 * Couleur de la cellule
	 */
	private Color couleur;

	/**
	 * Sert � savoir si la cellule a d�j� �tait modifi�e pour ne pas pouvoir
	 * cliquer deux fois dessus
	 */
	private boolean modifie;
	/**
	 * Sert � savoir si la zone attribu�e � la cellule a d�l� �tait chang�e
	 */
	private boolean zone_changee;
	/**
	 * Rayon de la cellule
	 */
	private static int rad = 30;
	/**
	 * Angle de la cellule
	 */
	private static final double arc = (Math.PI * 2) / 6;

	/**
	 * Zone d'appartenance de la cellule
	 */
	private int zone = 0;

	Cellule(int x, int y, int l, int c, Color couleur) {
		this.x = x;
		this.y = y;
		this.l = l;
		this.c = c;
		this.couleur = couleur;
		this.modifie = false;
		this.zone_changee = false;
	}

	/**
	 * Permet de cr�er un polygon en cr�ant 6 points
	 */
	public void creerPolygon() {
		for (int i = 0; i <= 6; i++) {
			this.addPoint((int) Math.round(this.x + rad * Math.cos(arc * i)),
					(int) Math.round(this.y + Cellule.rad * Math.sin(arc * i)));
		}
	}	

	@Override
	public int compareTo(Object o) {
		int resultat = 0;
		Cellule autre_cellule=(Cellule)o;
		if (this.zone > autre_cellule.zone)
			resultat = 1;
		if (this.zone < autre_cellule.zone)
			resultat = -1;
		if (this.zone == autre_cellule.zone)
			resultat = 0;
		return resultat;
	}

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

	public int getL() {
		return l;
	}

	public void setL(int l) {
		this.l = l;
	}

	public int getC() {
		return c;
	}

	public void setC(int c) {
		this.c = c;
	}

	public Color getCouleur() {
		return couleur;
	}

	public void setCouleur(Color couleur) {
		this.couleur = couleur;
	}

	public boolean estModifiee() {
		return modifie;
	}

	public void setModifie(boolean modifie) {
		this.modifie = modifie;
	}

	public int getZone() {
		return zone;
	}

	public void setZone(int zone) {
		this.zone = zone;
	}
	
	public boolean isChangedZone() {
		return zone_changee;
	}

	public void setChangedZone(boolean changedZone) {
		this.zone_changee = changedZone;
	}
	
}
