package mvc;

/**
 * Contr�leur de l'application permettant de contr�ler les �v�nements de la vue
 * et de modifier le mod�le en cons�quence.
 */
public class Controller {

	private Model model;

	public Controller(Model model) {
		this.model = model;
	}

	/**
	 * Permet de g�rer les �v�nements de la vue en appelant les bonnes m�thodes
	 * du mod�le.
	 */
	public void Action(View object, Event event) {
		switch (event) {
		case UPCELSIUS:
			model.upCelsius();
			break;
		case DOWNCELSIUS:
			model.downCelsius();
			break;
		case UPFARENHEIT:
			model.upFarenheit();
			break;
		case DOWNFARENHEIT:
			model.downFarenheit();
			break;
		case SCROLL:
			model.Scroll(object);
			break;
		default:
			break;
		}
	}
}
