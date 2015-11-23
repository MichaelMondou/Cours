package hex;

import java.awt.Color;
import java.awt.Point;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Observable;

public class Model extends Observable {

	/**
	 * Le plateau de jeu contenant des cellules
	 */
	private Grid board;

	/**
	 * Les joueurs
	 */
	private ArrayList<Player> players;

	/**
	 * Tour courant
	 */
	private int player_round = 0;

	/**
	 * Sert à savoir s'il y a un gagnant
	 */
	public Event who_is_the_winner;

	public Model() {
		board = new Grid();
		players = new ArrayList<Player>();
		Player j1 = new Player("player1", Color.BLACK);
		Player j2 = new Player("player2", Color.WHITE);
		players.add(j1);
		players.add(j2);

		who_is_the_winner = Event.NO_WINNER;
	}

	/**
	 * Cette fonction sert à détecter si un point p se trouve dans une cellule
	 * cell
	 */
	public boolean isInTheBoard(Point p, Cell cell) {
		if (cell.contains(p) && !(cell.isModify())) {
			return true;
		}
		return false;
	}

	/**
	 * Cette action sert à enchaîner les différentes actions nécessaires au
	 * fonctionnement du jeu
	 * 
	 * @param p
	 */
	public void nextData(Point p) {
		for (int i = 0; i < board.getCell().size(); i++) {
			for (int j = 0; j < board.getCell().get(i).size(); j++) {
				if (isInTheBoard(p, board.getCell().get(i).get(j))) {
					players.get(player_round).addCell(board.getCell().get(i).get(j));
					affectZone(board.getCell().get(i).get(j), players.get(player_round));
					modifyColor(board.getCell().get(i).get(j));
					gameOver(players.get(player_round));
					changePlayerRound();
					setChanged();
					notifyObservers();
				}
			}
		}
	}

	/**
	 * Cette action sert à gérer l'affectation d'une zone sur la cellule passée
	 * en paramètre en fonction du nombre de ses voisins.
	 */
	public void affectZone(Cell cell, Player player) {

		if (around(cell, player).size() > 0) {
			updateGrid(cell, player);
			player.updateZone();
		} else {
			cell.setZone(player.getZone());
			player.upZone();
		}
		resetCells();
	}

	/**
	 * Cette action permet d'attribuer une zone à la cellule passée en paramètre
	 * en fonction des zones de ses voisins puis met à jour les zones de ses
	 * voisins.
	 */
	private void updateGrid(Cell cell, Player player) {
		ArrayList<Cell> neighbors = new ArrayList<Cell>();
		neighbors = around(cell, player);
		cell.setZone(neighbors.get(0).getZone());
		cell.setChangedZone(true);
		if (neighbors.size() > 1) {
			for (int i = 1; i < neighbors.size(); i++) {
				if (!neighbors.get(i).isChangedZone())
					updateGrid(neighbors.get(i), player);
			}
		}
	}

	/**
	 * Cette fonction sert à déterminer si la cellule a des voisins. Si c'est le
	 * cas, elle retourne ses voisins.
	 */

	@SuppressWarnings("unchecked")
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
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == right && line == cell.getL()) {
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (line == top && column == cell.getC()) {
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (line == bottom && column == cell.getC()) {
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == left && line == top) {
				neighbors.add(player.getPlayer_cells().get(i));
			} else if (column == right && line == bottom) {
				neighbors.add(player.getPlayer_cells().get(i));
			}
		}

		Collections.sort(neighbors);
		return neighbors;
	}

	/**
	 * Cette action sert à réinitialiser le booléen de chaque zone. Ce dernier
	 * indiquant si la zone de la cellule a déjà été mise à jour.
	 */
	private void resetCells() {
		for (int i = 0; i < board.getCell().size(); i++)
			for (int j = 0; j < board.getCell().get(i).size(); j++)
				board.getCell().get(i).get(j).setChangedZone(false);
	}

	/**
	 * Cette action sert à modifier la couleur de la cellule passée en paramètre
	 */
	public void modifyColor(Cell cell) {
		cell.setColor(players.get(player_round).getColor());
		cell.setModify(true);
	}

	/**
	 * Cette fonction sert à détecter si la partie est finie en regardant les
	 * première et dernière colonne si c'est le premier joueur et les première
	 * et dernière lignes si c'est le second joueur.
	 */

	public void gameOver(Player player) {

		boolean player1_zone1 = false;
		boolean player1_zone2 = false;

		boolean player2_zone1 = false;
		boolean player2_zone2 = false;

		if (player.getIdentity() == 0) {
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
				who_is_the_winner = Event.BLACK_WINNER;
			}
		} else {
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
				who_is_the_winner = Event.WHITE_WINNER;
			}
		}
	}

	/**
	 * Cette action sert à changer de tour
	 */
	public void changePlayerRound() {
		if (player_round == 0)
			player_round = 1;
		else
			player_round = 0;
	}

	/**
	 * Cette action sert à réinitialiser tous les paramètres du jeu pour
	 * commencer une nouvelle partie
	 */
	public void restart() {
		board = new Grid();
		players = new ArrayList<Player>();
		Player j1 = new Player("player1", Color.BLACK);
		Player j2 = new Player("player2", Color.WHITE);
		j1.setIdentity(0);
		j2.setIdentity(1);
		players.add(j1);
		players.add(j2);
		who_is_the_winner = Event.NO_WINNER;

		setChanged();
		notifyObservers();
	}

	public Grid getBoard() {
		return board;
	}

	public void setBoard(Grid board) {
		this.board = board;
	}

}
