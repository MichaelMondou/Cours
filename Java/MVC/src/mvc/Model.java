package mvc;

import java.util.ArrayList;
import java.util.Observable;

public class Model extends Observable {

	private ArrayList<Controller> model_controllers = new ArrayList<Controller>();
	private ArrayList<View> views = new ArrayList<View>();

	private float temperature_celsius = 20;
	private float temperature_farenheit = (temperature_celsius * 9 / 5) + 32;

	public void nextData() {

	}

	public float getTemperature_celsius() {
		return temperature_celsius;
	}

	public float getTemperature_farenheit() {
		return temperature_farenheit;
	}

	public void setTemperature_celsius(float temperature_celsius) {
		this.temperature_celsius = temperature_celsius;
		this.setChanged();
		this.notifyObservers();
	}

	public void upTemperature_celsius(float temperature_celsius) {
		this.temperature_celsius = this.temperature_celsius + temperature_celsius;
		this.setChanged();
		this.notifyObservers();
	}

	public void downTemperature_celsius(float temperature_celsius) {
		this.temperature_celsius = this.temperature_celsius - temperature_celsius;
	}

	public void upTemperature_farenheit(float temperature_farenheit) {
		this.temperature_farenheit = this.temperature_farenheit + temperature_farenheit;
	}

	public void downTemperature_farenheit(float temperature_farenheit) {
		this.temperature_farenheit = this.temperature_farenheit - temperature_farenheit;
	}

	public void setTemperature_farenheit(float temperature_farenheit) {
		this.temperature_farenheit = temperature_farenheit;
		setChanged();
		notifyObservers();
	}
}
