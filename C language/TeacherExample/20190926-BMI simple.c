#include <stdio.h>

int main(void)
{
    float w,h;
    float bmi;

    printf("This is a BMI calculator.\n");
    printf("Please enter your weight(kg).\n");
    scanf("%f",&w);
    printf("Please enter your height(m).\n");
    scanf("%f",&h);
    bmi=w/(h*h);
    printf("Your BMI is %f",bmi);

    return 0;
}
