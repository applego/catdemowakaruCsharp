// var01.cs

using System;

class scope01
{
    public static void Main()
    {
        int a = 10;
        Console.WriteLine("a = {0}", a);
        {
            int b = 5;
            Console.WriteLine("a = {0},b={1}", a, b);
            {
                int c = a;
                Console.WriteLine("a = {0},b = {1}, c = {2}", a , b, c);
            }
            //　ここではcは見えません
            Console.WriteLine("a = {0},b = {1}", a, b);
        }
        //　ここでは、b,cは見えません
        Console.WriteLine("a = {0}", a);
    }
}
