package mvc;

import javax.swing.JFrame;

public class Temperature_Farenheit_Button extends View_Button{
	
	public Temperature_Farenheit_Button(Model model){
		this.setModel(model);
		
	    this.setTitle("Temperature Farenheit");
	    this.setSize(300, 300);
	    this.setLocationRelativeTo(null);               
	    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	    this.setVisible(true);
	}

}