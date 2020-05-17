#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a=1,b=9,c=9,d;
    for(a=1;a<=5;a++)
    {
        for(d=5-a;d>=1;d--)
        {
            printf(" ");
        }
        for(b>=1;b<=9;b++)
        {
            printf("*");
        }
        printf("\n");
        b=c-2;
        c=c-2;
    }
    int e=4,f=1,g=1,h;
    for(e=4;e>=1;e--)
    {
        for(h=5-e;h>=1;h--)
        {
            printf(" ");
        }
        for(f>=1;f<=7;f++)
        {
            printf("*");
        }
        printf("\n");
        f=g+2;
        g=g+2;
    }
    system("pause");
    return 0;
}
