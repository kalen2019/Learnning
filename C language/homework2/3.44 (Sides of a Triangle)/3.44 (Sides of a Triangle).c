#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    printf("Please enter three sides.\n");
    int a,b,c;
    scanf("%d%d%d",&a,&b,&c);
    if(a+b>c&&a+c>b&&b+c>a){
    printf("Yes,it is a triangle.\n");
    }
    else{
    printf("No,it is not a triangle.\n");
    }
    system("pause");
    return 0;
}
