package mvc;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public abstract class View extends JFrame implements Observer {

	private Controller controller;
	private Model model;
	
    /**
     * Conteneur de tous les �l�ments
     */
    private JPanel panel;
    /**
     * Texte indiquant l'unit� de la valeur
     */
    private JLabel titre;

	public void update(Observable observable) {

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

	public JLabel getTitre() {
		return titre;
	}

	public void setTitre(JLabel titre) {
		this.titre = titre;
	}
}