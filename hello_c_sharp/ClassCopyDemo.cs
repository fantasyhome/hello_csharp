namespace hello_c_sharp;

public class ClassCopyDemo
{
    public static void Run()
    {
        Person p1 = new Person("Tom", 7);
        Person p2 = p1;

        p2._name = "Jerry";

        Console.WriteLine($"{p1._name} is {p1._age} years old");
        Console.WriteLine($"{p2._name} is {p2._age} years old");
    }
}