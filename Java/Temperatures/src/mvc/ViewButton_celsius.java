package mvc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

public class ViewButton_celsius extends ViewButton {
	public ViewButton_celsius(Model modele, Controller controleur, Window window) {

		super("Temperature Celsius", modele, controleur, window);
		setDisplay("" + model.getCelsius());

		getJif().setLocation(0,0);

		addUpListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.upCelsius();

			}
		});
		addDownListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.downCelsius();
			}
		});
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float temperature_celsius = getDisplay();
				controller.fixCelsius(temperature_celsius);
			}
		});
	}

	public void update(Observable o, Object arg) {
		setDisplay("" + model().getCelsius());
	}
}
