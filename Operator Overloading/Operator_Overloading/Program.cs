Student student = new()
{
    Name = "Dinçer"
};

Book book = new()
{
    Name = "Düşün ve Zengin Ol",
    Author = "Napoleon Hill"
};


var result = student + book;
Console.WriteLine();

class Student
{
    public Student()
    {
        Books = new();
    }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
} 

class Book
{
    public string Name { get; set; }
    public string Author { get; set; }

    public static Student operator +(Student s, Book b)
    {
        s.Books.Add(b);
        return s;
    }
        

}