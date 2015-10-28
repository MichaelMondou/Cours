package mvc;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public abstract class View_Button extends View {

	private JTextField display;

	private JButton more;
	private JButton less;

	public View_Button() {
		getJif().setSize(325, 175);

		display = new JTextField();
		display.setFont(getFont());
		display.setBounds(65, 50, 200, 30);

		more = new JButton("+");
		more.setFont(getFont());
		more.setBounds(110, 90, 50, 30);

		less = new JButton("-");
		less.setFont(getFont());
		less.setBounds(170, 90, 50, 30);

	}

	public JTextField getDisplay() {
		return display;
	}

	public void setDisplay(String s) {
		display.setText(s);
	}

	public float getData() {
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
		more.addActionListener(a);
	}

	public void addDownListener(ActionListener a) {
		less.addActionListener(a);
	}

	public JButton getMore() {
		return more;
	}

	public JButton getLess() {
		return less;
	}

}
