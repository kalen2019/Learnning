#include<stdio.h>

int main(void)
{
	int a,b;
	for(a=0;a<10;a++)
    {
		for(b=0;b<10;b++)
		{
		    if(b==a||b==9-a){ printf("*");}
			else {printf(" ");}

		}

	printf("\n");
	}
	return 0;



}

