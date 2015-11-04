package mvc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

/**
 * Classe permettant la cr�ation d'une sous-fen�tre avec contr�le par boutons de
 * la temp�rature en Farenheit.
 *
 */
public class ViewButtonFarenheit extends ViewButton {

	/**
	 * Indique la vue actuelle pour le contr�leur.
	 */
	View currentObject = this;

	ViewButtonFarenheit(Window window, Model model, Controller controller, String title) {
		super(window, model, controller, title);
		getJif().setLocation(0, 175);

		setDisplay("" + model.getFarenheit());

		/**
		 * Ajoute un �couteur sur le bouton "plus" qui va appeler le contr�leur
		 * si on clique sur le bouton.
		 */
		getUpJButton().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.Action(currentObject, Event.UPFARENHEIT);
			}
		});

		/**
		 * Ajoute un �couteur sur le bouton "moins" qui va appeler le contr�leur
		 * si on clique sur le bouton.
		 */
		getDownJButton().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				controller.Action(currentObject, Event.DOWNFARENHEIT);
			}
		});

		/**
		 * Ajoute un �couteur sur le champ de texte qui va modifier la donn�e
		 * directement dans le mod�le si on la modifie.
		 */
		addDisplayListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				float temperature_farenheit = getDisplayData();
				model.setFarenheit(temperature_farenheit);
			}
		});
	}

	/**
	 * Permet la mise � jour de la donn�e de temp�rature.
	 */
	@Override
	public void update(Observable o, Object arg) {
		setDisplay("" + getModel().getFarenheit());
	}
}
