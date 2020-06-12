#include <stdio.h>

int main(void)
{
    float w,h;
    float bmi;

    printf("This is a BMI calculator.\n");
    printf("Please enter your weight(kg).\n");
    scanf("%f",&w);
    printf("Please enter your height(cm).\n");
    scanf("%f",&h);
    h=h/100;
    bmi=w/(h*h);
    printf("Your BMI is %f.\n",bmi);

    /*if(bmi < 18.5) printf("you are underweight.");
    if(bmi >= 18.5 && bmi < 25) printf("you are Normal.");
    if(bmi >= 25 && bmi < 30) printf("you are underweight.");
    if(bmi >= 30) printf("you are underweight.");*/

    if(bmi < 18.5) printf("you are underweight.");
    else if(bmi < 24.9) printf("you are Normal.");
    else if(bmi < 29.9) printf("you are underweight.");
    else printf("you are underweight.");

    /*BMI VALUES
    Underweight: less than 18.5
    Normal: between 18.5 and 24.9
    Overweight: between 25 and 29.9
    Obese: 30 or greater*/

    return 0;
}
