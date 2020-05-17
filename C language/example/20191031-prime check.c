#include <stdio.h>

int main(void)
{
    int counter;
    int num;
    int isPrime = 1;

    printf("Please enter a number: ");
    scanf("%d", &num);
    for(counter=2;counter<num/2;counter++)
    {
        if(num % counter == 0) isPrime = 0;
    }
    if(isPrime==0) printf("%d is not a prime number", num);
    else printf("%d is a prime number", num);

    return 0;
}
