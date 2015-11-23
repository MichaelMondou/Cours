package hex;

import java.awt.Color;
import java.util.ArrayList;

public class Player {
	
	private String name;
	private int identity;
	private Color color;
	private ArrayList<Cell> player_cells;
	private int zone=1;
	private static int id = 0;

	public Player(String name, Color color)
	{
		this.name=name;
		this.color=color;
		player_cells=new ArrayList<Cell>();
		this.identity = id;
		id++;
	}

	public void addCell(Cell cell)
	{
		this.player_cells.add(cell);
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public Color getColor() {
		return color;
	}
	public void setColor(Color color) {
		this.color = color;
	}
	public ArrayList<Cell> getPlayer_cells() {
		return player_cells;
	}

	public void setPlayer_cells(ArrayList<Cell> player_cells) {
		this.player_cells = player_cells;
	}

	public int getZone() {
		return zone;
	}

	public void setZone(int zone) {
		this.zone = zone;
	}

	public void upZone() {
		this.zone=zone+1;
		
	}

	public void updateZone() {
		int max=1;
		for(int i=0;i<player_cells.size();i++)
		{
			if(player_cells.get(i).getZone()>max)
				max=player_cells.get(i).getZone()+1;
		}
	}
	
	public int getIdentity() {
		return identity;
	}

	public void setIdentity(int identity) {
		this.identity = identity;
	}
}
