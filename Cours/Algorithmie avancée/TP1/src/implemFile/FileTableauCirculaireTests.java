package implemFile;

import static org.junit.Assert.*;

import java.util.Collection;
import java.util.HashSet;
import java.util.Iterator;
import java.util.NoSuchElementException;
import java.util.Queue;

import org.junit.Rule;
import org.junit.Test;
import org.junit.rules.ExpectedException;

/**
 * Quelques tests unitaires pour une implémentation de l'interface 
 * java.util.Queue<Integer> où l'insertion de null est interdite. 
 * Limitation : on ne teste pas toujours les dépassements de capacité 
 * (non accessible via l'interface java.util.Queue).
 * 
 * On supposera tout de même que la capacité est inférieure à capaciteMax.
 *
 * @author Olivier Gauwin
 */
public class FileTableauCirculaireTests {

	private final int capaciteMax = 1000;
	
	@Rule
	public ExpectedException exception = ExpectedException.none();

	@Test
	public void testAddAll() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		Collection<Integer> integers = new HashSet<Integer>();
		f.addAll(integers);
		assertTrue("La file doit contenir l'ensemble vide", f.containsAll(integers));					
		
		integers.add(21);
		integers.add(53);
		assertFalse("La file ne doit pas contenir 21 et 53", f.containsAll(integers));					

		f.addAll(integers);
		assertTrue("La file doit contenir 21 et 53", f.containsAll(integers));			
		assertFalse("La file ne doit pas contenir 11", f.contains(11));
	}

	/**
	 * Ajout d'une collection null.
	 */
	@Test
	public void testAddAllException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		exception.expect(NullPointerException.class);
		f.addAll(null);
	}

	/**
	 * Ajout d'une collection contenant null.
	 */
	@Test
	public void testAddAllException2() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(null);

		exception.expect(NullPointerException.class);
		f.addAll(integers);
	}

	@Test
	public void testClear() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(13);
		f.add(12);
		assertFalse("La file ne doit pas être vide", f.isEmpty());

		f.clear();
		assertTrue("La file doit être vide", f.isEmpty());
	}

	@Test
	public void testContains() {
		Queue<Integer> f = new FileTableauCirculaire();

		assertFalse("La file ne doit pas contenir 12", f.contains(12));
		
		if (f.add(17)) {
			assertTrue("La file doit contenir 17", f.contains(17));			
			assertFalse("La file ne doit pas contenir 12", f.contains(12));			
		}
		if (f.add(12)) {
			assertTrue("La file doit contenir 17", f.contains(17));			
			assertTrue("La file doit contenir 12", f.contains(12));			
		}

		exception.expect(NullPointerException.class);
		f.contains(null);
	}

	@Test
	public void testContainsAll() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(53);
		f.add(13);
		f.add(21);
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(21);
		integers.add(53);
		assertTrue("La file doit contenir 21 et 53", f.containsAll(integers));			
		integers.clear();
		integers.add(21);
		integers.add(52);
		assertFalse("La file ne doit pas contenir 21 et 52", 
				f.containsAll(integers));			
		integers.clear();
		assertTrue("La file ne doit pas contenir le contenu de l'ensemble vide", 
				f.containsAll(integers));
		f.clear();
		integers.add(21);
		integers.add(53);
		assertFalse("La file vide ne doit rien contenir", 
				f.containsAll(integers));

		// test avec null
		integers.add(null);
		exception.expect(NullPointerException.class);
		f.containsAll(integers);
	}

	@Test
	public void testIsEmpty() {
		Queue<Integer> f = new FileTableauCirculaire();
		assertTrue("A new queue is empty", f.isEmpty());
		
		f.add(0);
		assertFalse("A queue with one element is not empty", f.isEmpty());

		f.clear();
		assertTrue("A cleared queue is empty", f.isEmpty());
	}

	@Test
	public void testIterator() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(22);
		f.add(1);
		Iterator<Integer> it = f.iterator();
		assertTrue("Iterator is not empty", it.hasNext());
		Integer i = it.next();
		assertEquals("First element should be 22", 22, (int)i);
		assertTrue("Iterator still has an element", it.hasNext());
		i = it.next();
		assertEquals("Second element should be 1", 1, (int)i);
		assertFalse("Iterator has no more element.", it.hasNext());
	}

	@Test
	public void testRemoveObject() {
		Queue<Integer> f = new FileTableauCirculaire();
		boolean b;
		
		b = f.remove(0);
		assertFalse("Removing an element not in the collection returns false",
				b);
		
		f.add(0);
		b = f.remove(0);
		assertTrue("Removing an element in the collection returns true",
				b);
		assertFalse("Removing an element in the collection works",
				f.contains(0));
	}

	/**
	 * Supprimer null doit retourner un NullPointerException.
	 */
	@Test
	public void testRemoveObjectException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		exception.expect(NullPointerException.class);
		f.remove(null);		
	}

	@Test
	public void testRemoveAll() {
		Queue<Integer> f = new FileTableauCirculaire();

		for (int i=0; i<10; i++) {
			f.add(i);
		}
		
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(4);
		integers.add(14);
		f.removeAll(integers);
		assertTrue("La file doit contenir 2", f.contains(2));		
		assertFalse("La file ne doit pas contenir 4.", f.contains(4));					
		assertFalse("La file ne doit pas contenir 14.", f.contains(14));					
	}

	/**
	 * Suppression d'une collection null.
	 */
	@Test
	public void testRemoveAllException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		exception.expect(NullPointerException.class);
		f.removeAll(null);
	}

	/**
	 * Suppression d'une collection contenant null.
	 */
	@Test
	public void testRemoveAllException2() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(null);

		exception.expect(NullPointerException.class);
		f.removeAll(integers);
	}

	@Test
	public void testRetainAll() {
		Queue<Integer> f = new FileTableauCirculaire();

		for (int i=0; i<10; i++) {
			f.add(i);
		}
		
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(4);
		integers.add(14);
		f.retainAll(integers);
		assertFalse("La file ne doit pas contenir 2.", f.contains(2));		
		assertTrue("La file doit contenir 4.", f.contains(4));					
		assertFalse("La file ne doit pas contenir 14.", f.contains(14));					
	}

	/**
	 * Ne garder qu'une collection null.
	 */
	@Test
	public void testRetainAllException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		exception.expect(NullPointerException.class);
		f.retainAll(null);
	}

	/**
	 * Ne garder qu'une collection contenant null.
	 */
	@Test
	public void testRetainAllException2() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		Collection<Integer> integers = new HashSet<Integer>();
		integers.add(null);

		exception.expect(NullPointerException.class);
		f.retainAll(integers);
	}

	@Test
	public void testSize() {
		Queue<Integer> f = new FileTableauCirculaire();
		assertEquals("File vide : taille zero", 0, f.size());
		f.add(11);
		assertEquals("File avec un element : taille 1", 1, f.size());
		f.add(22);
		assertEquals("File avec deux elements : taille 2", 2, f.size());
		f.remove(22);
		assertEquals("File avec un element : taille 1", 1, f.size());		
	}

	@Test
	public void testToArray() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(11);
		f.add(22);
		Object[] array = f.toArray();
		assertEquals("toArray renvoie un tableau dont la taille est le nombre d'éléments", 2, array.length);
		assertEquals("Tableau, case 1", 11, array[0]);
		assertEquals("Tableau, case 2", 22, array[1]);
	}

	@Test
	public void testToArrayTArray() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(11);
		f.add(22);
		Integer arrayArg[] = new Integer[4];
		Integer[] array = f.toArray(arrayArg);
		assertEquals("Tableau, case 1", 11, (int)arrayArg[0]);
		assertEquals("Tableau, case 2", 22, (int)arrayArg[1]);
		assertEquals("Tableau, case 3", null, arrayArg[2]);
		
		f.add(33);
		f.add(44);
		f.add(55);
		array = f.toArray(arrayArg);
		assertEquals("Taille tableau retourné", 5, array.length);
		assertEquals("Tableau, case 1", 11, (int)array[0]);
		assertEquals("Tableau, case 2", 22, (int)array[1]);
		assertEquals("Tableau, case 3", 33, (int)array[2]);
		assertEquals("Tableau, case 4", 44, (int)array[3]);
		assertEquals("Tableau, case 5", 55, (int)array[4]);
	}

	@Test
	public void testAdd() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		// cas normal
		boolean b = f.add(11);
		assertTrue("La file doit accepter l'ajout de 11", b);
		assertTrue("La file doit contenir 11", f.contains(11));
	}
	
	/**
	 * L'insertion de null est interdite.
	 */
	@Test
	public void testAddException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		exception.expect(NullPointerException.class);
		f.add(null);
	}	

	/**
	 * Le dépassement de capacité lève une IllegalStateException.
	 * On suppose que la capacité est inférieure au domaine des Long.
	 */
	@Test
	public void testAddException2() {
		Queue<Integer> f = new FileTableauCirculaire();

		int cpt = 0;
		exception.expect(IllegalStateException.class);
		while (cpt <= capaciteMax) {
			f.add(0);
			cpt++;
		}
	}	

	/**
	 * Test de add itéré.
	 */
	@Test
	public void testAddRemove() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		// cas normal
		boolean b;
		for (int i=1; i<=1000; i++) {
			b = f.add(i);
			assertTrue("La file doit accepter l'ajout de 11", b);
			assertTrue("La file doit contenir i", f.contains(i));
			assertEquals("On doit retrouver l'élément inséré", i, 
				(int)f.remove());
			assertFalse("La file ne doit pas contenir i", f.contains(i));
		}
	}

	/**
	 * On remplit la file, puis on la vide.
	 */
	@Test
	public void testFillEmpty() {
		Queue<Integer> f = new FileTableauCirculaire();

		int capacite = 0;
		try {
			while (capacite <= capaciteMax) { 
				f.add(1);
				capacite++;
			}
		}
		catch (IllegalStateException e) {}

		// la file est pleine : j'en enlève un et le remplace
		assertEquals("On doit retrouver l'élément 1", 1, 
				(int)f.remove());
		assertTrue("On doit pouvoir insérer à nouveau", f.add(2));

		// on vide la file
		for (int i = 1; i< capacite; i++) {
			assertEquals("On doit retrouver 1", 1, (int)f.remove());
		}
		assertEquals("On doit retrouver 2", 2, (int)f.remove());
	}

	@Test
	public void testElement() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(3);
		f.add(4);
		Integer i = f.element();
		assertTrue("Apres element(), la file contient toujours 3", 
				f.contains(3));
		assertTrue("Apres element(), la file contient toujours 4", 
				f.contains(4));
		assertEquals("Apres element(), la file contient toujours 3 en tête", 3,
				(int)f.peek());
		assertEquals("element() renvoie bien la tête", 3, (int)i);
	}

	/**
	 * NullPointerException si on appelle element() sur une file vide. 
	 */
	@Test
	public void testElementException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		exception.expect(NoSuchElementException.class);
		f.element();
	}

	@Test
	public void testOffer() {
		Queue<Integer> f = new FileTableauCirculaire();
		
		// cas normal
		boolean b = f.offer(11);
		assertTrue("La file doit accepter l'ajout de 11", b);
		assertTrue("La file doit contenir 11", f.contains(11));
		
		// insertion de null
		exception.expect(NullPointerException.class);
		b = f.offer(null);
	}

	@Test
	public void testPeek() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(3);
		f.add(4);
		Integer i = f.peek();
		assertTrue("Apres peek(), la file contient toujours 3", f.contains(3));
		assertTrue("Apres peek(), la file contient toujours 4", f.contains(4));
		assertEquals("Apres peek(), la file contient toujours 3 en tête", 3,
				(int)f.element());
		assertEquals("peek() renvoie bien la tête", 3, (int)i);
		
		f.clear();
		i = f.peek();
		assertEquals("peek() renvoie null sur file vide", null, i);
	}

	@Test
	public void testPoll() {
		Queue<Integer> f = new FileTableauCirculaire();
		Integer i = f.poll();
		assertEquals("poll() renvoie null sur file vide", null, i);
		
		f.add(24);
		f.add(25);
		i = f.poll();
		assertEquals("poll() renvoie la tête", 24, (int)i);
		assertFalse("poll() supprime la tête", f.contains(24));
		assertTrue("poll() supprime uniquement la tête", f.contains(25));
	}

	@Test
	public void testRemove() {
		Queue<Integer> f = new FileTableauCirculaire();
		f.add(24);
		f.add(25);
		Integer i = f.remove();
		assertEquals("remove() renvoie la tête", 24, (int)i);
		assertFalse("remove() supprime la tête", f.contains(24));
		assertTrue("remove() supprime uniquement la tête", f.contains(25));		
	}

	@Test
	public void testRemoveException1() {
		Queue<Integer> f = new FileTableauCirculaire();
		exception.expect(NoSuchElementException.class);
		f.remove();
	}

}