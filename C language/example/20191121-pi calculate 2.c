#include <stdio.h>

int main(void)
{
    int i,j;
    float a,b;
    float pi;

    for(j=160000;j<170000;j++)
    {
        pi=0;
        for(i=1;i<j;i++)
        {
            a=4;
            b=i*2-1;

            if(i%2==0) pi-=a/b;
            else pi+=a/b;
        }
        printf("%d terms: %f\n", j, pi);
        if((int)(pi * 100000) == 314159) break;
    }

    return 0;
}
