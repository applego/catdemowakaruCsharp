//text07.cs

using System;

class text07
{
    public static void Main()
    {
        Console.WriteLine("{0, 10:0000.00}", 1.2);
        Console.WriteLine("{0, 10:####.##}", 1.2);
        Console.WriteLine();
        Console.WriteLine("{0, 10:0,0}", 123456);
        Console.WriteLine("{0, 10:#,#}", 123456);
        Console.WriteLine();
        Console.WriteLine("{0,10:0,00000000.00}", 123456);
        Console.WriteLine("{0,10:#,########.##}", 123456);
        Console.WriteLine();
        Console.WriteLine("{0:(000)####-####}", 1132104566);
        Console.WriteLine("{0,20:'##'0,00}", 123456);
    }
}