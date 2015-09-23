package scolarite;

/**
 *
 * @author AS professors team
 */
public class Main {

    
    Main(){
        Etudiant a = new Etudiant("Arsene Lupin");
        Etudiant b = new Etudiant("Dark Vador");
        Etudiant c = new Etudiant("Saurion");
        Professeur d = new Professeur("Jojo Lapin");
        Professeur e = new Professeur("Barbapapa");
        System.out.println(Personne.getNbTotal()+" personnes dont "+Etudiant.getNbTotal()+" etudiants "+" et "+Professeur.getNbTotal()+" professeurs");
    }
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        new Main();
    }
}
