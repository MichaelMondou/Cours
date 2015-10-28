package Hex;

import java.util.ArrayList;
import java.util.Iterator;

public class Observable {
	
	private ArrayList<Observer> observers = new ArrayList<Observer>();

	public void addObserver(Observer observer) {
		this.observers.add(observer);
	}

	public void removeObserver(Observer observer) {
		this.observers.remove(observer.hashCode());
	}

	public void notifyObservers() {

	}

	public void setChanged() {
		
	}

}
