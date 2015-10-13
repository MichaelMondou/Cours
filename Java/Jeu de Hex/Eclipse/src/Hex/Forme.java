package Hex;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Polygon;

import javax.swing.JPanel;


public class Forme extends JPanel {
	public void paintComponent(Graphics g) {
		Polygon p = new Polygon();
		double arc = (Math.PI * 2) / 6;
		for (int i = 0; i <= 6; i++) {
			p.addPoint((int) Math.round(375 + 50 * Math.cos(arc * i)),
					(int) Math.round(275 + 50 * Math.sin(arc * i)));
		}
		g.setColor(Color.ORANGE);
		g.fillPolygon(p);
	}
}