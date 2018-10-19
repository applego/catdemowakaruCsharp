// type09.cs

using System;

class escape01
{
    public static void Main()
    {
        char n = '\n';
        string str1 = "今日は";
        string str2 = "よい天気です";

        Console.WriteLine(str1 + n + str2);

        string str3 = "今日は\nよい天気です";
        Console.WriteLine(str3);

    }
}
