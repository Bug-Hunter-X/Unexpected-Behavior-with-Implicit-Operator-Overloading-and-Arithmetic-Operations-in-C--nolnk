public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = obj1;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; // Unexpected behavior here
        Console.WriteLine(value2); // Output may be unexpected due to operator overloading
    }
}