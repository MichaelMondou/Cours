package hex;

import javax.swing.JFrame;
import javax.swing.JPanel;

/**
 * Fenêtre principale de l'application
 */
@SuppressWarnings("serial")
public class Window extends JFrame {

	/**
	 * Fenêtre
	 */
	private final JFrame window;
	private final JPanel panel;

	public Window(String title, int largeur, int hauteur) {
		window = new JFrame();
		window.setTitle(title);
		window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		window.setSize(largeur, hauteur);
		window.setLocationRelativeTo(null);
		window.setResizable(false);
		panel = new JPanel();
		window.add(panel);
		window.setVisible(true);
	}

	public JPanel getPanel() {
		return panel;
	}

	public JFrame getWindow() {
		return window;
	}
}
