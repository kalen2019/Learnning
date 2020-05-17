#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    printf("Please enter three sides.\n");
    int a,b,c;
    scanf("%d%d%d",&a,&b,&c);
    if(a+b<c||a+c<b||b+c<a){
    printf("No,it is not a triangle.\n");
    }
    else if(a==b||b==c||a==c){
    printf("This is a soscele triangle.\n");
    }
    else if(a==b==c){
    printf("This is a regular triangle.\n");
    }
    else if(a*a+b*b==c*c||b*b+c*c==a*a||a*a+c*c==b*b){
    printf("This is a rectangular triangle.\n");
    }
    else if(a*a+b*b<c*c||b*b+c*c<a*a||a*a+c*c<b*b){
    printf("This is a obtuse triangle.\n");
    }
    else if(a*a+b*b>c*c||b*b+c*c>a*a||a*a+c*c>b*b){
    printf("This is a acute triangle.\n");
    }
    else if(a*a+b*b==c*c&&a==b||b*b+c*c==a*a&&b==c||a*a+c*c==b*b&&a==c){
    printf("This is a isosceles triangle.\n");
    }

    system("pause");
    return 0;
}
