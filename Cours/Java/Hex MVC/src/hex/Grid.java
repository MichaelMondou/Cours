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

	public void affectZone(Cell cell, Player player) {

		if (this.around(cell, player).size() > 0) {
			this.updateGrid(cell, player);
			player.updateZone();
		} else {
			cell.setZone(player.getZone());
			player.upZone();
		}
		if (this.gameOver(player)) {
			if(player.getIdentity() == 0)
				System.out.println("noir gagn�");
			else
				System.out.println("blanc gagn�");
		}
		this.reset();
	}
	
	private void reset() {
		for (int i = 0; i < this.getCell().size(); i++)
			for (int j = 0; j < this.getCell().get(i).size(); j++)
				this.getCell().get(i).get(j).setChangedZone(false);

	}

	private boolean gameOver(Player player) {
		
		boolean game_over = false;
		
		boolean player1_zone1 = false;
		boolean player1_zone2 = false;
		
		boolean player2_zone1 = false;
		boolean player2_zone2 = false;
		
		if(player.getIdentity() == 0){
			for (int i = 0; i < player.getPlayer_cells().size(); i++) {
				if (player.getPlayer_cells().get(i).getC() == 6 && player.getPlayer_cells().get(i).getZone() == 1) {
					player1_zone1 = true;
				}
			}
			for (int i = 0; i < player.getPlayer_cells().size(); i++) {
				if (player.getPlayer_cells().get(i).getC() == 0 && player.getPlayer_cells().get(i).getZone() == 1) {
					player1_zone2 = true;
				}
			}
			if (player1_zone1 && player1_zone2) {
				game_over = true;
			}
		}
		else{
			for (int i = 0; i < player.getPlayer_cells().size(); i++) {
				if (player.getPlayer_cells().get(i).getL() == 6 && player.getPlayer_cells().get(i).getZone() == 1) {
					player2_zone1 = true;
				}
			}
			for (int i = 0; i < player.getPlayer_cells().size(); i++) {
				if (player.getPlayer_cells().get(i).getL() == 0 && player.getPlayer_cells().get(i).getZone() == 1) {
					player2_zone2 = true;
				}
			}
			if (player2_zone1 && player2_zone2) {
				game_over = true;
			}
		}
		return game_over;
	}

	private void updateGrid(Cell cellule, Player player) {
		ArrayList<Cell> neighbors = new ArrayList<Cell>();
		neighbors = this.around(cellule, player);
		cellule.setZone(neighbors.get(0).getZone());
		cellule.setChangedZone(true);
		if (neighbors.size() > 1) {
			for (int i = 1; i < neighbors.size(); i++) {
				if (!neighbors.get(i).isChangedZone())
					updateGrid(neighbors.get(i), player);
			}

		}
	}

	private ArrayList<Cell> around(Cell cell, Player player) {

		int left = cell.getC() - 1;
		int right = cell.getC() + 1;
		int top = cell.getL() - 1;
		int bottom = cell.getL() + 1;

		ArrayList<Cell> neighbors = new ArrayList<Cell>();

		for (int i = 0; i < player.getPlayer_cells().size(); i++) {

			int line = player.getPlayer_cells().get(i).getL();
			int column = player.getPlayer_cells().get(i).getC();

			if (column == left && line == cell.getL()) {
				// regarder gauche
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == right && line == cell.getL()) {
				// regarder droite
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (line == top && column == cell.getC()) {
				// regarder haut
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (line == bottom && column == cell.getC()) {
				// regarder bas
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == left && line == top) {
				// gerer diag gauche
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == right && line == bottom) {
				// gerer diag droite
				neighbors.add(player.getPlayer_cells().get(i));
			}
		}
		Collections.sort(neighbors);
		return neighbors;

	}

	public ArrayList<ArrayList<Cell>> getCell() {
		return cells;
	}

	public void setCellules(ArrayList<ArrayList<Cell>> cell) {
		this.cells = cell;
	}
}
