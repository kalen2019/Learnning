    #include<stdio.h>

    int main(void)
    {
        int num1,num2,num3,sum,product;
        float average;
        printf("This is a Largest Value and Smallest Value Calculate.\n");
        printf("Please enter three numbers.\n");
        scanf("%d%d%d",&num1,&num2,&num3);
        sum=num1+num2+num3;
        printf("sum is %d\n",sum);
        average=(float)sum/3;
        printf("average is %f\n",average);
        product=num1*num2*num3;
        printf("product is %d\n",product);
        int smallest;
        if(num1<num2){
        smallest=num1;
        }
        else{smallest=num2;
        }
        if(num3<smallest){
        smallest=num3;
        }
        printf("Smallest is %d\n",smallest);
        int largest;
        if(num1>num2){
        largest=num1;
        }
        else{largest=num2;
        }
        if(num3>largest){
        largest=num3;
        }
        printf("Largest is %d\n",largest);
        #include <stdlib.h>
        (int)system("pause");
        return 0;
    }
