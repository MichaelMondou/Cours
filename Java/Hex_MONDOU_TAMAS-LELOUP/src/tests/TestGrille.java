/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package tests;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import exception.NbLignesColonnesException;
import hex.Grille;

public class TestGrille {
	
	Grille grille;
	
	/**
	 * Permet de savoir si le plateau contient bien le nombre de cellules que l'on a définit
	 */
	@Test
	public void testTailleGrille() {
		try {
			grille = new Grille();

		} catch (NbLignesColonnesException ligne_colonne_exception) {
			System.err.println(ligne_colonne_exception);
		}
		
		int nb_cellules = 0;
		for(int i =0; i < Grille.nbLignes; i++){
			for (int j = 0; j < Grille.nbColonnes; j++){
				nb_cellules++;
			}
		}
		assertEquals(nb_cellules, Grille.nbLignes*Grille.nbColonnes);
	}

}
