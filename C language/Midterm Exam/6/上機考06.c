#include<stdio.h>
#include<stdlib.h>
#include<math.h>

int main(void)
{
    float x1,x2,a,b,c;


    printf("�o�O�Dax^2+bx+c=0���Ѫ��p���.\n");
    printf("�п�Ja,b,c�T�ӫY��.\n");
    scanf("%f%f%f",&a,&b,&c);

    if(b*b-4*a*c<0)
    {
        printf("�L��Ƹ�\n");
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
