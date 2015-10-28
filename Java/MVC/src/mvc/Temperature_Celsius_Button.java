package mvc;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JDesktopPane;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Temperature_Celsius_Button extends View_Button {

	public Temperature_Celsius_Button(Model model, Controller controller, Window window) {

		setModel(model);
		getModel().addObserver(this);
		
		setController(controller);

		getJif().setTitle("Température Celsius");
		getJif().setLocation(0, 0);
		window.getDesktop().add(getJif());
		getJif().setVisible(true);

		getLabel().setText("Température Celsius");

		setDisplay("" + model.getTemperature_celsius());

		addUpListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				getController().upCelsius();
			}
		});
		addDownListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				getController().downCelsius();
			}
		});
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float tempC = getData();
				getController().fixCelsius(tempC);
			}
		});

		JPanel jp1 = new JPanel();
		jp1.setLayout(null);
		jp1.add(getDisplay());
		jp1.add(getLabel());
		jp1.add(getMore());
		jp1.add(getLess());
		jp1.setVisible(true);

		getJif().add(jp1);
	}

	@Override
	public void update(Observable o, Object arg) {
		// setDisplay("" + getModel().getTemperature_celsius());
		
	}

}
