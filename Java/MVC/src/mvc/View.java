package mvc;

import java.awt.BorderLayout;
import java.awt.Font;
import java.awt.Point;
import java.util.ArrayList;
import java.util.Observer;

import javax.swing.JDesktopPane;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public abstract class View extends JFrame implements Observer {

	private Controller controller;
	private Model model;

	private JInternalFrame jif;
	private Font font;
	private JLabel label;

	public View() {
		jif = new JInternalFrame();
		jif.setClosable(true);
		jif.setResizable(true);
		jif.setMaximizable(true);
		jif.setIconifiable(true);

		font = new Font("Serif", Font.PLAIN, 18);

		label = new JLabel();
		label.setFont(getFont());
		label.setBounds(85, 10, 170, 20);
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

	public JInternalFrame getJif() {
		return jif;
	}

	public void setJif(JInternalFrame jif) {
		this.jif = jif;
	}

	public JLabel getLabel() {
		return label;
	}

	public void setLabel(JLabel label) {
		this.label = label;
	}
}
