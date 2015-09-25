package exercices;

public class Binome {
	Etudiant etu1;
	Etudiant etu2;

	public Binome() {
	}

	public Binome(Etudiant etu1, Etudiant etu2) {
		this.etu1 = etu1;
		this.etu2 = etu2;
	}

	public String toString() {
		return "[Binome]: " + etu1 + " / " + etu2;
	}

}
