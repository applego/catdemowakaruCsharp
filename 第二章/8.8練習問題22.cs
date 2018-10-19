
using System;

class MyClass
{
    double[] point;
    string[] name;
    int nMax;

    public double this[string str]  //strがインデックスのインデクサ
    {
        get
        {               //インデックスstrが配列nameと同じだったらその点数を返す　一致しなければ-1.0を返す
            for(int i = 0; i < nMax; i++)
            {
                if (str == name[i])
                    return point[i];
            }
            return -1.0;
        }
        set
        {               //インデックスstrが配列nameと同じだったらvalueを配列pointに格納する　
            for (int i = 0; i< nMax; i++)
            {
                if(str == name[i])
                {
                    point[i] = value;
                    break;
                }

            }
        }
    }

    void setname()
    {
        for(int i = 0; i < nMax; i++)
        {
            Console.Write("生徒名[{0}] =", i);
            name[i] = Console.ReadLine();
        }
    }
    public MyClass(int n)
    {
        nMax = n;
        point = new double[n];
        name = new string[n];
        setname();
    }
}

class renshu82
{
    public static void Main()
    {
        Console.WriteLine("まずはじめに生徒数と、全員の名前入力が必要です");
        Console.Write("生徒数--");
        string strn = Console.ReadLine();

        MyClass mc = new MyClass(int.Parse(strn));

        string ans, strp;

        Console.WriteLine("X入力で終了");
        while (true)
        {
            Console.Write("点数を入力したい生徒名--");
            if ((ans = Console.ReadLine()) == "X")
                break;
            Console.Write("点数--");
            strp = Console.ReadLine();
            mc[ans] = double.Parse(strp);
        }
        Console.WriteLine();

        Console.WriteLine("X入力で終了");
        while (true)
        {
            Console.WriteLine("点数を知りたい生徒名--");
            ans = Console.ReadLine();
            if (ans == "X")
                break;
            Console.WriteLine("{0}の点数は{1}", ans, mc[ans]);
        }
    }
}