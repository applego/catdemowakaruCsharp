// 3.1　変数に初期値を入れないとどうなるのか

using System;

class shoki
{
    public static void Main()
    {
        int a;
        double b;
        float c;
        bool d;
        uint e;
        const int f = 3;
        byte g;
        sbyte h;
        short i;
        decimal j;
        char あ;


        Console.WriteLine(a);　//未割り当てのローカル変数が使用されました
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(あ);


    }
}