
using System;

//class string01
//{
//    public static void Main()
//    {
//        string str = "今日はよい天気です";
//        string mystr;
//        char c;

//        // Lengthプロパティで文字列の長さを調べる
//        Console.WriteLine("{0}は長さ{1}です", str, str.Length);

//        //文字列型変数cに文字列strの5番目の文字を代入
//        c = str[4];
//        Console.WriteLine("文字列strの5番目の文字は「{0}」です", c);

//        //文字列strをmystrにコピー
//        mystr = string.Copy(str);
//        Console.WriteLine(mystr);

//        //文字列の検索
//        int n = str.IndexOf('よ');
//        Console.WriteLine("文字列strに´よ´が出てくるのは{0}番目の文字", n + 1);

//        n = str.IndexOf("天気");
//        Console.WriteLine("文字列strに´天気´が出てくるのは{0}番目の文字", n + 1);


//    }
//}

    class isas01
{
    //public static void Main()
    //{
    //    object o;
    //    long l = 1;
    //    o = l;

    //    Console.WriteLine("oにlongをボックス化しました");
    //    Console.WriteLine("o is long---{0}", o is long);
    //    Console.WriteLine("o is int ---{0}", o is int);

    //    Console.WriteLine();
    //    Console.WriteLine("今度はoに文字列を代入しました");
    //    o = "abc";
    //    Console.WriteLine("o is string--{0}", o is string);
    //}
    public static void Main()
    {
        long l = 100;
        object o;
        string s;

        o = l;
        s = o as string;
        Console.WriteLine(o);
    }
}