#include <stdio.h>

int main(void)
{
    int grade = 0;
    int counter = 0;
    int sum = 0;

    printf("Please enter the grade.\n");
    scanf("%d", &grade);

    while(grade != -1)
    {
        sum = sum + grade;
        counter = counter + 1;

        printf("Please enter the grade.\n");
        scanf("%d", &grade);
    }
    printf("Average is %d", sum/counter);

    return 0;
}
