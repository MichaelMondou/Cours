package mvc;

import java.awt.BorderLayout;

import javax.swing.JDesktopPane;
import javax.swing.JFrame;

@SuppressWarnings("serial")
public class Window extends JFrame{
	
	private final JFrame window;
	private final JDesktopPane desktop;
	
	public Window(){
		window = new JFrame();
		window.setTitle("Conversions de températures");
		window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		window.setSize(650, 400);
		window.setLocationRelativeTo(null);
		window.setVisible(true);
		
		desktop = new JDesktopPane();
		window.add(desktop, BorderLayout.CENTER);
	}

	public JFrame getWindow() {
		return window;
	}

	public JDesktopPane getDesktop() {
		return desktop;
	}

}
