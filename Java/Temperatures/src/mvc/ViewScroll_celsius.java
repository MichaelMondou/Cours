package mvc;

import java.util.Observable;

import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

public class ViewScroll_celsius extends ViewScroll{
	
	public ViewScroll_celsius(Model modele, Controller controleur, Window window) {

		super("Temperature Celsius", modele, controleur, window);

		getJif().setLocation(320,0);
		
		addDisplayListener(new ChangeListener() {
			public void stateChanged(ChangeEvent e) {
				float temperature_celsius = getDisplay();
				controller.fixCelsius(temperature_celsius);
			}
		});
	}

	public void update(Observable o, Object arg) {
		
	}

}
