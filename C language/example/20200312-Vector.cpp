#include<stdio.h>
#include<vector>
using namespace std;

int main(void)
{
    vector<int> v1;
    v1.push_back(10);
    v1.push_back(20);
    v1.push_back(30);

    for(int i=0;i<v1.size();i++)
    {
        printf("%d\n", v1[i]);
    }

    v1.pop_back();

    printf("------------\n");
    for(int i=0;i<v1.size();i++)
    {
        printf("%d\n", v1[i]);
    }

    v1.insert(v1.begin()+1 ,15);

    printf("------------\n");
    for(int i=0;i<v1.size();i++)
    {
        printf("%d\n", v1[i]);
    }

    v1.erase(v1.begin()+1);

    printf("------------\n");
    for(int i=0;i<v1.size();i++)
    {
        printf("%d\n", v1[i]);
    }

    return 0;
}
