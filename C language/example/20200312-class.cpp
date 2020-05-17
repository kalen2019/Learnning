#include<stdio.h>

class cStudent
{
public:
    void showScroe()
    {
        printf("%d", score);
    }
public:
    int score;
};

int main(void)
{
    cStudent studentA;
    studentA.score = 90;
    studentA.showScroe();

    cStudent studentB;
    studentB.score = 60;
    studentB.showScroe();

    return 0;
}
