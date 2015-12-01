package scolarite;

public class Main {

	Main(){
    	try{
        Promotion as2012 = new Promotion("DUT Informatique - Annee Speciale", 2012, -1);
    	}
    	catch(NbEtudiantsException nbe){
    		System.err.println(nbe);
    	}
    	finally{
    		System.out.println("finally");
    	}
    	System.out.println("yo");
    }

	/**
	 * @param args
	 *            the command line arguments
	 */
	/*public static void main(String[] args) {
		//new Main();
		
		int n;
		n = Integer.parseInt(arg[0]);
		System.out.println("Factorielle de "+n+" : "+calcul(n));
	}*/
}
