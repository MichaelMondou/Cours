package scolarite;

public class Promotion {
	int annee;
	String intitule;
	private int nbEtudiants;
	
	public Promotion(String intitule, int annee, int nbEtudiants) throws NbEtudiantsException{
		this.intitule=intitule;
		this.annee=annee;
		setNbEtudiants(nbEtudiants);
	}
	
	public int getNbEtudiants(){
		return nbEtudiants;
	}

	private void setNbEtudiants(int nbEtudiants) throws NbEtudiantsException{
		if(nbEtudiants<0)
			throw new NbEtudiantsException(nbEtudiants);
		this.nbEtudiants = nbEtudiants;
	}
	
	protected void erreur (String message){
		System.err.println("ERREUR dans la classe "+ getClass().getName() + " : "+ message);
		System.exit(1);
	}

}
