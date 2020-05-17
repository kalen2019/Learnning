#include<stdio.h>
#include<stdlib.h>

int GCD(int x,int y);
int LCM(int x,int y);
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
    int ans=LCM(x,y);
    printf("LCM(%d,%d)=%d\n",x,y,ans);

    system("pause");
    return 0;
}
int GCD(int x,int y)
{
    if(x%y==0)return y;
    else return GCD(y,x%y);
}
int LCM(int x, int y)
{
    return x*y / GCD(x,y);
}
