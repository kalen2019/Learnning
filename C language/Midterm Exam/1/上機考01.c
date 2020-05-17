#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a;
    int sum=0,digits=0;

    printf("please enter a number.\n");
    scanf("%d",&a);
    while(a!=0)
    {
    sum+=a%10;
    a/=10;
    digits++;
    }
    printf("digits is %d\n",digits);
    printf("sum=%d\n",sum);


    system("pause");
    return 0;
}
