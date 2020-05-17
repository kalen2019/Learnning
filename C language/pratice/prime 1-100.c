#include<stdio.h>

int main(void)
{
    int counter;
    int num;
    int isprime;

    for(num=2;num<=100;num++)
    {
        isprime=1;
        for(counter=2;counter<=num/2;counter++)
        {
            if(num%counter==0) isprime=0;
        }
        if(isprime==1) printf("%d is prime number\n",num);
    }

    return 0;
}
