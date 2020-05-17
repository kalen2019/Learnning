#include<stdio.h>
#include<stdlib.h>
#include<math.h>

int main(void)
{
    float x1,x2,a,b,c;


    printf("這是求ax^2+bx+c=0的解的計算機.\n");
    printf("請輸入a,b,c三個係數.\n");
    scanf("%f%f%f",&a,&b,&c);

    if(b*b-4*a*c<0)
    {
        printf("無實數解\n");
    }
    else if(b*b-4*a*c>=0)
    {
        x1=(-b+sqrt((b*b)-(4*a*c)))/(2*a);
        printf("%3.1f\t",x1);
        x2=(-b-sqrt((b*b)-(4*a*c)))/(2*a);
        printf("%3.1f\n",x2);
    }
    system("pause");
    return 0;
}
