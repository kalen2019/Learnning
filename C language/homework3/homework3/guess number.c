#include <stdio.h>
#include<stdlib.h>
#include <time.h>



int main(void)
{

    printf("This is a guess number game.\n\n");
    printf("Start the guess number,enter 1.\n");
    printf("Quit the guess number,enter other numbers.\n");

    int choice=0;
    time_t a,b;
    int var;
    scanf("%d",&choice);


    while(choice==1)
    {
    srand((unsigned)time(NULL));
    int ans=rand()%100+1;
    int guess=0;
    int low = 1, high = 100;
    a=time(0);
    while(1)
    {

    printf("Please guess the number (%d-%d):", low, high);
    scanf(("%d"),&guess);

    if(guess<ans&&guess>=1) low=guess;
    else if(guess>ans&&guess<=100) high=guess;
    else if(guess<1||guess>100){
    printf("Please enter number to 1-100.\n");
    }
    else if(guess==ans){
    printf("Answer is %d.\n\n",ans);
    b=time(0);
    printf("You spend %d seconds.\n",var=difftime(b,a));
    if(var<=10){
    printf("you are perfact.\n");
    }
    else if(var>10&&var<=15){
    printf("you are great.\n");
    }
    else if(var>15&&var<=20){
    printf("you are good.\n");
    }
    else if(var>20){
    printf("you can quick a little.\n");
    }
    break;
    }
    }
    printf("Play again,enter 1.\n");
    printf("Quit the gmae,enter other numbers.\n");
    scanf("%d",&choice);

    }



    (int)system("pause");
    return choice;

}
