package files;

import java.io.BufferedReader;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class testDeLectureUTF8 {
	public static void main(String[] args) {
		Charset UTF8 = Charset.forName("UTF-8");
		Path codeMain = Paths.get("./src/files/CopyBytes.java");

		try {
			BufferedReader br = Files.newBufferedReader(codeMain, UTF8);
			String ligne = br.readLine();
			while (ligne != null) {
				System.out.println(ligne);
				ligne = br.readLine();
			}
			br.close();
		} catch (IOException ioe) {
			System.err.println("Erreur de lecture : " + ioe);
		}
	}
}
