package exercices;

public class Projet {
	Binome b;
	String titre;
	float note;
	
	public Projet(){
	}
	
	public Projet(Binome bi, String t, float n){
		this.b = bi;
		this.titre = t;
		this.note = n;
	}
	
	String getTitre(){
		return titre;
	}
	
	public String toString(){
		return "Titre du projet: "+titre+"\n"
				+"Premier membre: "+b.etu1.nom+"\n"
				+"Deuxieme membre: "+b.etu2.nom+"\n"
				+"Note : "+note;
	}
}
