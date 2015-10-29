package mvc;

import java.awt.BorderLayout;
import java.util.Observer;

import javax.swing.JInternalFrame;
import javax.swing.JLabel;

/**
 * Classe abstraite permettant de paramétrer une sous-fenêtre ajoutée à la
 * fenêtre principale de l'application.
 */
public abstract class View implements Observer {

	private Model model;
	private Controller controller;

	/**
	 * Sous-fenêtre
	 */
	private JInternalFrame jif;
	/**
	 * Etiquette d'indication
	 */
	private JLabel label;

	/**
	 * Donnée indiquant la température actuelle.
	 */
	float data;

	View(Window window, Model model, Controller controller, String title) {
		this.setModel(model);
		model.addObserver(this);
		this.setController(controller);
		jif = new JInternalFrame(title);
		jif.setClosable(true);
		jif.setResizable(true);
		jif.setMaximizable(true);
		jif.setIconifiable(true);
		jif.setSize(320, 175);
		jif.setVisible(true);
		this.label = new JLabel(title);
		getJif().add(this.label, BorderLayout.NORTH);
		window.getDesktop().add(jif);
	}

	public Model getModel() {
		return model;
	}

	public void setModel(Model model) {
		this.model = model;
	}

	public Controller getController() {
		return controller;
	}

	public void setController(Controller controller) {
		this.controller = controller;
	}

	public JInternalFrame getJif() {
		return jif;
	}

	public void setJif(JInternalFrame jif) {
		this.jif = jif;
	}

	public float getData() {
		return data;
	}

	public void setData(float data) {
		this.data = data;
	}
}
