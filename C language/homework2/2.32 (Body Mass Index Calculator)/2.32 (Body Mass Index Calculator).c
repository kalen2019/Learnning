#include<stdio.h>
#include<stdlib.h>

int main(void)
{   float CM,M,Kg,BMI;
    printf("This is a BMI Calculate.\n");
    printf("Please enter the weight(kg).\n");
    scanf("%f",&Kg);
    printf("Please enter the height(cm).\n");
    scanf("%f",&CM);
    M=CM/100;
    BMI=Kg/(M*M);
    printf("BMI is %5.2f\n",BMI);
    if(BMI<18.5)printf("you are underweight.\n");
    else if(BMI<24.9)printf("you are normal.\n");
    else if(BMI<29.9)printf("you are overweight.\n");
    else printf("you are obese.\n");
    system("pause");
    return 0;


}
