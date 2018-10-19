// text02.cs

using System;

class text02
{
    public static void Main()
    {
        int a = 10, b = 20;
        //Console.WriteLine(a + "+" + b + "=" + (a + b));
        Console.WriteLine(a + "+" + b + "=" + a + b);       //　()がないと文字列として認識される
    }

}