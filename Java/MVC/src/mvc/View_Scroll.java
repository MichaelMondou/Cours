package mvc;

import javax.swing.JSlider;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

public abstract class View_Scroll extends View{
	
	private JSlider slider;
	
	public View_Scroll(){
		slider = new JSlider(1, -50, 50, 0);
		slider.setPaintTicks(true);
		slider.setPaintLabels(true);
		slider.setMajorTickSpacing(10);  
		slider.setVisible(true);
	}

	public JSlider getSlider() {
		return slider;
	}

	public void setSlider(JSlider slider) {
		this.slider = slider;
	}
}
