package fichiers;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;

public class CopyLines {
	public static void main(String[] args) {
		BufferedReader inputStream = null;
		PrintWriter outputStream = null;
		
		try {
			inputStream = new BufferedReader(new FileReader("lire.txt"));
			outputStream = new PrintWriter("ecrire.txt");
			int c;
			
			while((c = inputStream.read()) != -1) {
				outputStream.write(c);
			}
			if(inputStream != null)
				inputStream.close();
			if(outputStream != null)
				outputStream.close();
		}
		
		catch (IOException ioe) {
			System.err.println("Erreur lors de la communication : " + ioe);
		}
	}
}
