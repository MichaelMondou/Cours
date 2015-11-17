package scolarite;

public class Etudiant extends Personne {

	private static int nbTotalEtudiants = 0;

	public Etudiant() {
	}

	public Etudiant(String nom) {
		setNom(nom);
		nbTotalEtudiants++;
	}

	/**
	 * @return the nbTotalEtudiants
	 */
	public static int getNbTotal() {
		return nbTotalEtudiants;
	}

	public String toString() {
		return "Je suis " + getNom() + ", tres studieux";
	}

}
