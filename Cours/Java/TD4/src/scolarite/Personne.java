package scolarite;

/**
 *
 * @author AS Professor teams
 */
public  class Personne {
    
    private String nom;
    private static int nbTotalPersonnes=0;
  
    public Personne(){
          //System.out.println("Constructeur Personne()");
          nbTotalPersonnes++;
    }
       
    public Personne(String nom){
        this();
        //System.out.println("Constructeur Personne(String)");
        setNom(nom);
    }
    
    /**
     * @return the nom
     */
    public String getNom() {
        return nom;
    }

    /**
     * @param nom the nom to set
     */
    public void setNom(String nom) {
        this.nom = nom;
    }
    
    /**
     * @return the nbTotalPersonnes
     */
    public static int getNbTotal() {
        return nbTotalPersonnes;
    }
    
    public String toString(){
        return "Je suis "+getNom()+", une grande personne";
    }
    
}
