package mvc;

import javax.swing.UIManager;

public class Main {

	public static void main(String args[]) {

		try {
			UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
		} catch (Exception e) {
		}

		Window window = new Window();

		Model model = new Model();
		Controller controller = new Controller(model);

		ViewScrollCelsius vsc = new ViewScrollCelsius(window, model, controller, "Température Scroll Celsius");
		ViewButtonCelsius vbc = new ViewButtonCelsius(window, model, controller, "Température Celsius");
		ViewButtonFarenheit vbf = new ViewButtonFarenheit(window, model, controller, "Température Farenheit");

		model.addObserver(vbc);
		model.addObserver(vbf);
		model.addObserver(vsc);
	}
}
