#include <stdio.h>

int main(void)
{
    int counter;
    int num;
    int isPrime;

    for(num=2;num<=100;num++)
    {
        isPrime = 1;
        for(counter=2;counter<=num/2;counter++)
        {
            if(num % counter == 0) isPrime = 0;
        }
        if(isPrime==1) printf("%d is a prime number\n", num);
    }

    return 0;
}
