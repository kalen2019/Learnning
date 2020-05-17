#include <stdio.h>

int main(void)
{
    int grade;

    printf("Please enter your grade:\n");
    scanf("%d", &grade);

    if(grade > 60) printf("passed\n");
    else
    {
        if(grade < 60)
            printf("failed\n");
        }
        else
        {
            printf("Oh my god\n");
        }
    }

    /*if(grade > 60) printf("passed\n");
    else if(grade < 60) printf("failed\n");
    else printf("Oh my god\n");*/

    printf("end program");

    return 0;
}
