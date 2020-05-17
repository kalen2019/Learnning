#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a,b,c;
    printf("please enter three numbers.\n");
    scanf("%d%d%d",&a,&b,&c);

    while(a!=0){
    printf("*");
    a=a-1;
    }
    printf("\n");
    while(b!=0){
    printf("*");
    b=b-1;
    }
    printf("\n");
    while(c!=0){
    printf("*");
    c=c-1;
    }
    printf("\n");

    system("pause");
    return 0;
}
