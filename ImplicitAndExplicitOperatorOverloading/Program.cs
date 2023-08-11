A a = new B();
A a2 =(A) new B();  //Implicit. Bu kavram uygulandığında kapalı bir şekilde dönüldüğü gibi açık bir şekilde de dönülebilir

B b = (B) new A();  //Explicit

class A
{
    public string AMember { get; set; }
    public static implicit operator A(B b)
    {
        return new A(){AMember = b.BMember};
    }
}
class B
{
    public string BMember { get; set; }

    public static explicit operator B(A a)
    {
        return new B();
    }
}