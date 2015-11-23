package hex;

import java.awt.Color;
import java.awt.Polygon;

@SuppressWarnings("serial")
public class Cell extends Polygon implements Comparable {

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
	private Color color;

	/**
	 * Sert � savoir si la cellule � d�j� �tait modifi�e pour ne pas pouvor
	 * cliquer deux fois dessus
	 */
	private boolean modify;
	

	private boolean changedZone=false;



	/**
	 * Rayon de la cellule
	 */
	private static int rad = 30;
	/**
	 * Angle de la cellule
	 */
	private static final double arc = (Math.PI * 2) / 6;

	/**
	 * zone d'appartenance pour g�rer victoire
	 */
	private int zone = 0;

	Cell(int x, int y, int l, int c, Color color) {
		this.x = x;
		this.y = y;
		this.l = l;
		this.c = c;
		this.color = color;
		this.modify = false;
	}

	public void createPolygon() {
		for (int i = 0; i <= 6; i++) {
			this.addPoint((int) Math.round(this.x + rad * Math.cos(arc * i)),
					(int) Math.round(this.y + Cell.rad * Math.sin(arc * i)));
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

	public Color getColor() {
		return color;
	}

	public void setColor(Color color) {
		this.color = color;
	}

	public boolean isModify() {
		return modify;
	}

	public void setModify(boolean modify) {
		this.modify = modify;
	}

	public int getZone() {
		return zone;
	}

	public void setZone(int zone) {
		this.zone = zone;
	}

	

	@Override
	public int compareTo(Object o) {
		int result = 0;
		Cell another_cell=(Cell)o;
		if (this.zone > another_cell.zone)
			result = 1;
		if (this.zone < another_cell.zone)
			result = -1;
		if (this.zone == another_cell.zone)
			result = 0;
		return result;
	}

	
	public boolean isChangedZone() {
		return changedZone;
	}

	public void setChangedZone(boolean changedZone) {
		this.changedZone = changedZone;
	}
	
}