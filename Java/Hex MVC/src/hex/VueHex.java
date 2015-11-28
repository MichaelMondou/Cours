/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package hex;

import java.awt.Graphics;
import java.util.Observable;

import javax.swing.JOptionPane;

import general.Clic;
import general.Fenetre;

public class VueHex extends Vue {

	Clic clic;

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
	}
	
	public void afficherVainqueur(){
		if(getModele().qui_est_le_gagnant == Evenement.JOUEUR_UN_GAGNANT){
			JOptionPane.showMessageDialog(null, "Le joueur 1 a gagn�");
			getModele().redemarrer();
		}
		else if(getModele().qui_est_le_gagnant == Evenement.JOUEUR_DEUX_GAGNANT){
			JOptionPane.showMessageDialog(null, "Le joueur 2 a gagn�");
			getModele().redemarrer();
		}
	}

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
		afficherVainqueur();
	}

}
