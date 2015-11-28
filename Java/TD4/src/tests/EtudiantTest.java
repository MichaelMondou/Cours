package tests;

import static org.junit.Assert.*;
import org.junit.Test;
import scolarite.Etudiant;

public class EtudiantTest {

	@Test
	public void testEtudiantNom() {
		Etudiant a = new Etudiant("Toto");
		assertEquals(a.getNom(), "Toto");
	}

	public void testEtudiantNb() {
		int nbTotalEtudiants = Etudiant.getNbTotal();
		@SuppressWarnings("unused")
		Etudiant a = new Etudiant();
		assertEquals(Etudiant.getNbTotal(), nbTotalEtudiants+1);
	}

}
