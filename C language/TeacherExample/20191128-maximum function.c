#include <stdio.h>

int maximum(int a,int b, int c);

int main(void)
{
    int a,b,c;
    scanf("%d%d%d",&a,&b,&c);
    int maxValue = maximum(a,b,c);
    printf("Maximum value is %d", maxValue);

    return 0;
}

int maximum(int a,int b, int c)
{
    if(a>b && a>c) return a;
    else if(b>a && b>c) return b;
    else if(c>a && c>b) return c;
}
