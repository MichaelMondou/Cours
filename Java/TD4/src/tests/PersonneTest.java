package tests;

import static org.junit.Assert.*;
import org.junit.Test;
import scolarite.Personne;

public class PersonneTest {

	@Test
	public void testPersonneNom() {
		Personne a = new Personne("Toto");
		assertEquals(a.getNom(), "Toto");
	}

	public void testPersonneNb() {
		int nbTotalPersonnes = Personne.getNbTotal();
		@SuppressWarnings("unused")
		Personne a = new Personne();
		assertEquals(Personne.getNbTotal(), nbTotalPersonnes+1);
	}

}
