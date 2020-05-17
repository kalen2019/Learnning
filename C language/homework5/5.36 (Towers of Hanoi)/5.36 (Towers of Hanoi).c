#include<stdio.h>
#include<stdlib.h>

int Hanoi(int n,int a,int b,int c);

int main(void)
{
    int n,a,b,c;
    a=1,b=2,c=3;
    printf("Please enter Towers of Hanoi height(1-10)\n");
    scanf("%d",&n);

    Hanoi(n,a,b,c);
    system("pause");
    return 0;
}
int Hanoi(int n,int a,int b,int c)
{
    if(n>0)
    {
        Hanoi(n-1,a,c,b);
        printf("%d to %d\n",a,c);
        Hanoi(n-1,b,a,c);
    }
}
