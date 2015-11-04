package hex;

public class Main {

	public static void main(String[] args) {

		Window window = new Window("Hex", 640, 720);
		
		Model model = new Model();
		Controller controller = new Controller(model);
		
		ViewHex view = new ViewHex(window, model, controller);
		
		model.addObserver(view);

	}
}
