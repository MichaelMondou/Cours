package hex;

import java.awt.Graphics;
import java.awt.Point;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.Observable;

public class ViewHex extends View implements MouseListener{

	ViewHex(Window window, Model model, Controller controller) {
		super(window, model, controller);
		paint(panel.getGraphics());
	}
	
    public void mouseReleased(MouseEvent e)
    {
    	
    }

	public void paint(Graphics g) {
		panel.paint(g);
		for (int i = 0; i < getModel().getPlateau().cellules.size(); i++) {
			for (int j = 0; j < getModel().getPlateau().cellules.get(i).size(); j++) {
				getModel().getPlateau().cellules.get(i).get(j).creerPolygone();
				g.setColor(getModel().getPlateau().cellules.get(i).get(j).getCouleur());
				g.fillPolygon(getModel().getPlateau().cellules.get(i).get(j));
			}
		}
		panel.addMouseListener(this);
	}

	@Override
	public void update(Observable o, Object arg) {
		paint(panel.getGraphics());
	}

	@Override
    public void mouseClicked( MouseEvent e )
    {
		
          // Clique gauche de la souris
           if(e.getButton()==MouseEvent.BUTTON1)
           {
                // R�cup�ration de la position
                Point position = e.getPoint();
                System.out.println(position.x);
            }
     }

	@Override
	public void mouseEntered(MouseEvent arg0) {
		
	}

	@Override
	public void mouseExited(MouseEvent arg0) {
		
	}

	@Override
	public void mousePressed(MouseEvent arg0) {
		
	}

}
