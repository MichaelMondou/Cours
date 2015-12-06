package exception;

@SuppressWarnings("serial")
public class NbLignesColonnesException extends Exception{
	private int erreur;
	
	public NbLignesColonnesException(int erreur){
		this.erreur = erreur;
	}
	
	public String toString(){
		return "Nombre de lignes ou de colonnes invalide : \n"+erreur+"\n La valeur doit être supérieure à 0";
	}

}
