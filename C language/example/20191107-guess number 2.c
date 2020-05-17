#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void)
{
    int ans;
    int guess;
    int low = 1, high = 100;

    srand(time(NULL));
    ans = (rand()%100)+1;

    printf("This is a guess number game.\n");
    do {
        printf("Please guess the number (%d-%d): ", low, high);
        scanf("%d", &guess);

        if(guess < ans) low = guess;
        else high = guess;
    }while(guess != ans);
    printf("You guess the number.");

    return 0;
}
