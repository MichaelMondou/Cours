package Hex;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Polygon;
import java.util.ArrayList;

import javax.swing.JPanel;


public class Vue extends JPanel {
	public void paintComponent(Graphics g) {


		Cellule[] tab = new Cellule[3];
		Cellule c = new Cellule(50, 50, 0, 0,Color.GRAY);
		Cellule c2 = new Cellule(50, 50, 0, 0,Color.GRAY);
		Cellule c3 = new Cellule(50, 50, 0, 0,Color.GRAY);
		c.creerPolygone();
		c2.creerPolygone();
		c3.creerPolygone();
		tab[0] = c;
		tab[1] = c2;
		tab[2] = c3;
		for(int i=0; i < tab.length; i++)
			g.fillPolygon(tab[i]);
	}
}
