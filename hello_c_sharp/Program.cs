namespace hello_c_sharp;
class Person
{
    public string _name;
    public int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}

class Program
{

    static void Array()
    {
        int[,] myArray = new int[10, 10];
        // int[][] myArray2 = {{12,321},{232,42}};不行
        Console.WriteLine(myArray.Length);
        Console.WriteLine(myArray.GetLength(1));
    }

    static void ClassCopy()
    {
        Person p1 = new Person("Tom", 7);
        // C#中是浅拷贝引用,如果是C++,这样写会调用默认生成的拷贝构造函数,也就是深拷贝.
        Person p2 = p1; //相当于c++:Person& p2 = p1;

        p2._name = "Jerry";

        Console.WriteLine($"{p1._name} is {p1._age} years old");
        Console.WriteLine($"{p2._name} is {p2._age} years old");
    }
    
    static void Main()
    {
        ClassCopy();
        Array();
    }
}