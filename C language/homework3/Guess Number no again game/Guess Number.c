#include <stdio.h>
#include<stdlib.h>
#include <time.h>



int main(void)
{

    srand((unsigned)time(NULL));
    int ans=rand()%100+1;
    int guess=0;

    printf("This is a guess number game.\n");


    printf("Please guess the number 1-100.\n");

    while(guess!=ans)
    {

    scanf(("%d"),&guess);
    if(guess<ans&&guess>1){
    printf("Please raise number.\n");
    }
    else if(guess>ans&&guess<100){
    printf("Please lower number.\n");
    }
    else if(guess<=1||guess>=100){
    printf("Please enter number to 1-100.\n");
    }
    }
    if(guess==ans){
    printf("Answer is %d.\n",ans);
    }


    (int)system("pause");

    return 0;




}
