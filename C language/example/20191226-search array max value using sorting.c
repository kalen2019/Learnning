#include <stdio.h>
#define SIZE 7

void swap(int, int);

int main(void)
{
    int i, j, temp;
    int array[SIZE] = {84, 22, 6, 28, 13, 4, 1};

    for(j=0;j<SIZE-1;j++)
    {
        for(i=0;i<SIZE-1;i++)
        {
            if(array[i]>array[i+1])
            {
                temp=array[i];
                array[i]=array[i+1];
                array[i+1]=temp;
            }
        }
    }

    printf("min=%d, max=%d\n", array[0], array[SIZE-1]);

    return 0;
}
