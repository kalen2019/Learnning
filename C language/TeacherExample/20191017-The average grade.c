#include <stdio.h>

int main(void)
{
    int grade;
    int counter = 0;
    int sum = 0;

    while(counter < 10)
    {
        printf("Please enter the grade.\n");
        scanf("%d", &grade);

        sum = sum + grade;
        counter = counter + 1;
    }
    printf("Average is %d", sum/10);

    return 0;
}
