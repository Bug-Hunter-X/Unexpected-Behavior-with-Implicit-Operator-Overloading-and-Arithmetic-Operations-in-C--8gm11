public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj) 
    {
        return obj.MyProperty; 
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value); 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj = 10; // Implicit conversion from int to MyClass
        int num = obj;     // Implicit conversion from MyClass to int

        Console.WriteLine(obj.MyProperty); // Output: 10
        Console.WriteLine(num);           // Output: 10

        MyClass obj2 = new MyClass(5);
        int num2 = obj2 + 5; // This will cause a compile-time error!
        Console.WriteLine(num2); 
    }
}