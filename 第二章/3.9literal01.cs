// bool01.cs

using System;

class literal01
{
    public static void Main()
    {
        string format = "{0}の型は、.NET型で{1}です";

        Console.WriteLine(format, "100", 100.GetType());
        Console.WriteLine(format, "100u", 100u.GetType());
        Console.WriteLine(format, "100l", 100l.GetType());
        Console.WriteLine(format, "100ul", 100ul.GetType());
        Console.WriteLine(format, "1.25", 1.25.GetType());
        Console.WriteLine(format, "1.25f", 1.25f.GetType());
        Console.WriteLine(format, "1.25m", 1.25m.GetType());
        Console.WriteLine();
        Console.WriteLine(format, "10f", 10f.GetType());
        Console.WriteLine(format, "10d", 10d.GetType());
        Console.WriteLine(format, "10m", 10m.GetType());
        Console.WriteLine();
        Console.WriteLine(format, "-10d", (-10d).GetType());
    }
}
