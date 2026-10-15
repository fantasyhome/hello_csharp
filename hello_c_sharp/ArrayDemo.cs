namespace hello_c_sharp;

public class ArrayDemo
{
    public static void Run()
    {
        int[,] myArray = new int[10, 10];

        Console.WriteLine(myArray.Length);
        Console.WriteLine(myArray.GetLength(1));
    }
}