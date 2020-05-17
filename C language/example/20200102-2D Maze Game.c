#include <stdio.h>

void DrawMap(int map[10][10]);
void InputCommand(int map[10][10]);

int playerX=1, playerY=9;

int main(void)
{
    int map[10][10] = {{0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                       {0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                       {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                       {0, 1, 1, 1, 0, 0, 0, 1, 0, 0},
                       {0, 0, 0, 1, 1, 1, 1, 1, 1, 0},
                       {0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                       {0, 1, 1, 1, 0, 0, 1, 0, 0, 0},
                       {0, 1, 0, 0, 0, 1, 1, 1, 1, 0},
                       {0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
                       {0, 1, 0, 0, 0, 0, 0, 0, 0, 0}};

    do{
        DrawMap(map);
        InputCommand(map);
    }while(1);


    return 0;
}

void DrawMap(int map[10][10])
{
    int i, j;

    for(j=0;j<10;j++)
    {
        for(i=0;i<10;i++)
        {
            if(playerX==i && playerY==j) printf("¡¹");
            else if(map[j][i] == 1) printf("¡@");
            else printf("¡½");
        }
        printf("\n");
    }
}

void InputCommand(int map[10][10])
{
    int command;

    printf("Please enter the command. (1:¡ô, 2:¡õ, 3:¡ö, 4:¡÷)\n");
    scanf("%d", &command);
    if(command == 1)
    {
        if(playerY>0 && map[playerY-1][playerX]==1) playerY-=1;
        else printf("Please try again!\n");
    }
}
