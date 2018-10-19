// var01.cs

using System;

class var01
{
    public static void Main()
    {
        　//【var型】
        var mytext = "猫でもわかるC#プログラミング　第";
        var no = 2;
        //no = "aiueo";
        var myc = '版';

        Console.WriteLine(mytext + no + myc);
        Console.WriteLine("mytextの型は{0}で、noの型は{1}で、mycの型は{2}です", mytext.GetType(), no.GetType(), myc.GetType());

        //return 0;

        //　【dynamic型】
        //dynamic x = 10, y = "abc", z;
        //z = 1.25;

        //Console.WriteLine("x----{0}", x.GetType());
        //Console.WriteLine("y----{0}", y.GetType());
        //Console.WriteLine("z----{0}", z.GetType());


    }
}
