    #include <stdio.h>

    int main(void)
{
    int cm,diameter;

    float circumference,area;

    const float PI=3.14159;

    printf("Tjis is a circle calculate.\n");
    printf("Please enter radius(cm).\n");
    scanf("%d",&cm);
    diameter=cm*2;
    printf("Diameter = %d.\n\n",diameter);
    circumference=diameter*PI;
    printf("Circumference = %f.\n\n",circumference);
    area=cm*cm*PI;
    printf("Area = %f.\n",area);

    #include <stdlib.h>
    (int) system("pause");
    return 0;
}
