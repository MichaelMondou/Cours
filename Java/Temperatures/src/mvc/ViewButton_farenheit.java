package mvc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

public class ViewButton_farenheit extends ViewButton {
	public ViewButton_farenheit(Model modele, Controller controleur, Window window) {

		super("Temperature Farenheit", modele, controleur, window);
		setDisplay("" + model.getFarenheit());
		getJif().setLocation(0,177);

		addUpListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.upFarenheit();

			}
		});
		addDownListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.downFarenheit();
			}
		});
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float temperature_farenheit = getDisplay();
				controller.fixFarenheit(temperature_farenheit);
			}
		});
	}

	public void update(Observable o, Object arg) {
		setDisplay("" + model().getFarenheit());
	}
}
