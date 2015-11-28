public class Professeur extends Personne {

	private static int nbTotalProfesseurs = 0;

	public Professeur(String nom) {
		setNom(nom);
		nbTotalProfesseurs++;
	}

	public Professeur() {
	}

	public static int getNbTotal() {
		return nbTotalProfesseurs;
	}

	public void jamesBond() {
		System.out.println("[Professeur] How do you do, Miss Moneypenny ?");
	}
}
