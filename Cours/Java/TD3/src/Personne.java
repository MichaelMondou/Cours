
public class Personne {

	private String nom;
	private static int nbTotalPersonnes = 0;

	public Personne() {
		nbTotalPersonnes++;
	}

	public Personne(String nom) {
		this();
		setNom(nom);
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public static int getNbTotal() {
		return nbTotalPersonnes;
	}

	public String toString() {
		return "[Personne] Je suis " + getNom() + ", une grande persone";
	}
	
	public void jamesBond(){
		System.out.println("[Personne] Miss MoneyPenny, je vous saurais gré de ne pas dire \"le vieux\" en parlant de moi.");
	}

}
