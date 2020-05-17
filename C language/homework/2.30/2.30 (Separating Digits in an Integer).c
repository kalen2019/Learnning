    #include <stdio.h>


    int main(void)
    {
        int num1,num2,num3,num4,num5,digit;
        printf("This is a Separating Digits calculate.\n");
        printf("Please enter five-digit numbers.\n");
        scanf("%d",&digit);
        num5=(int)digit%10;
        num4=(int)(digit%100)/10;
        num3=(int)(digit%1000)/100;
        num2=(int)(digit%10000)/1000;
        num1=(int)(digit%100000)/10000;
        printf("your five-digit numbers is   %d   %d   %d   %d   %d.\n",num5,num4,num3,num2,num1);

        #include <stdlib.h>
        (int) system("pause");
        return 0;
    }
