namespace csharp_concept.keywords.Modifiers.statickeyword;

public static class Utility
{
    static Utility()
    {
        // Static constructor to initialize static members
        Console.WriteLine("Static constructor called");
    }

    public static void DoSomething()
    {
        Console.WriteLine("Doing something");
    }
}
