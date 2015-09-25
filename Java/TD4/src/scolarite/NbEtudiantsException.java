package scolarite;

@SuppressWarnings("serial")
public class NbEtudiantsException extends Exception {
	private int nbErr;

	public NbEtudiantsException(int nbErr) {
		this.nbErr = nbErr;
	}

	public String toString() {
		return "Nb etudiant errone : " + nbErr;
	}

}
