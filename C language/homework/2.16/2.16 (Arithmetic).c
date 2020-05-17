    #include<stdio.h>

    int main(void)
{
    int num1,num2,sum,product,remainder;

    float divides;

    printf("Tjis is a addition,multiplication and division calculate.\n");
    printf("Please enter number1.\n");
    scanf("%d",&num1);
    printf("Please enter number2.\n");
    scanf("%d",&num2);
    sum=num1+num2;
    printf("%d+%d=%d.\n\n",num1,num2,sum);
    product=num1*num2;
    printf("%d*%d=%d.\n\n",num1,num2,product);
    divides=(float)num1/(float)num2;
    printf("%d/%d=%f.\n\n",num1,num2,divides);
    remainder=num1%num2;
    printf("%d mod %d=%d.\n\n",num1,num2,remainder);
    #include <stdlib.h>

    (int) system("pause");
    return 0;
    }
