#include<stdio.h>
#include<stdlib.h>

int isprime(int ,int );

int main()
{

    int x;
    int prime;
    printf("Please enter a number:");
    scanf("%d",&x);

    prime = isprime(x,x/2);

    if(prime==1)printf("%d is a prime number.\n",x);
    else printf("%d is not a prime number.\n",x);
    system("pause");
    return 0;
}
int isprime(int x,int y)
{
    if(y==1)return 1;
    else if(y<1)return 0;
    else
        {
            if(x%y==0)return 0;
            else isprime(x,y-1);
        }
}
