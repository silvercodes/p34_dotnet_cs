

// int a;

// int b = 45;

// int c(23);

// int d{ 12 };

#include <iostream>
int main()
{

    int arr[10];

    std::cout << arr;       // 0xAABB22
    std::cout << arr + 1;   // 0xAABB26

    std::cout << arr[1];    // *(arr + 1)

    int* arrD = new int[10];
    std::cout << arrD[1];   // *(arrD + 1)

    int** arr2 = new int*[3];
    for(int i{}; i < 3; ++i)
        arr2[i] = new int[5];



    


}