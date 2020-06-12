#include<stdio.h>

int main(void)
{
    FILE *fp;
    fp = fopen("text.csv","w");
    for(int i=0;i<10;i++)
    {
        for(int j=0;j<10;j++)
        {
            fprintf(fp, "%d, ", i*j);
        }
        fprintf(fp, "\n");
    }
    fclose(fp);

    return 0;
}
