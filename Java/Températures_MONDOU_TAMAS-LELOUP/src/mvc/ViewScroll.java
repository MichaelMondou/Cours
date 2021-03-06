package mvc;

import javax.swing.JSlider;

/**
 * Classe abstraite permettant de pr�ciser les �l�ments d'une sous-fen�tre avec
 * contr�le par scroll de la temp�rature.
 */
public abstract class ViewScroll extends View {

	/**
	 * Le scroll
	 */
	protected JSlider slider;

	ViewScroll(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);

		getJif().setLocation(320, 0);
		getJif().setSize(310, 350);

		slider = new JSlider();
		slider.setOrientation(1);
		slider.setValue(0);
		slider.setMaximum(50);
		slider.setMinimum(-50);
		slider.setMajorTickSpacing(10);
		slider.setMinorTickSpacing(2);
		slider.setPaintTicks(true);
		slider.setPaintLabels(true);

		getJif().add(slider);
	}
}
