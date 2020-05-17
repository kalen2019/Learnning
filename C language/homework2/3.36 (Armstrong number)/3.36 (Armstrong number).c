#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int x,y,z;
    printf("Armstrong number between 100 and 999:\n");
    unsigned int n=100;
    while(n<=999)
    {
    x=n/100;
    y=(n-x*100)/10;
    z=n-x*100-y*10;

    if(n==x*x*x+y*y*y+z*z*z){
    printf("%d\n",n);
    }
    n=n+1;
    }

    system("pause");
    return 0;
}
