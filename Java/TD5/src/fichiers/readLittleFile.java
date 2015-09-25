package fichiers;

import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;

public class readLittleFile {

	public static void main(String[] args) {
		Charset UTF8 = Charset.forName("UTF-8");
		Path codeMain = Paths.get("./src/fichiers/readFile.java");
		try {
			List<String> lignes = Files.readAllLines(codeMain, UTF8);
			for(String ligne : lignes) {
				System.out.println(lignes);
			}
		}
		catch (IOException ioe) {
			System.err.println("Erreur de lecture : " + ioe);
		}

	}

}
