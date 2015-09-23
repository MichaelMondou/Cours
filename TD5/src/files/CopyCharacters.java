package files;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class CopyCharacters {
	public static void main(String[] args){
		FileReader inputStream = null;
		FileWriter outputStream = null;
		
		try{
			inputStream = new FileReader("xanadu.txt");
			outputStream = new FileWriter("outagain.txt");
			
			int c;
			
			while ((c = inputStream.read()) != -1){
				outputStream.write(c);
			}
			if (inputStream != null)
				inputStream.close();
			if (outputStream != null)
				outputStream.close();
		}
		catch (IOException ioe){
			System.err.println("Erreur lors de la communication : "+ioe);
		}
	}
}
