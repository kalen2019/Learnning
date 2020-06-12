#include <stdio.h>

int main(void)
{
    int i;
    float a,b;
    float pi=0;

    for(i=1;i<50;i++)
    {
        a=4;
        b=i*2-1;

        if(i%2==0) pi-=a/b;
        else pi+=a/b;
    }
    printf("%f", pi);

    return 0;
}
