namespace hello_c_sharp;

// 父类
class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }
}

// 子类
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
}

public class CovarianceDemo
{
    public static void Run()
    {
        // 1. 协变 Covariance
        Console.WriteLine("=== Covariance ===");

        List<Dog> dogs = new List<Dog>
        {
            new Dog("Rex"),
            new Dog("Buddy")
        };

        // IEnumerable<Dog> 可以转换为 IEnumerable<Animal>
        // 协变接口安全地表达“我可以提供更具体类型的对象，但你只需要把它们当作更通用的类型使用”。
        IEnumerable<Animal> animals = dogs;

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
        }

        // 2. 逆变 Contravariance
        Console.WriteLine("\n=== Contravariance ===");

        Action<Animal> printAnimal =
            a => Console.WriteLine($"Animal: {a.Name}");

        // Action<Animal> 可以转换为 Action<Dog>
        // 逆变则是另一种规则：对于接收参数的委托或接口，如果原来的对象能够处理更通用的类型，那么让它处理更具体的类型也是安全的。
        Action<Dog> printDog = printAnimal;

        printDog(new Dog("Spot"));
    }
}