package fichiers;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class CopyBytes {
	public static void main(String [] args) {
		FileInputStream in = null;
		FileOutputStream out = null;
		
		try {
			in = new FileInputStream("lire.txt");
			out = new FileOutputStream("ecrire.txt");
			int c;
			
			while((c = in.read()) != -1) {
				out.write(c);
			}
			if(in != null)
				in.close();
			if(out != null)
				out.close();
		}
		
		catch (IOException ioe) {
			System.err.println("Erreur lors de la communication : " + ioe);
		}
	}
}
