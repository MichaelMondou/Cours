package exercices;

import java.io.IOException;
import java.util.ArrayList;

public class Exercices {

	public static void main(String[] args) {
		// exercice5();
		// Projet p = exercice6();
		// System.out.println(mystere(p));
		// exercice7();
		// exercice8(p);
		// exercice9();
		// exercice10();
		// exercice12();
		// exercice13();
		// exercice14();
		// exercice16();
		// exercice17();
		// exercice18();
		// exercice19();
		exercice20();
	}

	public static void exercice20() {
		String chemin = "src/exercices/fichier.txt";
		try { // pour la gestion des erreurs de lecture
			java.io.BufferedReader f = new java.io.BufferedReader(new java.io.FileReader(chemin));
			// création d'un lecteur de fichier f par blocs (pour les lignes)
			String ligne;
			while ((ligne = f.readLine()) != null) { // lecture de la ligne
				// si la ligne est vide (null), la fin du fichier a été atteinte
				System.out.println(ligne);
			}
			f.close();
		} catch (IOException e) {
			System.out.println("erreur de lecture du fichier");
			// si la lecture de fichier échoue (par exemple si le fichier
			// n'existe pas), affiche un message d'erreur
		}

	}

	public static void exercice19() {
		Etudiant[] tableau = new Etudiant[5];
		tableau[0] = new Etudiant("Frodon");
		tableau[1] = new Etudiant("Gandalf");
		tableau[2] = new Etudiant("Sam");
		tableau[3] = new Etudiant("Gollum");
		tableau[4] = new Etudiant("Pippin");

		for (int i = 0; i < tableau.length; i++) {
			System.out.println(tableau[i]);
		}
	}

	public static void exercice18() {
		Etudiant a = new Etudiant("Frodon");
		Etudiant b = new Etudiant("Gandalf");
		Etudiant c = new Etudiant("Sam");
		Etudiant d = new Etudiant("Gollum");
		Etudiant e = new Etudiant("Pippin");

		ArrayList<Etudiant> etudiants = new ArrayList<Etudiant>();
		etudiants.add(a);
		etudiants.add(b);
		etudiants.add(c);
		etudiants.add(d);
		etudiants.add(e);

		for (Etudiant f : etudiants) {
			System.out.println(f);
		}
	}

	public static void exercice17() {
		int i = Integer.parseInt("127");
		System.out.println(i);
		Integer z = i + 1;
		System.out.println(z);
		int j = z.intValue();
		System.out.println(j);
		Integer k = 127 + 73;
		System.out.println(k);
		/*
		 * int l = Integer.parseInt("127+73"); System.out.println(l);
		 */
	}

	public static void exercice16() {
		Binome b = new Binome();
		System.out.println(b);

		Etudiant a = new Etudiant("Bob");
		Etudiant c = new Etudiant("Marley");
		Binome bi = new Binome(a, c);
		System.out.println(bi);

		Projet pi = new Projet(bi, "Projet en binome", 18);
		System.out.println(pi);

	}

	public static String nomEtudiants(Etudiant a, Etudiant b) {
		String resultat;
		resultat = a.nom + " " + b.nom;
		return resultat;
	}

	public static void exercice14() {
		Projet p = new Projet();
		p.b = new Binome();
		p.b.etu1 = new Etudiant();
		p.b.etu2 = new Etudiant();
		p.b.etu1.nom = "Sauron";
		p.b.etu2.nom = "Frodon";
		String noms = nomEtudiants(p.b.etu1, p.b.etu2);
		System.out.println(noms);
	}

	public static void exercice13() {
		Binome bi = new Binome();
		System.out.println(bi.etu1.nom);
		System.out.println(bi);
	}

	public static void exercice12() {
		Etudiant a = new Etudiant();
		a.nom = "Alphonse";
		a.setNom("Bob");
		System.out.println(a);
	}

	public static void exercice10() {
		Etudiant b = new Etudiant();
		b.nom = "Bob";
		//String s = b.getNom();

		Projet p = exercice6();
		System.out.println(p.getTitre());
	}

	public static void exercice9() {
		Etudiant b = new Etudiant();
		b.nom = "Bob";
		Etudiant a = new Etudiant();
		a.nom = "Alphonse";

		Binome bi = new Binome();
		bi.etu1 = a;
		bi.etu2 = b;
		System.out.println(bi);
	}

	public static void exercice8(Projet p) {
		System.out.println(p);
	}

	public static void exercice7() {
		Etudiant a = new Etudiant();
		a.nom = "Alphonse";
		Etudiant b = new Etudiant();
		b.nom = "Bob";
		System.out.println(a + " / " + b);
	}

	public static Projet exercice6() {
		Etudiant a = new Etudiant();
		a.nom = "Mika";
		Etudiant b = new Etudiant();
		b.nom = "Sarah";
		Binome c = new Binome();
		c.etu1 = a;
		c.etu2 = b;
		Projet p = new Projet();
		p.b = c;
		p.titre = "Projet";
		p.note = 20;
		return p;
	}

	public static void exercice5() {
		Etudiant a = new Etudiant();
		a.nom = "Adele";
		Etudiant b = new Etudiant();
		b.nom = "Basile";
		Etudiant c = new Etudiant();
		c.nom = "Cloclo";
		Etudiant d = new Etudiant();
		d.nom = "Dagobert";
		Etudiant e = new Etudiant();
		d.nom = "Eglantine";

		a.bonjour(b.nom);
		b.bonjour(c.nom);
		c.bonjour(a.nom);
		e.bonjour(d.nom);
	}

	public static float mystere(Projet p) {
		System.out.println("Titre du projet: " + p.titre);
		System.out.println("Premier membre: " + p.b.etu1.nom);
		System.out.println("Deuxieme membre: " + p.b.etu2.nom);
		return p.note;
	}

}
