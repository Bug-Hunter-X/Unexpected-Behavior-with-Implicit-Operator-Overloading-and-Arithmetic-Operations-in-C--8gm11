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

    // Added operator to handle addition
    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
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
        int num2 = (int)(obj2 + 5); // Explicit conversion after addition
        Console.WriteLine(num2);     // Output: 10
    }
}