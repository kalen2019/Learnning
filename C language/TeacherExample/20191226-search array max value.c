#include <stdio.h>

void swap(int, int);

int array[7] = {84, 22, 6, 28, 13, 4, 1};

int main(void)
{
    int i, max, min;

    min=array[0];
    max=array[0];
    for(i=1;i<7;i++)
    {
        if(min>array[i]) min=array[i];
        if(max<array[i]) max=array[i];
    }

    printf("min=%d, max=%d\n", min, max);

    return 0;
}
