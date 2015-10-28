package mvc;

import java.awt.BorderLayout;

import javax.swing.JDesktopPane;
import javax.swing.JFrame;
import javax.swing.UIManager;

public class Main {

	public static void main(String[] arg) {

		try {
			UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
		} catch (Exception e) {
		}

		Window window = new Window();

		Model model = new Model();
		
		Controller button_controller = new Controller(model);
		Controller scroll_controller = new Controller(model);

		Temperature_Celsius_Button tcb = new Temperature_Celsius_Button(model, button_controller, window);
		Temperature_Farenheit_Button tfb = new Temperature_Farenheit_Button(model, button_controller, window);
		Temperature_Celsius_Scroll tcs = new Temperature_Celsius_Scroll(model, window);
		
		button_controller.addView(tcb);
		button_controller.addView(tfb);
		scroll_controller.addView(tcs);

	}

}
