#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    float a,b,c;
    float d,e,f;
    printf("please enter three numbers.\n");
    scanf("%f%f%f",&a,&b,&c);
    if(a>=b){
    d=a;
    }
    else if(b>a){
    d=b;
    }
    if(c>=d){
    d=c;
    }
    printf("�̤j�ȬO%.0f\n",d);
    if(a<=b){
    e=a;
    }
    else if(b<a){
    e=b;
    }
    if(c<e){
    e=c;
    }
    printf("�̤p�ȬO%.0f\n",e);
    f=(a+b+c)/3;
    printf("�����ȬO%.2f",f);

    system("pause");
    return 0;
}
