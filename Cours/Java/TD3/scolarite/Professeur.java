package scolarite;

/**
 *
 * @author AS professors team
 */
public class Professeur extends Personne{
    
    private static int nbTotalProfesseurs=0;
    
    public Professeur( String nom){
        setNom(nom);
        nbTotalProfesseurs++;
    }
    
    /**
     * @return the nbTotalProfesseurs
     */
    public static int getNbTotal() {
        return nbTotalProfesseurs;
    }
    
}
