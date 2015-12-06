/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Stroke;
import java.util.Observable;

import javax.swing.JOptionPane;

import general.Clic;
import general.Fenetre;

public class VueHex extends Vue {

	/**
	 * Clic permettant de connaître les coordonnées du clic d'un joueur
	 */
	private Clic clic;

	VueHex(Fenetre fenetre, Modele modele, Controleur controleur) {
		super(fenetre, modele, controleur);
		paint(panel.getGraphics());
		clic = new Clic(this, controleur);
		panel.addMouseListener(clic);
	}

	public void paint(Graphics g) {
		panel.paint(g);
		for (int i = 0; i < getModele().getGrille().getCellule().size(); i++) {
			for (int j = 0; j < getModele().getGrille().getCellule().get(i).size(); j++) {
				g.setColor(getModele().getGrille().getCellule().get(i).get(j).getCouleur());
				g.fillPolygon(getModele().getGrille().getCellule().get(i).get(j));
			}
		}
		
		Graphics2D g2 = (Graphics2D)g;
		Stroke stroke = new BasicStroke(10.0f, BasicStroke.CAP_SQUARE,
                BasicStroke.JOIN_ROUND, 10.0f);
		g2.setStroke(stroke);	
		
		g.setColor(Color.BLACK);
		g2.drawLine(135, 640, 135, 230);
		g2.drawLine(500, 27, 500, 440);
		g.setColor(Color.WHITE);
		g2.drawLine(500, 440, 135, 640);
		g2.drawLine(135, 230, 500, 27);

		
	}

	/**
	 * Permet d'afficher dans une pop-up le joueur gagnant et relance la partie
	 * si le joueur clique sur "Ok"
	 */
	public void afficherVainqueur() {
		if (getModele().qui_est_le_gagnant == Evenement.JOUEUR_UN_GAGNANT) {
			JOptionPane.showMessageDialog(null, "Le joueur 1 a gagné");
			getModele().redemarrer();
		} else if (getModele().qui_est_le_gagnant == Evenement.JOUEUR_DEUX_GAGNANT) {
			JOptionPane.showMessageDialog(null, "Le joueur 2 a gagné");
			getModele().redemarrer();
		}
	}

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
		afficherVainqueur();
	}

}
