#include <stdio.h>

int main(void)
{
    char grade;

    printf("please enter your grade: ");
    scanf("%c", &grade);
    switch(grade)
    {
        case 'A':
            printf("your score between 90 to 100\n");
            break;
        case 'B':
            printf("your score between 80 to 89\n");
            break;
        case 'C':
            printf("your score between 70 to 79\n");
            break;
        case 'D':
            printf("your score between 60 to 69\n");
            break;
        case 'E':
            printf("your score under 59\n");
            break;
        default:
            printf("I don't understand the grade\n");
            break;
    }

    return 0;
}
