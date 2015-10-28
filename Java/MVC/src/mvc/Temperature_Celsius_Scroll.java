package mvc;

import java.awt.BorderLayout;
import java.util.Observable;

import javax.swing.JPanel;

public class Temperature_Celsius_Scroll extends View_Scroll{
	
	public Temperature_Celsius_Scroll(Model model, Window window){
		
		setModel(model);
		
		getJif().setTitle("Température glissante Celsius");
		getJif().setLocation(325, 0);
		getJif().setSize(305, 350);
		window.getDesktop().add(getJif());
		getJif().setVisible(true);
		
		getLabel().setText("Température glissante Celsius");
		getLabel().setBounds(40, 50, 220, 25);
		
		JPanel jp1 = new JPanel();
		jp1.setLayout(null);
		jp1.add(getLabel());
		jp1.setVisible(true);
		
		getJif().add(jp1);
		getJif().add(getSlider(), BorderLayout.AFTER_LAST_LINE);
	}

	@Override
	public void update(Observable o, Object arg) {
		//setDisplay("" + getModel().getTemperature_celsius());
		
	}
}
