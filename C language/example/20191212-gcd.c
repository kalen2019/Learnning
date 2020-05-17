#include <stdio.h>

int gcd(int x, int y);

int main(void)
{
    int ans = gcd(252, 105);
    printf("%d", ans);

    return 0;
}

int gcd(int x, int y)
{
    if(x%y==0) return y;
    else gcd(y, x%y);
}
