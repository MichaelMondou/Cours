package files;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class CopyLines {
	public static void main(String[] args) {
		BufferedReader inputStream = null;
		PrintWriter outputStream = null;
		
		try{
			inputStream = new BufferedReader(new FileReader("xanadu.txt"));
			outputStream = new PrintWriter(new FileWriter("characteroutput.txt"));
			
			String l;
			while ((l = inputStream.readLine()) != null){
				outputStream.println(l);
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
