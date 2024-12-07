using System.Diagnostics;
using System.Runtime.InteropServices;




using System;

class BaseClass
{
    public void Display()
    {
        Console.WriteLine("BaseClass Display method.");
    }
}

class DerivedClass : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("DerivedClass Display method.");
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        DerivedClass derivedObj = new DerivedClass();
        BaseClass baseRefToDerived = new DerivedClass();

        baseObj.Display();           // Output: BaseClass Display method.
        derivedObj.Display();        // Output: DerivedClass Display method.
        baseRefToDerived.Display();  // Output: BaseClass Display method.
    }
}

