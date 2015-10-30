package hex;

import java.awt.Graphics;
import java.util.Observable;

public class ViewHex extends View{

	ViewHex(Window window, Model model, Controller controller) {
		super(window, model, controller);
		paint(panel.getGraphics());
	}
	
	

	public void paint(Graphics g) {
		panel.paint(g);
		for (int i = 0; i < getModel().getPlateau().cellules.size(); i++) {
			for (int j = 0; j < getModel().getPlateau().cellules.get(i).size(); j++) {
				getModel().getPlateau().cellules.get(i).get(j).creerPolygone();
				g.setColor(getModel().getPlateau().cellules.get(i).get(j).getCouleur());
				g.fillPolygon(getModel().getPlateau().cellules.get(i).get(j));
			}
		}
	}
	
	

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
	}

}
