package Hex;

import javax.swing.JFrame;

public class Fenetre extends JFrame {
  public Fenetre(){                
    this.setTitle("HEX");
    this.setSize(800, 600);
    this.setLocationRelativeTo(null);               
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    this.setContentPane(new Vue());

    this.setVisible(true);
  }     
}
