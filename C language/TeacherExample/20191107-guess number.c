#include <stdio.h>

int main(void)
{
    int ans = 32;
    int guess;
    int low = 1, high = 100;

    printf("This is a guess number game.\n");
    while(guess != ans)
    {
        printf("Please guess the number (%d-%d): ", low, high);
        scanf("%d", &guess);

        if(guess < ans) low = guess;
        else high = guess;
    }
    print("You guess the number.");

    return 0;
}
