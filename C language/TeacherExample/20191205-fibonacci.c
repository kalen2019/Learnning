#include <stdio.h>

int fibonacci(int n);

int main(void)
{
    int i;
    int val = fibonacci(5);
    printf("%d",val);
    for(i=0;i<6;i++)
    printf("%d\n",fibonacci(i));

    return 0;
}

int fibonacci(int n)
{

    if(n==0) return 0;
    else if(n==1) return 1;
    else return fibonacci(n-1)+fibonacci(n-2);
}
