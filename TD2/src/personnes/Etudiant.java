package personnes;

public class Etudiant {
	private String nom;
	static String IUT = "IUT de Bordeaux";
	static int NbTotalEtudiants;
	Professeur profPOO;

	public Etudiant(){
		NbTotalEtudiants++;
	}
	
	public Etudiant(Etudiant e){
		setNom(e.getNom());
		
	}
	
	public Etudiant(String s) {
		this.setNom(s);
		NbTotalEtudiants++;
	}
	
	public static String afficherIUT(){
		return IUT;
	}
	
	public String getNom(){
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}
}
