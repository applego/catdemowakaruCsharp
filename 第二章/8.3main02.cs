
using System;
    class main02
{
    public static int Main(string[] args)
    {
        if (args.Length != 1)
        {           //引数の数が1個でない場合
            return -1;
        }
        else
        {
            if (!Char.IsDigit(args[0][0]))
            {           //引数の1文字目が数字でない場合
                return -2;
            }
        }
        return int.Parse(args[0]);
    }
}