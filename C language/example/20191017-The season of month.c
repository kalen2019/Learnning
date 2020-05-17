#include <stdio.h>

int main(void)
{
    int month;

    printf("Please enter the month:\n");
    scanf("%d", &month);

    if(month >= 1 && month <= 12)
    {
        if(month >= 3 && month <= 5) printf("The season is spring\n");
        else if(month >= 6 && month <= 8) printf("The season is summer\n");
        else if(month >= 9 && month <= 11) printf("The season is autumn\n");
        else if(month >= 12 || month <= 2) printf("The season is winter\n");
    }
    else printf("Are you kidding? Please enter again.\n");

    return 0;
}
