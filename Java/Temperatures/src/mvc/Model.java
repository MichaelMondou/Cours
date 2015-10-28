package mvc;

import java.util.Observable;

public class Model extends Observable {

	private float temperature_celsius = 20;

	public float getCelsius() {
		return temperature_celsius;
	}

	public void setCelsius(float temperature_celsius) {
		this.temperature_celsius = temperature_celsius;
		setChanged();
		notifyObservers();
	}

	public float getFarenheit() {
		return temperature_celsius * 9 / 5 + 32;
	}

	public void setFarenheit(float temperature_farenheit) {
		temperature_celsius = (temperature_farenheit - 32) * 5 / 9;
		setChanged();
		notifyObservers();
	}
}
