// var01.cs

using System;

//class cast01
//{
//    public static void Main()
//    {
//        long a = 2;
//        byte b;
//        b = (byte)a;

//        long c = 100;
//        sbyte d;
//        d = (sbyte)c;

//        Console.WriteLine(b);
//        Console.WriteLine(d);

//    }
//}

    class enum01
{
    enum MyMonth
    {
        Jan =1,Feb, Mar, Apr, May, Jun, Jul,Aug, Sep, Oct, Nov, Dec
    };
    //　ここに書くとMainメソッドで読み込めない？
    //string[] Month = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };


    public static void Main()
    {
        string[] Month = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //int [] MonthNum = new int[] {1,2,3,4,5,6,}

        string format = "{0}は{1,2}月";
        Console.WriteLine(format, Month[3], MyMonth.Apr);   //　キャストしないと
        Console.WriteLine(format, Month[3], (int)MyMonth.Apr);
        Console.WriteLine("-------------------------------------------");

        for (int i = 0;i< Month.Length; i++)
        {
            Console.WriteLine(format, Month[i], i+1);
        }
    }
}
