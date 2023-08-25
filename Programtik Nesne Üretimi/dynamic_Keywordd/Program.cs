using System.Dynamic;
Console.WriteLine("Hello, World!");



dynamic instance = new ExpandoObject();
instance.P1 = 456;
instance.P2 = "ddd";

Console.WriteLine($"{instance.P1} - {instance.P2}");