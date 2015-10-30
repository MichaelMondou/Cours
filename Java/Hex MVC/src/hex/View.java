package hex;

import java.util.Observer;

import javax.swing.JPanel;

public abstract class View implements Observer {

	private Model model;
	private Controller controller;

	protected Window window;
	protected JPanel panel;

	View(Window window, Model model, Controller controller) {
		this.setModel(model);
		model.addObserver(this);
		this.setController(controller);
		this.window = window;
		panel = window.getPanel();
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
}
