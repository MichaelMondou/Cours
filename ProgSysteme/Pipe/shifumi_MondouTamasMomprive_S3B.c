/*
 *	Auteurs : Mathilde Guédon 
 * 			  Jean-Baptiste Bétérous
 * 	Groupe S3A
 */


#include <time.h>

#define NB 50	//Nombre de joueurs maximum autorisés


struct joueur{
	int pid;
	int reponse;
	int score;
	int fd[2];
};

struct joueur tabj[NB];

main(int argc, char *argv[]){
	
	int scoreGagnant=0;
	int nbJoueurs=0;
	int r; 		// => Pid du fils
	int i,j; 	// => iterateur de boucle
	int m; 		// => Pid du joueur que l'on attend
	int p;		// => Reponse du joueur que l'on attend
	int nbGenereInt;
	char nbGenereChar;
	int nbLuInt;
	char nbLuChar;
	
	if (argc != 2)
	{
		printf("Usage : arbitre <nombre de joueur>\n");
	}
	else
	{
		int tmp = atoi(argv[1]);
		
		if (tmp<=NB && tmp>1)
			nbJoueurs = tmp;
		else
		{
			printf("Nombre de joueur invalide, il doit etre compris entre 2 et %d.\n",NB);
		}
		
		for (i=0; i<nbJoueurs ; i++)
		{
		    pipe(tabj[i].fd);
			r = fork();
			
			if(r == 0) //processus fils
			{
				close(tabj[i].fd[0]);
				
				srand(getpid());
				nbGenereInt = rand()%3;
				nbGenereChar = (char)nbGenereInt;
				write(tabj[i].fd[1], &nbGenereChar, 1);
				
				close(tabj[i].fd[1]);
				
				exit(0);
			}
			else //processus père
			{
				tabj[i].pid = r;
				tabj[i].score = 0;
			}
		}
		
		//Enregistre les réponses des joueurs		
		for (i=0; i<nbJoueurs; i++)
		{	
			close(tabj[i].fd[1]);					
			read(tabj[i].fd[0], &nbLuChar, 1);
			nbLuInt = (int)nbLuChar;
			tabj[i].reponse = nbLuInt;
			close(tabj[i].fd[0]);	
		}
		
		//calculer les scores sur tabj;
		
		for (i=0; i<nbJoueurs-1;i++)
		{
			j=i;
			// On compare le score du joueur i avec celui des autres joueurs
			while (j<nbJoueurs)
			{
				if(tabj[i].reponse!=tabj[j].reponse)
				{
					//Calcul du score du joueur i
					if((tabj[i].reponse==1 && tabj[j].reponse==0)
						|| (tabj[i].reponse==2 && tabj[j].reponse==1)
						|| (tabj[i].reponse==0 && tabj[j].reponse==2))
					{
						tabj[i].score++;
					}
					//Calcul du score du joueur j
					else if ((tabj[i].reponse==0 && tabj[j].reponse==1)
						|| (tabj[i].reponse==1 && tabj[j].reponse==2)
						|| (tabj[i].reponse==2 && tabj[j].reponse==0))
					{
						tabj[j].score++;
					}
					else
					{
						printf("ERREUR : Nouveau cas non-gere\n");
					}
				}
				j++;
			}
		}
		
		//Affichage des scores
		for(i=0; i<nbJoueurs; i++)
		{
			if(tabj[i].reponse==0)
				printf("Le joueur %d a joue Papier  et a un score de %d \n",tabj[i].pid,tabj[i].score);
			if(tabj[i].reponse==1)
				printf("Le joueur %d a joue Ciseaux et a un score de %d \n",tabj[i].pid,tabj[i].score);	
			if(tabj[i].reponse==2)
				printf("Le joueur %d a joue Pierre  et a un score de %d \n",tabj[i].pid,tabj[i].score);
			//Calcul du score gagnant
			if(scoreGagnant<tabj[i].score)
				scoreGagnant=tabj[i].score;
		}
		
		//Affichage des gagnants
		if(scoreGagnant!=0)
		{
			for(i=0; i<nbJoueurs; i++)
			{
				if(scoreGagnant==tabj[i].score)
					printf("Le joueur %d GAGNE un niveau !!!!\n",tabj[i].pid);
			}
			printf("Avec un score de %d\n",scoreGagnant);
		}
		else
			printf("PERDU !!!!!!!!!!!!!!!!!!!!!!!! Mouahahahahahah\n");
	}
}
