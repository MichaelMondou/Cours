package mvc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

import javax.swing.BoxLayout;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class Temperature_Farenheit_Button extends View_Button {

	public Temperature_Farenheit_Button(Model model, Controller controller, Window window) {

		setModel(model);
		getModel().addObserver(this);
		
		setController(controller);

		getJif().setTitle("Température Farenheit");
		getJif().setLocation(0, 175);
		window.getDesktop().add(getJif());
		getJif().setVisible(true);
		
		getLabel().setText("Température Farenheit");
		
		setDisplay("" + model.getTemperature_farenheit());

		addUpListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				getController().upFarenheit();
			}
		});
		addDownListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				getController().downFarenheit();
			}
		});
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float tempF = getData();
				getController().fixFarenheit(tempF);
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
	public void update(Observable arg0, Object arg1) {
		setDisplay("" + getModel().getTemperature_farenheit());
	}

}
