
public class Etudiant extends Personne {

	private static int nbTotalEtudiants = 0;

	Etudiant(String nom) {
		setNom(nom);
		nbTotalEtudiants++;
	}

	public Etudiant() {
	}

	public static int getNbTotal() {
		return nbTotalEtudiants;
	}

	public String toString() {
		return "[Etudiant] Je suis " + getNom() + ", tres studieux";
	}

	public void jamesBond() {
		System.out.println("[Etudiant] Je m'appelle " + this.getNom() + ", " + this.getNom() + " Bond");
	}
}
