#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    float a;
    int b=1;
    float pi=0;
    printf("please enter a number.\n");
    scanf("%f",&a);
    while(a!=0)
    {
    if((b+1)%4==0)pi=pi-4/(float)b;
    if((b-1)%4==0)pi=pi+4/(float)b;
    b=b+2;
    a--;
    }
    printf("pi=%f",pi);
    system("pause");
    return 0;




}
