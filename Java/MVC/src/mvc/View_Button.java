package mvc;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public abstract class View_Button extends View{

	/**
	 * Champ de la température
	 */
	private JTextField champ;
	/**
	 * Bouton augmentant la température
	 */
	private JButton up;
	/**
	 * Bouton baissant la température
	 */
    private JButton down;
    
	public JButton getUp() {
		return up;
	}
	public void setUp(JButton up) {
		this.up = up;
	}
	public JButton getDown() {
		return down;
	}
	public void setDown(JButton down) {
		this.down = down;
	}
	public JTextField getChamp() {
		return champ;
	}
	public void setChamp(JTextField champ) {
		this.champ = champ;
	}
	
}
