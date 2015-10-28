package mvc;

public class Controller {
	private Model model;
	public Controller(Model m) {
		model = m;
	}

	public void upCelsius() {
		model.setCelsius(model.getCelsius() + 1);
	}

	public void downCelsius() {
		model.setCelsius(model.getCelsius() - 1);
	}

	public void fixCelsius(float temperature_celsius) {
		model.setCelsius(temperature_celsius);
	}

	public void upFarenheit() {
		model.setFarenheit(model.getFarenheit() + 1);
	}

	public void downFarenheit() {
		model.setFarenheit(model.getFarenheit() - 1);
	}

	public void fixFarenheit(float temperature_farenheit) {
		model.setFarenheit(temperature_farenheit);
	}

	public void addViewButton(ViewButton viewButton) {
	}
	
	public void addViewScroll(ViewScroll viewScroll) {
	}
}
