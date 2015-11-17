package mvc;

import java.util.Observable;

import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

/**
 * Classe permettant la cr�ation d'une sous-fen�tre avec contr�le par scroll de
 * la temp�rature en Celsius.
 */
public class ViewScrollCelsius extends ViewScroll {

	ViewScrollCelsius(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);

		/**
		 * Indique la vue actuelle pour le contr�leur.
		 */
		View currentObject = this;

		slider.setValue((int) data);

		/**
		 * Ajoute un �couteur sur le scroll qui va appeler le contr�leur si on
		 * le bouge.
		 */
		slider.addChangeListener(new ChangeListener() {
			public void stateChanged(ChangeEvent arg0) {
				controller.Action(currentObject, Event.SCROLL);
			}
		});
	}

	/**
	 * Permet la mise � jour de la donn�e de temp�rature.
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
