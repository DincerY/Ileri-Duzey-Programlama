// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int _b = 0;
string _d = "";

MyClass<int> myClass = new MyClass<int>();

myClass.X(out _b, 123, out _d);


class MyClass<T>
{
    private T field;
    public T Property { get; set; }

    public T Method(Func<T,bool> predicate)
    {
        return field;
    }

    public int X(out int b,int c,out string d)
    {
        b = 0; 
        d = "mehmet";
        return c;
    }
}