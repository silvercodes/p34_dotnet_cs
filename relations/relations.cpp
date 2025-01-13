#include <iostream>

// ---- Композиция (является частью, являетя владельцем, "имеет") ----
// 1. Часть (член класса, поле) является НЕОТЪЕМЛЕМОЙ частью целого (в т.ч. и с точки зрения логики приложения)
// 2. Часть (член класса, поле) в процессе своей жизни может принадлежать только одному объекту целого
// 3. Целое управляет жизнью части
// *4. Часть (член класса, поле) ПОНЯТИЯ НЕ ИМЕЕТ о существовании целого


//class Point
//{
//private:
//    int x;
//    int y;
//
//public:
//    Point(int x = 0, int y = 0):
//        x{x},
//        y{y}
//    {}
//
//    void set(int x = 0, int y = 0)
//    {
//        this->x = x;
//        this->y = y;
//    }
//
//    friend std::ostream& operator<<(std::ostream& out, const Point& obj)
//    {
//        out << '(' << obj.x << ';' << obj.y << ')';
//
//        return out;
//    }
//};
//
//class Unit
//{
//private:
//    std::string title;
//    Point* position;
//
//public:
//    Unit(const std::string& title, const Point& p):
//        title{title},
//        position{ new Point{ p } }
//    {}
//
//    Unit(const std::string& title, int x, int y) :
//        title{ title },
//        position{ new Point{ x, y } }
//    {}
//
//    // copy ctor ....
//
//    void move(int x, int y)
//    {
//        this->position->set(x, y);
//    }
//
//
//    ~Unit()
//    {
//        if (this->position != nullptr)
//            delete this->position;
//    }
//
//    friend std::ostream& operator<<(std::ostream& out, const Unit& obj)
//    {
//        out << obj.title << " position" << *obj.position << '\n';
//
//        return out;
//    }
//};


//int main()
//{
//    Unit a{ "Vasia", Point{3, 4} };
//    Unit b{ "Petya", 5, 6 };
//
//    std::cout << a;
//
//    a.move(12, 13);
//    std::cout << a;
//}


// class Point
// {
// private:
//    int x;
//    int y;
   
// public:
//    Point(int x = 0, int y = 0):
//        x{x},
//        y{y}
//    {}
   
//    void set(int x = 0, int y = 0)
//    {
//        this->x = x;
//        this->y = y;
//    }
   
//    friend std::ostream& operator<<(std::ostream& out, const Point& obj)
//    {
//        out << '(' << obj.x << ';' << obj.y << ')';
   
//        return out;
//    }
// };

// class PositionBuilder
// {
// public:
//    Point* generatePoint(const Point& p)
//    {
//        return new Point{ p };
//    }
// };
   
// class Unit
{
private:
   std::string title;
   PositionBuilder pb;
   Point* position;
   
public:
   Unit(const std::string& title, const Point& p):
       title{title},
       pb{ }
   {
       this->position = pb.generatePoint(p);
   }
   
   Unit(const std::string& title, int x, int y) :
       title{ title },
       pb{ }
   {
       this->position = pb.generatePoint({x, y});
   }
   
   // copy ctor ....
   
   void move(int x, int y)
   {
       this->position->set(x, y);
   }
   
   
   ~Unit()
   {
       if (this->position != nullptr)
           delete this->position;
   }
   
   friend std::ostream& operator<<(std::ostream& out, const Unit& obj)
   {
       out << obj.title << " position" << *obj.position << '\n';
   
       return out;
   }
};






// ---- Агрегация (имеет) ----
// 1. Часть (член класса, поле) является НЕОТЪЕМЛЕМОЙ частью целого (в т.ч. и с точки зрения логики приложения)
// ~ 2. Часть (член класса, поле) в процессе своей жизни может принадлежать нескольким объектам целого
// ~ 3. Целое НЕ управляет жизнью части
// *4. Часть (член класса, поле) ПОНЯТИЯ НЕ ИМЕЕТ о существовании целого


//class Teacher
//{
//private:
//	std::string name;
//
//public:
//	Teacher(const std::string& name):
//		name{name}
//	{}
//
//	std::string& getName()
//	{
//		return this->name;
//	}
//};
//
//
//class Group
//{
//private:
//	std::string title;
//	Teacher* teacher{ nullptr };
//
//public:
//	Group(const std::string& title):
//		title{ title }
//	{}
//
//	void setTeacher(Teacher* t)
//	{
//		this->teacher = t;
//	}
//};
//
//int main()
//{
//	Teacher a{ "Vasia" };
//	Teacher b{ "Petya" };
//
//	Group g1{ "p31" };
//	g1.setTeacher(&a);
//	//
//	//
//	g1.setTeacher(&b);
//}


// class CompressEngine
// {
// private:
// 	std::string alg;

// public:
// 	CompressEngine(std::string alg):
// 		alg{alg}
// 	{}

// 	void run(std::string filePath)
// 	{
// 		std::cout << "alg " << this->alg << " is used for file: " << filePath << '\n';
// 	}
// };


// class ArchiveManager
// {
// private:
// 	std::string filePath;
// 	CompressEngine* compressEngine;

// public:
// 	ArchiveManager(std::string  filePath):
// 		filePath{filePath},
// 		compressEngine{nullptr}
// 	{}

// 	void setEngine(CompressEngine* engine)
// 	{
// 		this->compressEngine = engine;
// 	}

// 	void compress()
// 	{
// 		if (this->compressEngine == nullptr)
// 			std::cout << "Invalid compress engine!...\n";
// 		else
// 			this->compressEngine->run(this->filePath);
// 	}
// };


// int main()
// {
// 	CompressEngine zip{ "ZIP" };
// 	CompressEngine rar{ "RAR" };
// 	CompressEngine deflate{ "DEFLATE" };


// 	ArchiveManager manager{ "/usr/bin" };

// 	manager.setEngine(&zip);
// 	manager.compress();

// 	manager.setEngine(&deflate);
// 	manager.compress();

// }







// ---- Ассоциация (использует, связан с...) ----
// 1. Первый объект не связан со вторым изначально (так может оставаться и в дальнейшем)
// 2. Первый объект в один момент времени может быть связан с несколькими объектами второго класса
// 3. Первый объект не управляет жизнью второго объекта (и наоборот)
// 4. Первый объект может знать о существовании второго (и наоборот)


//// --- унарная однонаправленная ассоциация
//class Teacher
//{
//private:
//	Group* group{ nullptr };
//};
//
//
//class Group
//{
//private:
//
//};


//// --- унарная двунаправленная ассоциация
//class Teacher
//{
//private:
//	Group* group{ nullptr };
//};
//
//
//class Group
//{
//private:
//	Teacher* teacher{ nullptr };
//};


//// --- n-арная однонаправленная ассоциация
//class Teacher
//{
//private:
//	Group* groups{ nullptr };				// dynamic array
//};
//
//
//class Group
//{
//private:
//
//};


// --- n-арная двунаправленная ассоциация
//class Teacher
//{
//private:
//	Group* groups{ nullptr };				// dynamic array
//};
//
//
//class Group
//{
//private:
//	Teacher* teachers{ nullptr };				// dynamic array
//};



////// --- однонаправленная рефлексивная ассоциация
//
//class Category
//{
//public:
//	std::string title;
//	Category* parent;
//	Category(std::string title):
//		title{title}
//	{}
//};
//
//int main()
//{
//	Category a{ "smartphones" };
//	Category b{ "laptops" };
//	Category c{ "for gamers" };
//	Category d{ "for work" };
//	Category e{ "flagmans" };
//
//	c.parent = &b;
//	d.parent = &b;
//	e.parent = &a;
//}


//// --- двунаправленная рефлексивная ассоциация
//#include <vector>
//class Category
//{
//public:
//	std::string title;
//	Category* parent;
//	std::vector<Category*> childCategories;
//	Category(std::string title) :
//		title{ title }
//	{}
//};
//
//int main()
//{
//	Category a{ "smartphones" };
//	Category b{ "laptops" };
//	Category c{ "for gamers" };
//	Category d{ "for work" };
//	Category e{ "flagmans" };
//
//	c.parent = &b;
//	d.parent = &b;
//	e.parent = &a;
//}


//// --- косвенная (неявная) ассоциация

class Category
{
public:
	int id;
	std::string title;
	int* productIds;				// dynamic array

};

class Product
{
public:
	int id;
	std::string title;
	int categoryId;
};







// ------example_1
//#include <vector>
//
//
//class Teacher;
//
//
//class Group
//{
//private:
//	std::string title;
//	Teacher* teacher{ nullptr };
//public:
//	Group(std::string title);
//
//	void addTeacher(Teacher* t);
//
//	void show();
//};
//
//Group::Group(std::string title) :
//	title{ title }
//{}
//
//void Group::addTeacher(Teacher* t)
//{
//	this->teacher = t;
//}
//
//void Group::show()
//{
//	std::cout << "Group " << this->title << '\n';
//}
//
//
//class Teacher
//{
//private:
//	std::string name;
//	std::vector<Group*> groups;
//public:
//	Teacher(std::string name);
//
//	void addGroup(Group* g);
//
//	void show();
//};
//
//Teacher::Teacher(std::string name) :
//	name{ name }
//{}
//
//void Teacher::addGroup(Group* g)
//{
//	groups.push_back(g);
//
//	g->addTeacher(this);
//}
//
//void Teacher::show()
//{
//	std::cout << "Teacher " << this->name << '\n';
//	std::cout << "Groups:\n";
//
//	for (Group* g : this->groups)
//		g->show();
//}
//
//
//
//int main()
//{
//	Teacher t1{ "Vasia" };
//	Teacher t2{ "Petya" };
//	Teacher t3{ "Dima" };
//
//	Group g1{ "group_1" };
//	Group g2{ "group_2" };
//	Group g3{ "group_3" };
//	Group g4{ "group_4" };
//	Group g5{ "group_5" };
//
//	t1.addGroup(&g2);
//	t1.addGroup(&g4);
//
//	t1.show();
//
//	// g2.addTeacher(&t3);
//
//
//}
//



// ------example_2
//#include <vector>
//
//class Unit
//{
//private:
//	std::vector<Sward*> swards;
//
//public:
//	void addSward(Sward* s)
//	{
//		swards.push_back(s);
//	}
//};
//
//class Sward
//{
//
//};
//
//int main()
//{
//	Sward a;
//	Sward b;
//	Sward c;
//	Sward d;
//	Sward e;
//	Sward f;
//	Sward g;
//
//	Unit vasia;
//	vasia.addSward(&d);
//}






