// bool01.cs

using System;

class bool01
{
    public static void Main()
    {
        bool a = true;
        bool b = false;

        Console.WriteLine("a = {0},b = {1}", a, b);
        Console.WriteLine("aは{0}", a.GetType());
        Console.WriteLine("aは文字列にすると「{0}」", a.ToString());
        Console.WriteLine("bは文字列にすると「{0}」", b.ToString());
        
    }
}
