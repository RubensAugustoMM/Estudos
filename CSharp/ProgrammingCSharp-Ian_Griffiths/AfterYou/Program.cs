using System;

namespace AfterYou;

public class Program
{
    public static void Main()
    {
        int i = AfterYou.Value;
    }
}

public class AfterYou
{
    static AfterYou()
    {
        Console.WriteLine("AfterYou static constructor starting");
        Console.WriteLine("NoAfterYou> AfterYou.Value: = " + NoAfterYou.Value);
        Value = 123;
        Console.WriteLine("Afteryou static constructor ending");
    }

    public static int Value = 42;
}

public class NoAfterYou
{
    static NoAfterYou()
    {
        Console.WriteLine("NoAfterYou static constructor starting");
        Console.WriteLine("NoAfterYou: AfterYou.Value: = " + AfterYou.Value);
        Value = 456;
        Console.WriteLine("NoAfterYou static constructor ending");
    }
    public static int Value = 42;
}