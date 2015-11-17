package application;

import personnes.Etudiant;
/*import personnes.Professeur;
import personnes.Binome;
import personnes.Projet;*/

public class Exercices {

	public static void main(String[] args) {
		
		//exercice21();
		//exercice22(); Il manque seulement le static avant Etudiant bob;
		//exercice23();
		// exercice24();
		// exercice25();
		// exercice26();
		exercice27();
		
	}
	
	public static void exercice27_1(Etudiant e){
		System.out.println("Debut methode: le nom de l'etudiant e est "+e.getNom());
		e.setNom("Tetouillou le terrible dragon");
		//e.profPOO.nom="Gothmog";
		System.out.println("Fin methode: le nom de l'etudiant e est "+e.getNom());
		//System.out.println(e.profPOO.nom);
	}
	
	public static void exercice27(){
		Etudiant e = new Etudiant("Dark Vador le gentil");
		//e.profPOO=new Professeur("Alphonse");
		System.out.println("Avant methode: le nom de l'etudiant e est "+e.getNom());		
		Etudiant copie = new Etudiant(e);
		exercice27_1(copie);
		System.out.println("Apres methode: le nom de l'etudiant e est "+e.getNom());
		//System.out.println(e.profPOO.nom);
		
	}
	
	public static void exercice26_2(Etudiant e){
		System.out.println("Debut methode: le nom de l'etudiant e est "+e.getNom());
		e.setNom("Tetouillou le terrible dragon");
		System.out.println("Fin methode: le nom de l'etudiant e est "+e.getNom());
	}
	
	public static void exercice26_1(int i){
		System.out.println("Avant methode: i vaut  "+i);
		i=12345;
		System.out.println("Après methode: i vaut "+i);
	}
	
	public static void exercice26(){
		int i = -27;
		System.out.println("Avant methode: i vaut  "+i);
		exercice26_1(i);
		System.out.println("Après methode: i vaut"+i);
		
		Etudiant e = new Etudiant("Dark Vador le gentil");
		System.out.println("Avant methode: le nom de l'etudiant e est "+e.getNom());		
		exercice26_2(e);
		System.out.println("Apres methode: le nom de l'etudiant e est "+e.getNom());
	}
	
	public static void exercice25(){
		/*System.out.println(Etudiant.NbTotalEtudiants);
		Etudiant a = new Etudiant();
		System.out.println(Etudiant.NbTotalEtudiants);
		Etudiant b = new Etudiant("Gollum");
		System.out.println(Etudiant.NbTotalEtudiants);*/
	}
	
	public static void exercice24(){
		/*System.out.println(Etudiant.afficherIUT());
		Etudiant Sarah = new Etudiant("Sarah");
		System.out.println(Sarah.afficherIUT());*/
	}
	
	
	public static void exercice21(){
		/*Etudiant a = new Etudiant("Bob");
		Etudiant b = new Etudiant("Greg");
		System.out.println(a.IUT); // warning
		System.out.println(b.IUT); // warning*/
	}
}
