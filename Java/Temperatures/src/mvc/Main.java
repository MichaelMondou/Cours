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
		
		Controller celsius_button_controller = new Controller(model);
		ViewButton_celsius vbc = new ViewButton_celsius(model, celsius_button_controller, window);
		celsius_button_controller.addViewButton(vbc);
		

		Controller farenheit_button_controller = new Controller(model);
		ViewButton_farenheit vbf = new ViewButton_farenheit(model, farenheit_button_controller, window);
		farenheit_button_controller.addViewButton(vbf);
		
		Controller celsius_scroll_controller = new Controller(model);
		ViewScroll_celsius vsc = new ViewScroll_celsius(model, celsius_scroll_controller, window);
		celsius_scroll_controller.addViewScroll(vsc);
	}
}
