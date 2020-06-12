#include <stdio.h>

int main(void)
{
    int i, j, temp;

    int array[7] = {84, 22, 6, 28, 13, 4, 1};

    for(i=0;i<7;i++) printf("%d\t", array[i]);
    printf("\n");

    for(j=0;j<7-1;j++)
    {
        for(i=0;i<7-1;i++)
        {
            //swap(array[i], array[i+1]);
            if(array[i]>array[i+1])
            {
                temp=array[i];
                array[i]=array[i+1];
                array[i+1]=temp;
            }
        }

        for(i=0;i<7;i++) printf("%d\t", array[i]);
        printf("\n");
    }

    return 0;
}
