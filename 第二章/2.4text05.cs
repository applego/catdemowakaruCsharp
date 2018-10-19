//text05

using System;

class text05
{
    public static void Main()
    {
        int x = 10, y = 123456789;

        Console.WriteLine("12345678901234567890123456789");
        Console.WriteLine("{0,10}", "abc");
        Console.WriteLine("{0,5}", "def");
        Console.WriteLine("{0,0}", "ghi");
        Console.WriteLine("{0,10}{1,-10}{2,3}", "あ", "い","う");
        Console.WriteLine("{0,-10}{1,-10}", "あ", "い");
        Console.WriteLine("x= {0,5},y = {1,3}", x, y);
    }
}