using System;

//class l年間は何秒
//{
//    public static void Main()
//    {
//        Console.WriteLine();
//        Console.WriteLine("何年の秒数？");
//        int thisyear = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("{0}年は何日ある？",thisyear);
//        int Howmanydays = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("{0}年は{1}秒です",thisyear, Howmanydays * 24 * 60 * 60);


//    }
//}

    class 円の面積
{
    public static void Main()
    {
        Console.Write("半径(cm)---");
        Console.WriteLine("円の面積---{0:#.##}㎝2", Math.Pow(double.Parse(Console.ReadLine()), 2.0) * Math.PI);
    }
}