/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package tests;

import static org.junit.Assert.*;

import java.awt.Color;

import org.junit.Test;

import hex.Cellule;
import hex.Joueur;

public class TestJoueur {
	
	/**
	 * Permet de savoir si l'action d'ajouter une cellule fonctionne
	 */
	@Test
	public void testAjoutDeCellule(){
		Joueur joueur = new Joueur("Test", Color.BLACK);
		joueur.ajouterCellule(new Cellule(50,50,50,50,Color.BLACK));
		assertEquals(joueur.getCellulesDuJoueur().size(), 1);
		joueur.ajouterCellule(new Cellule(-50,20,-10,3,Color.BLACK));
		joueur.ajouterCellule(new Cellule(-3,48634,950,50,Color.WHITE));
		joueur.ajouterCellule(new Cellule(980,-50,540,565,Color.YELLOW));
		assertEquals(joueur.getCellulesDuJoueur().size(), 4);
	}

}
