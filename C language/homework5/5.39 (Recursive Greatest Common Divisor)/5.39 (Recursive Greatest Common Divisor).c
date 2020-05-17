#include<stdio.h>
#include<stdlib.h>

int gcd(int x,int y);

int main(void)
{
    int x,y,z;
    scanf("%d%d",&x,&y);
    if(y>x)
    {
        z=x;
        x=y;
        y=z;
    }
    int ans=gcd(x,y);
    printf("GCD(%d,%d)=%d\n",x,y,ans);

    system("pause");
    return 0;
}
int gcd(int x,int y)
{
    if(x%y==0)return y;
    else return gcd(y,x%y);
}
