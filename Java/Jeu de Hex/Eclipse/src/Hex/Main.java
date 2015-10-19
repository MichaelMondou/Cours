package Hex;

public class Main {

	public static void main(String[] args) {

		Model model = new Model();
		View view = new View(model);
		
		model.initialisation();

	}

}
