package mvc;

import java.util.Observable;

/**
 * Mod�le contenant les donn�es � afficher ainsi que les diff�rentes m�thodes de
 * modifications de donn�es.
 *
 */
public class Model extends Observable {

	/**
	 * Temp�rature principale de l'application.
	 */
	private float temperature_celsius = 20;

	public void upCelsius() {
		temperature_celsius++;
		setChanged();
		notifyObservers();
	}

	public void downCelsius() {
		temperature_celsius--;
		setChanged();
		notifyObservers();
	}

	public void fixCelsius(float temperature_celsius) {
		setCelsius(temperature_celsius);
	}

	public void upFarenheit() {
		setFarenheit(getFarenheit() + 1);
		setChanged();
		notifyObservers();
	}

	public void downFarenheit() {
		setFarenheit(getFarenheit() - 1);
		setChanged();
		notifyObservers();
	}

	public void fixFarenheit(float temperature_farenheit) {
		setFarenheit(temperature_farenheit);
	}

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

	/**
	 * Permet de modifier la valeur de la temp�rature en fonction du scroll.
	 */
	public void Scroll(View object) {
		setCelsius(object.getData());
	}
}
