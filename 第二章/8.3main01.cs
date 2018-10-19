
using System;

//コマンドライン
    class main01
{
    public static int Main(string[] s)
    {
        int n;
        n = s.Length;
        Console.WriteLine("引数の個数は{0}個です", n);

        if (n != 0)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("引数{0}:{1}", i + 1, s[i]);
        }
        return 0;       //戻り値は常に0
    }
}
