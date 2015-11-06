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

};

struct joueur tabj[NB];

main(int argc, char *argv[]){
	
	int scoreGagnant=0;
	int nbJoueurs=0;
	int r; 		// => Pid du fils
	int i,j; 	// => iterateur de boucle
	int m; 		// => Pid du joueur que l'on attend
	int p;		// => Reponse du joueur que l'on attend
	
	
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
			r = fork();
			
			if(r == 0) //processus fils
			{
				srand(getpid());
				exit(rand()%3); // rand() -> 0 pour papier, 1 pour ciseaux, 2 pour pierre
			}
			else //processus père
			{
				tabj[i].pid = r;
			}
		}
		
		//Enregistre les réponses des joueurs		
		for (i=0; i<nbJoueurs; i++)
		{
			m = wait(&p);
			
			for (j=0;j<nbJoueurs;j++)
			{
				if(tabj[j].pid==m)
					tabj[j].reponse = p/256;
			}
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
