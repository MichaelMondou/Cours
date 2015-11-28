package tests;

import static org.junit.Assert.*;
import org.junit.Test;
import scolarite.Groupe;
import scolarite.Personne;

public class GroupeTest {

	@Test
	public void testAjoutGroupe() {
		Groupe g = new Groupe();
		Personne a = new Personne("Frodon");
		Personne b = new Personne("Sam");
		Personne c = new Personne("Frodon");
		
		g.add(a);
		assertEquals(g.size(), 1);
		
		g.add(b);
		assertEquals(g.size(), 2);
		
		g.add(c);
		assertEquals(g.size(), 2);
	}
}
