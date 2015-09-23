package scolarite;

import java.util.ArrayList;
import java.util.HashSet;

public class Groupe {
	ArrayList<Personne> membres = new ArrayList<Personne>();
	HashSet<String> noms = new HashSet<String>();
	
	public void add( Personne p){
		if (noms.contains(p.getNom()))
			return;
		membres.add(p);
		noms.add(p.getNom());
	}
	
	public int size(){
		return membres.size();
	}
	
	public String toString(){
		String res="Groupe: ";
		for (Personne p: membres)
			res+=p.getNom()+", ";
		return res;
	}
}
