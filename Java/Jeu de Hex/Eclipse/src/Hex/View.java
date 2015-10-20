package Hex;

import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class View extends JFrame implements Observer {

	private Controller controller;
	private Model model;

	/**
	 * Conteneur de tous les �l�ments
	 */
	private JPanel panel;

	public View(Model model) {
		setTitle("Hex");
		setSize(1280, 720);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		this.model = model;
		setPanel(new JPanel());

		setVisible(true);
	}

	public void update(Observable observable) {

	}

	public void paint(Graphics g) {
		super.paint(g);
		for (int i = 0; i < model.getPlateau().cellules.size(); i++) {
			for (int j = 0; j < model.getPlateau().cellules.get(i).size(); j++) {
				model.getPlateau().cellules.get(i).get(j).creerPolygone();
				g.fillPolygon(model.getPlateau().cellules.get(i).get(j));
			}
		}
		
	}

	public Controller getController() {
		return controller;
	}

	public void setController(Controller controller) {
		this.controller = controller;
	}

	public Model getModel() {
		return model;
	}

	public void setModel(Model model) {
		this.model = model;
	}

	public JPanel getPanel() {
		return panel;
	}

	public void setPanel(JPanel panel) {
		this.panel = panel;
	}

}