@echo off

			REM script d'initialisation de l'atelier "Programmation"
			REM pour la Fête de la Science

			REM I.D. 6/11/2008 et 13/11/2008
			REM I.D. Modif pour FS novembre 2009
			REM I.D. Modif pour FS novembre 2010
			REM modifié pour la FS Octobre 2011

			REM ****************************************************************
			REM Modifier si besoin repfic ci-dessous
			REM ****************************************************************

			REM nom du répertoire où se trouvent les fichiers originaux dans \\Info-smb\Bibliotheque\
			REM 2014 : nom du répertoire où se trouvent les fichiers originaux dans \\Info-nfs\Remise\
set repfic=JPO\Prog
set ficProjetRecent=JPO\Prog\_Scripts\bdr_fs.reg

			REM Settings de VS
set ficVSsettings=CurrentSettings.vssettings
			REM Dossier contenant les settings de visual studio
set repVSsettings=Documents\Visual Studio 2013\Settings


REM *****************************************************************
			REM Ne rien modifier après.. (sauf lecteurs ci-après si besoin)

			REM Affectation des lecteurs pour les répertoires partagés
			REM \\Info\Remise
			REM Modifier si besoin selon la machine sur laquelle on exécute !!!
			REM                (choisir 1 lecteur libre)

set lremise=k:
net use %lremise% \\info-nfs\Remise


			REM   I) recopie des VSsettings    Chemin des settings OK. A vÃ©rifier remise !
			REM   **********************
echo ----- Recopie settings VS -----
REM xcopy "%lremise%\%repfic%\%ficVSsettings%" "Z:\%repVSsettings%" /q /y
xcopy "%lremise%\%repfic%\%ficVSsettings%" "C:\Users\%USERNAME%\%repVSsettings%" /q /y
echo "%lremise%\%repfic%\%ficVSsettings%" "C:\Users\%USERNAME%\%repVSsettings%"
echo ----- Mise a jours des projets recents -------
REM reg DELETE HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\11.0\ProjectMRUList /va /f
reg import "%lremise%\%ficProjetRecent%"
			REM   II) recopie de tous les thèmes 
			REM  Correction apporter : creation du dossier "THEMES_PROG" après sa suppression
			REM   ***************************
echo ----- NETTOYAGE COMPLET -----
 rmdir "Z:\THEMES_PROG" /s /q
 mkdir "Z:\THEMES_PROG"
echo ----- Recopie THEME Arkanoid -----
 xcopy "%lremise%\%repfic%\Arkanoid" "Z:\THEMES_PROG\Arkanoid\" /q /s /e /y
echo ----- Recopie THEME Puissance4 -----
 xcopy "%lremise%\%repfic%\Puissance4" "Z:\THEMES_PROG\Puissance4\" /q /s /e /y
echo ----- Recopie THEME GraphX -----
 xcopy "%lremise%\%repfic%\GraphX" "Z:\THEMES_PROG\GraphX\" /q /s /e /y


			REM ***************
			REM repositionnement sur un lecteur extérieur au lecteur réseau
			REM puis suppression du lecteur réseau
			REM ***************
Z:
net use %lremise% /delete

"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe"
exit
