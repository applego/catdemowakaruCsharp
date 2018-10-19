// type02.cs

using System;

class type02
{
    public static void Main()
    {
        Console.WriteLine("整数を入力してください---");
        //int x = int.Parse(Console.ReadLine());
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("今の数字を2倍すると{0}ですね。", x * 2);

        Console.WriteLine("あなたの年齢を入力してください---");
        //ushort age = ushort.Parse(Console.ReadLine());
        ushort age = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("あと{0}年で100歳ですね", 100 - age);
    }
}