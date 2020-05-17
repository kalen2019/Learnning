#include<stdio.h>
#include<stdlib.h>

int maximum(int a,int b,int c);

int main(void)
{
    int x,y,z;
    printf("Enter three integers: ");
    scanf("%d%d%d",&x,&y,&z);
    printf("Maximum is:%d\n",maximum(x,y,z));
    system("pause");
    return 0;
}
int maximum(int a,int b,int c)
{
    int max=a;
    if(b>max){
        max=b;
    }
    if(c>max){
        max=c;
    }
    return max;
}
