package Hex;

import java.awt.Color;
import java.awt.Polygon;

public class Cellule extends Polygon{

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
	 * Rayon de la cellule
	 */
	private static int rad = 30;
	/**
	 * Angle de la cellule
	 */
	private static final double arc = (Math.PI * 2) / 6;
	
	

	Cellule(int x, int y, int l, int c, Color couleur) {
		this.x = x;
		this.y = y;
		this.l = l;
		this.c = c;
		this.couleur = couleur;
	}
	
	public void creerPolygone(){
		for (int i = 0; i <= 6; i++) {
			this.addPoint((int) Math.round(this.x + rad * Math.cos(arc * i)),
					(int) Math.round(this.y + Cellule.rad * Math.sin(arc * i)));
		}
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
	
	
	
	
}