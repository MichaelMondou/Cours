package mvc;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Temperature_Celsius_Button extends View_Button {

	public Temperature_Celsius_Button(Model model) {

		setModel(model);

		setTitle("Temperature Celsius");
		setSize(300, 300);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		setPanel(new JPanel());
		setUp(new JButton("+"));
		setDown(new JButton("-"));
		setTitre(new JLabel("Temperature Celsius"));
		setChamp(new JTextField());
		
		getPanel().setLayout(new FlowLayout());
		
		add(getTitre());
		add(getUp());
		add(getDown());

		setVisible(true);

	}

}