package mvc;

import java.awt.BorderLayout;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.util.Observer;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public abstract class ViewButton implements Observer {

	protected Model model;
	protected Controller controller;

	private JLabel label;
	private JInternalFrame jif;
	
	private JTextField display;
	
	private JPanel panelbuttons;
	private JButton upJButton;
	private JButton downJButton;
	
	private Font font;

	ViewButton(String label, Model model, Controller controller, Window window) {
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
		panelbuttons = new JPanel();
		upJButton = new JButton("+");
		downJButton = new JButton("-");
		panelbuttons.setFont(font);
		panelbuttons.add(upJButton);
		panelbuttons.add(downJButton);
		getJif().add(panelbuttons, BorderLayout.SOUTH);
		display = new JTextField();
		display.setFont(font);
		getJif().add(display, BorderLayout.CENTER);
		jif.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		model.addObserver(this); // Connexion entre la vue et le modele
		jif.setSize(320, 175);
		jif.setVisible(true);
		window.getDesktop().add(jif);
	}

	public JPanel getPanelbuttons() {
		return panelbuttons;
	}

	public void setPanelbuttons(JPanel panelbuttons) {
		this.panelbuttons = panelbuttons;
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
	
	public void setDisplay(String s) {
		display.setText(s);
	}

	public float getDisplay() {
		float result = 0;
		try {
			result = Float.valueOf(display.getText());
		} catch (NumberFormatException e) {
		}
		return result;
	}

	public void addDisplayListener(ActionListener a) {
		display.addActionListener(a);
	}
	
	public void addUpListener(ActionListener a) {
		upJButton.addActionListener(a);
	}

	public void addDownListener(ActionListener a) {
		downJButton.addActionListener(a);
	}
}
