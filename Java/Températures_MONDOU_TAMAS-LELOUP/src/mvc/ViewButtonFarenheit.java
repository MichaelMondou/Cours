package mvc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

/**
 * Classe permettant la création d'une sous-fenêtre avec contrôle par boutons de
 * la température en Farenheit.
 *
 */
public class ViewButtonFarenheit extends ViewButton {

	/**
	 * Indique la vue actuelle pour le contrôleur.
	 */
	View currentObject = this;

	ViewButtonFarenheit(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);
		getJif().setLocation(0, 175);

		setDisplay("" + model.getFarenheit());

		/**
		 * Ajoute un écouteur sur le bouton "plus" qui va appeler le contrôleur
		 * si on clique sur le bouton.
		 */
		getUpJButton().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.Action(currentObject, Event.UPFARENHEIT);
			}
		});

		/**
		 * Ajoute un écouteur sur le bouton "moins" qui va appeler le contrôleur
		 * si on clique sur le bouton.
		 */
		getDownJButton().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.Action(currentObject, Event.DOWNFARENHEIT);
			}
		});

		/**
		 * Ajoute un écouteur sur le champ de texte qui va modifier la donnée
		 * directement dans le modèle si on la modifie.
		 */
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float temperature_farenheit = getDisplayData();
				model.setFarenheit(temperature_farenheit);
			}
		});
	}

	/**
	 * Permet la mise à jour de la donnée de température.
	 */
	@Override
	public void update(Observable o, Object arg) {
		setDisplay("" + getModel().getFarenheit());
	}
}
