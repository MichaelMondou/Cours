package tests;

import static org.junit.Assert.*;
import org.junit.Test;
import scolarite.Professeur;

public class ProfesseurTest {

	@Test
	public void testProfesseurNom() {
		Professeur p = new Professeur("test");
		// on verifie si le nom du professeur est bien egal a "test"
		assertEquals(p.getNom(), "test");
	}
	
	@Test
	public void testProfesseurNb(){
		int nbTotalProfesseurs = Professeur.getNbTotal();
		@SuppressWarnings("unused")
		Professeur p = new Professeur("test");
		// on verifie si le nombre de professeurs a bien augmente d'un
		assertEquals(Professeur.getNbTotal(),nbTotalProfesseurs+1);
	}

}
