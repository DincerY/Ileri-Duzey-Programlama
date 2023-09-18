// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Return Types
class A
{
    public virtual A X()
    {
        return this;
    }
}
class B : A
{
    public override B X()
    {
        return this;
    }
}


#endregion
 


#region Examples

////Covariance
//object[] isimler = new string[]{"Mahmut","Orhan"};

////Covariance
//A[] aArray = new B[3];

////Covariance
//IEnumerable<object> kalemler = new List<string>() {"Faber", "Pensan","Fatih"};

////Covariance
//Func<A> funcA = GetB;
//B GetB()
//{
//    return new B();
//}

////Contravariance
//Action<string> xDelegate = XMethod;
//void XMethod(object o){}



//class A
//{

//}

//class B : A
//{

//}

#endregion