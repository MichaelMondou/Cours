package mvc;

import java.util.ArrayList;

public class Model extends Observable {

	private ArrayList<Controller> model_controllers = new ArrayList<Controller>();
	private ArrayList<View> views = new ArrayList<View>();

	private float temperature_celsius;
	private float temperature_farenheit;

	private boolean up;
	private boolean down;

	public void initialisation() {
		temperature_celsius = 20;
		temperature_farenheit = (temperature_celsius * 9 / 5) + 32;
	}

	public void nextData() {

	}

	public float getTemperature_celsius() {
		return temperature_celsius;
	}

	public float getTemperature_farenheit() {
		return temperature_farenheit;
	}

	public void setTemperatures() {
		if (up) {
			temperature_celsius += 1;
		} else {
			temperature_celsius -= 1;
		}
		temperature_farenheit = (temperature_celsius * 9 / 5) + 32;
	}

}