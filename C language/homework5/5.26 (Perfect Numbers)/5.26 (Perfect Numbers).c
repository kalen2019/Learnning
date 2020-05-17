#include<stdio.h>
#include<stdlib.h>


int main(void)
{
    printf("Perfect Numbers(1-10000)\n");
    for(int x=1;x<=10000;x++)
    {
        int z=0;
        for(int y=1;y<=x/2;y++)
        {
            if(x%y==0)
            {
                z+=y;
            }
        }
        if(z==x)
        {
            printf("%d=%d",x,x/2);
            for(int w=x/2;w>0;--w)
            {
                if(z%w==0&&w<z/2)
                {
                    printf("+%d",w);

                }
            }
            printf("\n");
        }
    }
    system("pause");
    return 0;
}
