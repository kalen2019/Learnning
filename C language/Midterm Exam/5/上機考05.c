#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a,b,c,d;
    scanf("%d",&a);
    printf("please enter the seconds.\n");
    d=a%60;
    c=(a-d)/60%60;
    b=a/3600;
    printf("%02d:%02d:%02d\n",b,c,d);

    system("pause");
    return 0;

}
