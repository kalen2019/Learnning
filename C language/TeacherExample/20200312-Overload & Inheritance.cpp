#include<stdio.h>

class cStudent
{
public:
    cStudent() //Constructor
    {
        score = 0;
    }
    ~cStudent() //Destructor
    {
        score = 0;
    }
    void showScroe()
    {
        printf("%d\n", score);
    }
    void showScroe(int addScore) //Overload
    {
        printf("%d\n", score+addScore);
    }
public:
    int score;
};

class specialStudent:public cStudent //Inheritance
{
public:
    int score2;
};

int main(void)
{
    cStudent studentA;
    studentA.showScroe();
    studentA.score = 90;
    studentA.showScroe();

    cStudent studentB;
    studentB.score = 60;
    studentB.showScroe(10);

    specialStudent studentC;
    studentC.score = 100;
    studentC.score2 = 80;
    studentC.showScroe();

    return 0;
}
