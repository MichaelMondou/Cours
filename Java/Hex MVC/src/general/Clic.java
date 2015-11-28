/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package general;

import java.awt.event.MouseEvent;

import javax.swing.event.MouseInputAdapter;

import hex.Controleur;
import hex.Vue;

public class Clic extends MouseInputAdapter {

	Vue vue;
	Controleur controleur;

	public Clic(Vue vue, Controleur controleur) {
		this.vue = vue;
		this.controleur = controleur;
	}

	public void mouseClicked(MouseEvent clic) {
		controleur.Action(vue, clic);
	}
}
