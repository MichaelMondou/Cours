package mvc;

import java.awt.BorderLayout;
import java.awt.Font;
import java.util.Observer;

import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JSlider;
import javax.swing.event.ChangeListener;

public abstract class ViewScroll implements Observer{
	
	protected Model model;
	protected Controller controller;

	private JLabel label;
	private JInternalFrame jif;
	
	private JSlider display;
	
	private Font font;

	ViewScroll(String label, Model model, Controller controller, Window window) {
		this.model = model;
		this.controller = controller;
		font = new Font("Serif", Font.PLAIN, 18);
		jif = new JInternalFrame(label);
		jif.setFont(font);
		jif.setClosable(true);
		jif.setResizable(true);
		jif.setMaximizable(true);
		jif.setIconifiable(true);
		this.label = new JLabel(label);
		this.label.setFont(font);
		jif.add(this.label,BorderLayout.NORTH);
		display = new JSlider(1, -50, 50, 0);
		display.setPaintTicks(true);
		display.setPaintLabels(true);
		display.setMajorTickSpacing(10);  
		display.setVisible(true);
		display.setFont(font);
		getJif().add(display, BorderLayout.CENTER);
		jif.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		model.addObserver(this); // Connexion entre la vue et le modele
		jif.setSize(315, 355);
		jif.setVisible(true);
		window.getDesktop().add(jif);
	}

	protected Model model() {
		return model;
	}
	
	public JInternalFrame getJif() {
		return jif;
	}

	public void setJif(JInternalFrame jif) {
		this.jif = jif;
	}

	public float getDisplay() {
		int result = 0;
		try {
			result = display.getValue();
		} catch (NumberFormatException e) {
		}
		return result;
	}

	public void addDisplayListener(ChangeListener a) {
		display.addChangeListener(a);
	}
}
