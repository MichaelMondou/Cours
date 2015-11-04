package scolarite;

import java.util.ArrayList;
import java.util.ListIterator;

public class Groupe {
	public ArrayList<Personne> groupe;
	
	public Groupe(){
		groupe = new ArrayList<Personne>();
	}

	public void add(Personne p) {
		ListIterator<Personne> li = groupe.listIterator();
		boolean existe = false;

		while (!existe && li.hasNext()) {
			if (p.getNom().equals(li.next().getNom())) {
				System.out.println("Ce nom existe deja dans le groupe");
				existe = true;
			}
		}
		if(!existe)
			groupe.add(p);
	}

	public int size() {
		return groupe.size();
	}

	public String toString() {
		return groupe.toString();
	}

}
