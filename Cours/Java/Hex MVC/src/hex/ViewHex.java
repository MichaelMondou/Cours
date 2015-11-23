package hex;

import java.awt.Graphics;
import java.util.Observable;

import javax.swing.JOptionPane;

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
		for (int i = 0; i < getModel().getBoard().getCell().size(); i++) {
			for (int j = 0; j < getModel().getBoard().getCell().get(i).size(); j++) {
				g.setColor(getModel().getBoard().getCell().get(i).get(j).getColor());
				g.fillPolygon(getModel().getBoard().getCell().get(i).get(j));
			}
		}
	}
	
	public void showTheWinner(){
		if(getModel().who_is_the_winner == Event.BLACK_WINNER){
			JOptionPane.showMessageDialog(null, "Le joueur 1 a gagn�");
			getModel().restart();
		}
		else if(getModel().who_is_the_winner == Event.WHITE_WINNER){
			JOptionPane.showMessageDialog(null, "Le joueur 2 a gagn�");
			getModel().restart();
		}
	}

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
		showTheWinner();
	}

}
