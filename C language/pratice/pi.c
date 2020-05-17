#include<stdio.h>

int main(void)
{
    int i,j;
    float a,b;
    float pi;
    for(j=0;j<270503;j++)
    {
    pi=0;
    for(i=1;i<j;i++)
    {
    a=4;
    b=i*2-1;

    if(i%2==0)pi-=a/b;
    else pi+=a/b;
    }
    printf("%f\n",pi);
    if((int)(pi*1000000)==3141596) break;
    }




    return 0;
}
