#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a=1,b=1,c=1;
    printf("(A)\n");
    for(a==1;a<=10;a++)
    {
        for(b<=10;b>=1;b--)
        {
            printf("*");

        }
        printf("\n");
        b=c+1;
        c++;
    }
    printf("\n");
    int d=10,e=1,f=1;
    printf("(B)\n");
    for(d==10;d>=1;d--)
    {
        for(e>=1;e<=10;e++)
        {
            printf("*");

        }
        printf("\n");
        e=f+1;
        f++;
    }
    printf("\n");
    int g=10,h=1,i=1,j=0;
    printf("(C)\n");
    for(g==10;g>=1;g--)
    {

        for(j=10-i;j<=8;j++)
        {
        printf(" ");
        }

        for(h>=1;h<=10;h++)
        {
            printf("*");
        }
        printf("\n");
        h=i+1;
        i++;
    }
        int k=1,l=1,m=1,n=0;
    printf("(D)\n");
    for(k==1;k<=10;k++)
    {

        for(n=10-m;n>=1;n--)
        {
        printf(" ");
        }

        for(l<=10;l>=1;l--)
        {
            printf("*");
        }
        printf("\n");
        l=m+1;
        m++;
    }
    system("pause");
    return 0;
}
