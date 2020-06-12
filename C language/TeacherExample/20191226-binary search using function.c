#include <stdio.h>
#define SIZE 7

int BinarySearch(int array[]);

int main(void)
{
    int array[SIZE] = {84, 22, 6, 28, 13, 4, 1};
    int i, j, temp;
    int answer;

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

    for(i=0;i<SIZE;i++) printf("%d\t", array[i]);
    printf("\n");

    answer = BinarySearch(array);
    printf("%d\n", answer);

    return 0;
}

int BinarySearch(int array[])
{
    int left, right, num=84;

    left=0;
    right=SIZE-1;
    printf("left=%d, right=%d\n", left, right);
    while(left <= right)
    {
        int middle = (right + left) / 2;

        if (array[middle] == num) return middle;

        if (array[middle] > num) right = middle - 1;
        else left = middle + 1;

        printf("left=%d, right=%d\n", left, right);
    }
}
