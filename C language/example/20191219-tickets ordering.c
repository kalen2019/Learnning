#include <stdio.h>
#define SIZE 4

int main(void)
{
    int i, exit, total_price = 0;
    int ticket_type, ticket_num;
    int ticket_total[SIZE] = {0};
    int ticket_price[SIZE] = {300, 150, 100, 200};
    char ticket_name[SIZE][20] = {"Normal Tickets", "Respect Tickets", "Child Tickets", "VIP Tickets"};
    //int a[3][4] = {{300, 150, 100, 200}, {300, 150, 100, 200}, {300, 150, 100, 200}};

    printf("This is a Movies Ordering Program.\n");

    do
    {
        printf("Please choice the ticket that you want to buy.\n");
        for(i=0;i<SIZE;i++) printf("%d. %s $%d\n", i+1, ticket_name[i], ticket_price[0]);

        printf("What kind tickets that you want to buy?(1-4)\n");
        scanf("%d", &ticket_type);
        printf("How many tickets that you want to buy?\n");
        scanf("%d", &ticket_num);

        ticket_total[ticket_type-1]+=ticket_num;

        for(i=0;i<SIZE;i++) printf("%s x %d\n", ticket_name[i], ticket_total[i]);

        printf("Continue press 1 and Exit press 0.\n");
        scanf("%d", &exit);
    }while(exit!=0);

    for(i=0;i<SIZE;i++) total_price += ticket_total[i] * ticket_price[i];
    printf("Total price is %d", total_price);

    return 0;
}
