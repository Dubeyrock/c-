// C# program to illustrate the concept
// of the extension methods
using System;

namespace ExtensionMethod {

// This class contains M4 and M5 method
// Which we want to add in Geek class.
// NewMethodClass is a static class
static class NewMethodClass {

    // Method 4
    public static void M4(this Geek g)
    {
        Console.WriteLine(&quot;Method Name: M4&quot;);
    }

    // Method 5
    public static void M5(this Geek g, string str)
    {
        Console.WriteLine(str);
    }
}

// Now we create a new class in which
// Geek class access all the five methods
public class GFG {

    // Main Method
    public static void Main(string[] args)
    {
        Geek g = new Geek();
        g.M1();
        g.M2();
        g.M3();
        g.M4();
        g.M5(&quot;Method Name: M5&quot;);
    }
}
}
