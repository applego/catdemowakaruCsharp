
//exception01.cs

using System;

//class MyClass
//{
//    public static void Main()
//    {
//        double a = 0.0, b = 0.0;

//        Console.Write("割られる数--");
//        string strA = Console.ReadLine();
//        try
//        {
//            a = double.Parse(strA);
//        }
//        catch
//        {
//            Console.WriteLine("不適切な入力です");
//        }

//        Console.Write("割る数--");
//        string strB = Console.ReadLine();
//        try
//        {
//            b = double.Parse(strB);
//        }
//        catch
//        {
//            Console.WriteLine("不適切な入力です");
//        }
//        Console.WriteLine("{0} ÷ {1} = {2}", a, b, a / b);
//    }
//}

//class exception03
//{
//    public static void Main()
//    {
//        int[] arr = new int[5];

//        try
//        {
//            arr[5] = 10;        //わざと配列の境界を越える
//        }
//        catch(IndexOutOfRangeException io)
//        {
//            Console.WriteLine(io);
//            Console.WriteLine("[io]--------");

//            Console.WriteLine(io.Source);
//            Console.WriteLine("[io.Source]-------");

//            Console.WriteLine(io.Message);
//            Console.WriteLine("[io.Message]--------");

//            Console.WriteLine(io.ToString());
//            Console.WriteLine("[io.ToString()]--------");

//            Console.WriteLine(io.TargetSite);
//            Console.WriteLine("[io.TargetSite]--------");

//        }
//    }
//}

//    class exception04
//{
//    public static void Main()
//    {
//        int x = 10, y = 0;

//        try
//        {
//            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
//        }
//        catch(IndexOutOfRangeException io)
//        {
//            Console.WriteLine(io.Message);
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("0で割っちゃだめだよ");
//        }
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

    //exception05.cs

//    class exception05
//{
//    public static void Main()
//    {
//        string strWarusu;
//        int x;
//        bool bEnd = false;

//        while (true)
//        {
//            Console.Write("割る数--");
//            strWarusu = Console.ReadLine();

//            try
//            {
//                x = int.Parse(strWarusu);
//                Console.WriteLine("10 / {0} = {1}", x, 10 / x);
//            }
//            catch(DivideByZeroException d)
//            {
//                Console.WriteLine(d.Message);
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                Console.Write("続けますか（y/n）---");
//                if (Console.ReadLine()[0] == 'n')
//                    bEnd = true;
//            }
//            if (bEnd)
//                break;
//        }
//    }
//}

//    class MyClassA
//{
//    public void Calc()
//    {
//        int x = 10, y = 0;
//        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//        try
//        {
//            Console.WriteLine("{0},{1}", arr[x], x / y);
//        }
//        catch(IndexOutOfRangeException i)
//        {
//            Console.WriteLine(i.Message);
//            DivideByZeroException d = new DivideByZeroException();
//            Console.WriteLine("外側にthrowします");
//            throw d;
//        }
//    }
//}
//class MyClassB
//{
//    public void Calc()
//    {
//        MyClassA a = new MyClassA();
//        try { a.Calc(); }
//        catch(DivideByZeroException d)
//        {
//            Console.WriteLine("外側のcatch節です");
//            Console.WriteLine(d.Message);
//        }
//    }
//}

//class exception06
//{
//    public static void Main()
//    {
//        MyClassB b = new MyClassB();
//        b.Calc();
//    }
//}

    class MyClass
{
    int x = 5, y = 0;

    public void Calc()
    {
        try
        {
            Console.WriteLine("{0}", x / y);
        }
        catch(DivideByZeroException d)
        {
            Console.WriteLine(d.Message);
            throw;
        }
    }
}

class MyClassB
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        try
        {
            mc.Calc();
        }
        catch(DivideByZeroException d)
        {
            Console.WriteLine(d.TargetSite);
        }
    }
}