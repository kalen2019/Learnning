#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a=1,b=1,c=1;
    for(a=1;a<=500;a++)
    for(b=1;b<=500;b++)
    for(c=1;c<=500;c++)
    {
       if(a*a+b*b==c*c)
        {
            printf("%d^2+%d^2=%d^2\n",a,b,c/*(c*c)*/);
        }
    }
    system("pause");
    return 0;
}
