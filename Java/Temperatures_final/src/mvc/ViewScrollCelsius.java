package mvc;

import java.util.Observable;

import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

/**
 * Classe permettant la création d'une sous-fenêtre avec contrôle par scroll de
 * la température en Celsius.
 */
public class ViewScrollCelsius extends ViewScroll {

	ViewScrollCelsius(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);

		/**
		 * Indique la vue actuelle pour le contrôleur.
		 */
		View currentObject = this;

		slider.setValue((int) data);

		/**
		 * Ajoute un écouteur sur le scroll qui va appeler le contrôleur si on
		 * le bouge.
		 */
		slider.addChangeListener(new ChangeListener() {
			public void stateChanged(ChangeEvent arg0) {
				controller.Action(currentObject, Event.SCROLL);
			}
		});
	}

	/**
	 * Permet la mise à jour de la donnée de température.
	 */
	@Override
	public void update(Observable o, Object arg) {
		if (getModel().getCelsius() != data) {
			data = getModel().getCelsius();
			slider.setValue((int) data);
		} else {
			data = slider.getValue();
		}
	}
}
