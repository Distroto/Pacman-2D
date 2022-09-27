#include <iostream>
using namespace std;

class My_Class
{
private:
    static int count;

public:
    My_Class()
    {
        cout << "Calling Constructor " << count + 1 << " time" << endl;
        count++;
    }
    static int objCount()
    {
        return count;
    }
};

int My_Class::count;

int main()
{
    My_Class my_obj1, my_obj2, my_obj3;

    int total_obj_count;

    total_obj_count = My_Class::objCount();

    cout << "\nNumber of objects:" << total_obj_count << endl;
}