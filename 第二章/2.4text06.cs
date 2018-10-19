//text06

using System;

class text06
{
    public static void Main()
    {
        Console.WriteLine("d{0,10:d}", 123);
        Console.WriteLine("x{0,10:x}", 123);
        Console.WriteLine("e{0,10:e}", 123.456);
        Console.WriteLine("f{0,10:f}", 123.456);
        Console.WriteLine("f{0,10:f5}", 123.456);
        Console.WriteLine("c{0,10:c}", 123456);
        Console.WriteLine("n{0,10:n}", 1234.4568);
        Console.WriteLine("p{0,10:p}", 0.05);
        Console.WriteLine("c{0,10:c}", 123456);
        Console.WriteLine("G{0,10:G}", 123.456);
    }
}