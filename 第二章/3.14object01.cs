
using System;

    class object01
{
    //public static void Main()
    //{
    //    object o;
    //    byte b = 50;
    //    int i = 10;
    //    long l = 55555;
    //    double d = 0.00254;

    //    o = b;  //byte型の値を代入
    //    Console.WriteLine(o);

    //    o = i;  //int型の値を代入
    //    Console.WriteLine(o);

    //    o = l;  //long型の値を代入
    //    Console.WriteLine(o);

    //    o = d;  //double型の値を代入
    //    Console.WriteLine(o);


    //}

    

}

//class object02
//{
//    public static void Main()
//    {
//        // ボックス化解除
//        object o;
//        int i, a = 100;

//        o = a;      //ボックス化
//        i = (int)o; //ボックス化解除
//        Console.WriteLine("i = {0}", o);
//    }
//}

    class object03      //実行時例外
{
    public static void Main()
    {
        long l = 1;
        object o;
        int i;

        o = l;
        i = (int)o;

        Console.WriteLine(i);
    }
}
