package hex;

import java.awt.Graphics;
import java.util.Observable;

public class ViewHex extends View {

	Click click;

	ViewHex(Window window, Model model, Controller controller) {
		super(window, model, controller);
		paint(panel.getGraphics());
		click = new Click(this, controller);
		panel.addMouseListener(click);
	}

	public void paint(Graphics g) {
		panel.paint(g);
		for (int i = 0; i < getModel().getPlateau().getCell().size(); i++) {
			for (int j = 0; j < getModel().getPlateau().getCell().get(i).size(); j++) {
				g.setColor(getModel().getPlateau().getCell().get(i).get(j).getColor());
				g.fillPolygon(getModel().getPlateau().getCell().get(i).get(j));
			}
		}
	}

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
	}

}
