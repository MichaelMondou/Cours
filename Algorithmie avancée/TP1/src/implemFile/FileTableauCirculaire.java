package implemFile;

import java.util.Collection;
import java.util.Iterator;
import java.util.Queue;

public class FileTableauCirculaire implements Queue<Integer> {
	
	private final int capacite = 1000;
	private Integer tab[];
	private int tete = 0;
	private int longueur = 0;
	
	public FileTableauCirculaire(){
		tab = new Integer[capacite];
	}
	
	public int getSize(){
		return longueur;
	}
	
	public int getTete(){
		return tete;
	}
	
	private int indiceQueue(){
		return (tete+longueur)%capacite;
	}
	
	@Override
	public boolean isEmpty() {
		return(longueur==0);
	}

	@Override
	public boolean contains(Object o) {
		Boolean trouve = false;
		int i = 0;
		if(!isEmpty()){
			while(!trouve && i < this.longueur){
				if(tab[i]== (int)o)
					trouve = true;
			}
			i++;
		}
		return trouve;
	}
	
	private void insertion(Integer i){
		tab[indiceQueue()] = i;
		longueur++;
	}
	
	private void suppression(Integer i){

	}

	@Override
	public boolean add(Integer o) {
		int i = 0;
		if(longueur < capacite){
			if(tab[i] != null){
				i++;
			}
		}
		return false;
	}

	@Override
	public Integer remove() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Iterator<Integer> iterator() {
		return null;
	}

	@Override
	public boolean addAll(Collection<? extends Integer> c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public void clear() {
		// TODO Auto-generated method stub

	}

	@Override
	public boolean containsAll(Collection<?> c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean remove(Object o) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean removeAll(Collection<?> c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean retainAll(Collection<?> c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public int size() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public Object[] toArray() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public <T> T[] toArray(T[] a) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Integer element() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean offer(Integer e) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public Integer peek() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Integer poll() {
		// TODO Auto-generated method stub
		return null;
	}
}
