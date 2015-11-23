package hex;

import java.awt.Point;
import java.awt.event.MouseEvent;

public class Controller {
	
	private Model model;

	public Controller(Model model) {
		this.model = model;
	}
	
	public void Action(View object, MouseEvent event) {
		switch (event.getID()) {
		case MouseEvent.MOUSE_CLICKED:
			Point p = new Point(event.getX(), event.getY());
			model.nextData(p);
			break;
		default:
			break;
		}
	}

}
