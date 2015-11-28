import java.util.ArrayList;
import java.util.LinkedList;
import java.util.ListIterator;

public class Main {

	public static void main(String[] args) {
		// exercice45();
		// exercice46();
		// exercice47();
		// exercice48();
		// exercice49();
		// exercice50();
	}

	public static void exercice50() {
		LinkedList<Etudiant> ll = new LinkedList<>();
		ListIterator<Etudiant> li = ll.listIterator(ll.size());

		Etudiant a = new Etudiant("a");
		Etudiant b = new Etudiant("b");
		Etudiant c = new Etudiant("c");
		Etudiant d = new Etudiant("d");

		li.add(a);
		li.add(b);
		li.add(c);
		li.add(d);

		while (li.hasPrevious()) {
			System.out.println(li.previous());
		}
	}

	public static void exercice49() {
		LinkedList<Etudiant> ll = new LinkedList<>();
		ListIterator<Etudiant> li = ll.listIterator();

		Etudiant a = new Etudiant("a");
		Etudiant b = new Etudiant("b");
		Etudiant c = new Etudiant("c");
		Etudiant d = new Etudiant("d");

		li.add(a);
		li.add(b);

		for (Etudiant e : ll) {
			System.out.println(e);
			li.hasNext();
		}

		li.previous();
		li.add(c);

		for (Etudiant e : ll) {
			System.out.println(e);
			li.hasNext();
		}

		li.previous();
		li.add(d);

		for (Etudiant e : ll) {
			System.out.println(e);
			li.hasNext();
		}

		ll.remove(c);

		for (Etudiant e : ll) {
			System.out.println(e);
			li.hasNext();
		}

	}

	public static void exercice48() {
		ArrayList<Personne> personnes = new ArrayList<Personne>();
		Personne a = new Personne();
		Personne b = new Etudiant("Mika");
		Personne c = new Professeur();
		personnes.add(a);
		personnes.add(b);
		personnes.add(c);

		for (Personne p : personnes) {
			p.jamesBond();
		}
	}

	public static void exercice47() {
		/*
		 * Etudiant a = new Etudiant(); Personne b = (Personne)a; // Conversion
		 * ascendante de a
		 * 
		 * Personne c = new Etudiant(); Etudiant d = (Etudiant)c;
		 */
	}

	public static void exercice46() {
		Personne casimir = new Etudiant("Casimir");
		casimir.jamesBond();
	}

	public static void exercice45() {
		// Personne casimir = new Etudiant("Casimir");
		// casimir.jamesBond(); // ne connaît pas
	}

}
