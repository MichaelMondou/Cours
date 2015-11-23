package hex;

import java.awt.Color;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class Grid {

	static final int length = 7;
	static final int height = 7;

	private ArrayList<ArrayList<Cell>> cells = new ArrayList<ArrayList<Cell>>();

	public Grid() {
		int absciss = 0;
		int ordonate = 0;

		for (int i = 0; i < length; i++) {
			ArrayList<Cell> temp_cells = new ArrayList<Cell>();
			for (int j = 0; j < height; j++) {
				absciss = 170 + i * 49;
				ordonate = 250 + j * 55;
				temp_cells.add(new Cell(absciss, ordonate, j, i, Color.GRAY));
			}
			getCell().add(temp_cells);
		}
		setTheGrid();
	}

	/**
	 * Permet de mettre le plateau en d�cal�
	 */
	public void setTheGrid() {
		for (int i = 0; i < Grid.length; i++) {
			for (int j = 0; j < Grid.height; j++) {
				int ordonate = this.getCell().get(i).get(j).getY();
				ordonate -= 27 * i;
				this.getCell().get(i).get(j).setY(ordonate);
				this.getCell().get(i).get(j).createPolygon();
			}
		}
	}

	public ArrayList<ArrayList<Cell>> getCell() {
		return cells;
	}

	public void setCellules(ArrayList<ArrayList<Cell>> cell) {
		this.cells = cell;
	}
}
