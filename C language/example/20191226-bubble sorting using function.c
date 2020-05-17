#include <stdio.h>

void swap(int, int);

int array[7] = {84, 22, 6, 28, 13, 4, 1};

int main(void)
{
    int i, j;

    for(i=0;i<7;i++) printf("%d\t", array[i]);
    printf("\n");

    for(j=0;j<7-1;j++)
    {
        for(i=0;i<7-1;i++)
        {
            swap(i, i+1);
        }

        for(i=0;i<7;i++) printf("%d\t", array[i]);
        printf("\n");
    }

    return 0;
}

void swap(int a, int b)
{
    int temp;

    if(array[a]>array[b])
    {
        temp=array[a];
        array[a]=array[b];
        array[b]=temp;
    }
}
