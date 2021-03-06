package mvc;

import java.awt.BorderLayout;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 * Classe abstraite permettant de pr�ciser les �l�ments d'une sous-fen�tre avec
 * contr�le par boutons de la temp�rature.
 */
public abstract class ViewButton extends View {

	/**
	 * Le champ dans lequel la temp�rature est affich�e.
	 */
	private JTextField display;

	/**
	 * Le panneau contenant les diff�rents boutons.
	 */
	private JPanel panelbuttons;
	/**
	 * Le bouton "plus".
	 */
	private JButton upJButton;
	/**
	 * Le bouton "moins".
	 */
	private JButton downJButton;

	ViewButton(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);

		panelbuttons = new JPanel();
		upJButton = new JButton("+");
		downJButton = new JButton("-");

		panelbuttons.add(upJButton);
		panelbuttons.add(downJButton);

		getJif().add(panelbuttons, BorderLayout.SOUTH);

		display = new JTextField();
		getJif().add(display, BorderLayout.CENTER);
	}

	public void setDisplay(String s) {
		display.setText(s);
	}

	public JTextField getDisplay() {
		return display;
	}

	/**
	 * Permet de retourner la valeur contenue dans le champ de texte en la
	 * convertissant en float.
	 */
	public float getDisplayData() {
		float result = 0;
		try {
			result = Float.valueOf(display.getText());
		} catch (NumberFormatException e) {
		}
		return result;
	}

	/**
	 * Permet l'ajout d'un �couteur sur la valeur de la temp�rature indiqu�e
	 * dans le champ.
	 */
	public void addDisplayListener(ActionListener a) {
		display.addActionListener(a);
	}

	public JButton getUpJButton() {
		return upJButton;
	}

	public JButton getDownJButton() {
		return downJButton;
	}

}
