

// int a;

// int b = 45;

// int c(23);

// int d{ 12 };

// #include <iostream>
// int main()
// {

//     int arr[10];

//     std::cout << arr;       // 0xAABB22
//     std::cout << arr + 1;   // 0xAABB26

//     std::cout << arr[1];    // *(arr + 1)

//     int* arrD = new int[10];
//     std::cout << arrD[1];   // *(arrD + 1)

//     int** arr2 = new int*[3];
//     for(int i{}; i < 3; ++i)
//         arr2[i] = new int[5];
// }


// int f1(int a)
// {

// }

// int f2(int* a)
// {

// }

// int f3(int& a)
// {

// }

// int main()
// {
//     int val{34};

//     f1(val);
//     f2(&val);



// class User
// {

// };

// int main()
// {
//     User a{};
//     User* b = new User{};

// }


// class User
// {
//     public:
//         int id;

//         User()
//         {}

//         User(const User& obj)
//         {

//         }

//         void render()
//         {

//         }

//         //void log() = 0;
// };

// User* a = new User();


#include <string>

// class User
// {
// private:
//     int id;
//     std::string email;
// public:
//     User(int id, std::string email):
//         id{id}
//     {
//         this->email = "no_email";
//     }


// }


#include <iostream>
// class Logger
// {
//     protected:
//         int level = 3;
// };

// class FileLogger: public Logger
// {
//     public:
//         void test()
//         {
//             std::cout << this->level << '\n';
//         }
// };

// int main()
// {
//     Logger* logger = new Logger{};
//     // logger->level = 10;              // ERROR
//     FileLogger* flogger = new FileLogger{};
//     // flogger->test = 10;              // ERROR
// }   



// class Unit
// {
// private:
//     static const int count = 0;
//     int hp;

// public:
//     Unit(int hp):
//         hp{hp}
//     {}

//     int getHp()
//     {
//         return hp;
//     }
//     void setHp(int hp)
//     {
//         this->hp = hp < 0 ? 0 : hp;
//     }
//     bool isEmpty()
//     {
//         return this->hp == 0;
//     }
// };

// // int Unit::count = 0;


// int main()
// {
//     int a = nullptr;
//     int* b = nullptr;

// }



class ILogger
{
    public:
        virtual void render() = 0;
        virtual void execute() = 0;
};


class FileLogger: public ILogger
{

};

