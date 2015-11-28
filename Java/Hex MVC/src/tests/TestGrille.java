/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package tests;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import hex.Grille;

public class TestGrille {
	
	@Test
	public void testTailleGrille() {
		Grille grille = new Grille();
		
		assertEquals(grille.getCellule().size(), Grille.nbLignes);
	}

}
