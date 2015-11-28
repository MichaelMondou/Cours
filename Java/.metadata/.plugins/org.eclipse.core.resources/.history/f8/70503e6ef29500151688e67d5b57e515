package hex;

import java.awt.event.MouseEvent;

import javax.swing.event.MouseInputAdapter;

public class Clic extends MouseInputAdapter {

	Vue vue;
	Contrôleur controleur;

	public Clic(Vue vue, Contrôleur controleur) {
		this.vue = vue;
		this.controleur = controleur;
	}

	public void mouseClicked(MouseEvent clic) {
		controleur.Action(vue, clic);
	}
}
