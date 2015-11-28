/**
 * MONDOU - TAMAS_LELOUP - S3B
 */

package tests;

import static org.junit.Assert.assertEquals;

import java.awt.Color;

import org.junit.Test;

import hex.Cellule;

public class TestCellule {

	@Test
	public void testZoneCellules() {
		Cellule c1 = new Cellule(50, 50, 50, 50, Color.BLACK);
		c1.setZone(0);
		Cellule c2 = new Cellule(50, 50, 50, 50, Color.BLACK);
		c2.setZone(0);

		assertEquals(c1.compareTo(c2), 0);

		c2.setZone(1);

		assertEquals(c1.compareTo(c2), -1);

		c1.setZone(2);

		assertEquals(c1.compareTo(c2), 1);
	}

}
