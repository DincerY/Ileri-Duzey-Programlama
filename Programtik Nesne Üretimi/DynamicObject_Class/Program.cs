using System.Dynamic;
Console.WriteLine("Hello, World!");


dynamic my = new MyClass();
my.Deneme2 = 123;
my.Deneme1 = "123";

dynamic deneme = my.Deneme2;
Console.WriteLine(deneme);

class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created");
    }

    readonly private Dictionary<string, object> properties = new();

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name,value);
        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result);
        
    }
}