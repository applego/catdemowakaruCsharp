
using System;

//class Fact
//{
//    public long CalcFact(int n)
//    {
//        long fact;

//        if (n == 0)
//        {
//            fact = 1;
//        }
//        else
//        {
//            fact = n * CalcFact(n - 1);     //再起呼び出し
//        }
//        return fact;
//    }
//}

//class fact01
//{
//    public static void Main()
//    {
//        Fact f = new Fact();
//        for (int i = 0; i <= 1000; i++)
//            Console.WriteLine("{0}! = {1}", i, f.CalcFact(i));
//    }
//}

//    class fibo
//{

//    public long CalcFibo(int n)
//    {
//        long fb;
//        if (n == 1 || n == 2)
//        { 
//            fb = 1;
//        }
//        else
//        {
//            fb = CalcFibo(n - 1) + CalcFibo(n - 2);
//        }
//        return fb;
//    }
//}

//class fibonacci
////{
////    public static void Main()
////    {
////        fibo f = new fibo();

////        for(int i = 1; i <= 30; i++)
////        {
////            string format = "f({2})%f({0}) = {1}";

////            Console.WriteLine(format, i, f.CalcFibo(2*i)%f.CalcFibo(i),f.CalcFibo(2*i));
////        }

////    }
////}

//    //　間違ったプログラム！

//    class myclass
//{
//    private int temp;
//    private string temp2;

//    public void swap(int x, int y)
//    {
//        temp = x;   //この3行で、
//        x = y;      //引数xとyの値を
//        y = temp;   //入れ替えています
//    }
//    public void swap(string str1,string str2)
//    {
//        temp2 = str1;
//        str1 = str2;
//        str2 = temp2;
//        Console.WriteLine("swap:str1 = {0},str2 = {1}", str1, str2);
//    }

//}

//    class swap01
//{
//    public static void Main()
//    {
//        myclass s = new myclass();
//        int x = 10, y = 20;
//        s.swap(x, y);   //xとyを入れ替えようとしていますが
//        Console.WriteLine("x = {0},y = {1}", x, y);

//        string str1 = "犬", str2 = "猫";
//        s.swap(str1, str2);
//        Console.WriteLine("Main:str1 = {0},str2 = {1}", str1, str2);
////    }
////}

//    class change
//{
//    public void modify(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n; i++)
//            array[i] *= 2;  //オブジェクトそのものを変更
//    }
//}

//class changearray01
//{
//    public static void Main()
//    {
//        change c = new change();

//        int[] myarray = new int[3] { 1, 2, 3 };
//        Console.WriteLine("---modifyメソッド実行前----");
//        int i = 0;
//        foreach(int x in myarray)
//        {
//            Console.WriteLine("myarray[{0}] = {1}", i, x);
//            i++;
//        }

//        c.modify(myarray);
//        Console.WriteLine("---modifyメソッド実行後----");
//        i = 0;
//        foreach(int x in myarray)
//        {
//            Console.WriteLine("myarray[{0}] = {1}", i, x);
////            i++;
////        }

////    }
////}

//class myclass
//{
//    private int temp;
//    private string temp2;

//    public void swap(ref int x,ref  int y)
//    {
//        temp = x;   //この3行で、
//        x = y;      //引数xとyの値を
//        y = temp;   //入れ替えています
//    }
//    public void swap(ref string str1,ref string str2)
//    {
//        temp2 = str1;
//        str1 = str2;
//        str2 = temp2;
//        Console.WriteLine("swap:str1 = {0},str2 = {1}", str1, str2);
//    }

//}

//class swap01
//{
//    public static void Main()
//    {
//        myclass s = new myclass();
//        int x = 10, y = 20;
//        s.swap(ref x,ref y);   //xとyを入れ替えようとしていますが
////        Console.WriteLine("x = {0},y = {1}", x, y);

////        string str1 = "犬", str2 = "猫";
////        s.swap(ref str1,ref str2);
////        Console.WriteLine("Main:str1 = {0},str2 = {1}", str1, str2);
////    }
////}

//    class MyClass
//{
//    public void Square(double x, double y, out double s)
//    {
//        s = x * y;
//    }
//}

//class outkeyword01
//{
//    public static void Main()
//    {
//        double a = 125.3, b = 16.25, c;
//        MyClass mc = new MyClass();

//        //cには値を代入していません
//        mc.Square(a, b,out c);

//        Console.WriteLine("縦{0}m,横{1}mの長方形の面積は{2}平方メートル", a, b, c);
//    }
////}

//    class manynethods
//{
//    public int Method(int x)
//    {
//        Console.WriteLine("第1のバージョンが呼ばれました");
//        return x + 10;
//    }
//    public double Method(double x)
//    {
//        Console.WriteLine("第2のバージョンが呼ばれました");
//        return x * 2;
//    }
//    public string Method(string x)
//    {
//        Console.WriteLine("第3のバージョンが呼ばれました");
//        return x += "です";
//    }
//    public int Method(int x, int y)
//    {
//        Console.WriteLine("第4のバージョンが呼ばれました");
//        return x + y;
//    }

//}

//class overload01
//{
//    public static void Main()
//    {
//        manynethods m = new manynethods();
//        Console.WriteLine("その戻り値は「{0}」です", m.Method(10));
//        Console.WriteLine("その戻り値は「{0}」です", m.Method(10,20));
//        Console.WriteLine("その戻り値は「{0}」です", m.Method("おおおおおおおおおおおおおおおおおお"));
//        Console.WriteLine("その戻り値は「{0}」です", m.Method(9.999999999999));

//    }
//}

// コマンドライン
//    class main01
//{
//    public static int Main(string[] s)
//    {
//        int n;
//        n = s.Length;
//        Console.WriteLine("引数の個数は{0}個です", n);

//        if(n != 0)
//        {
//            for (int i = 0; i < n; i++)
//                Console.WriteLine("引数{0}:{1}", i + 1, s[i]);
//        }
//        return 0;       //戻り値は常に0
////    }
////}


//    class main02
//{
//    public static int Main(string[] args)
//    {
//        if (args.Length != 1)
//        {           //引数の数が1個でない場合
//            return -1;
//        }
//        else
//        {
//            if (!Char.IsDigit(args[0][0]))
//            {           //引数の1文字目が数字でない場合
//                return -2;
//            }
//        }
//        return int.Parse(args[0]);
//    }
//}

//    //引数が可変個
//    class MyClass
//{
//    public void show(params string[] animal)
//    {
//        if (animal.Length == 0)
//            return;
//        for (int i = 0; i < animal.Length; i++)
//            Console.WriteLine("{0}さんがいます", animal[i]);
//    }

//}

//class params01
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();
//        mc.show();  //引数0個
//        mc.show("きりん", "ぞう", "かば"); //引数3個
//    }
//}

//    class MyClass
//{
//    public static int x;

//    public static void showx()
//    {
//        Console.WriteLine("x = {0}", x);
//    }
//}

//class static01
//{
//    public static void Main()
//    {
//        MyClass.x = 10;
//        MyClass.showx();
//    }
//}

//    static class MyClass    //静的クラス
//{
//    public static int x;

//    public static void showX()
//    {
//        Console.WriteLine("x = {0}", x);
//    }
//}

//class static02
//{
//    public static void Main()
//    {
//        MyClass.x = 10;
//        MyClass.showX();
//    }
//}


//    class Cat
//{
//    static int NoOfTail;
//    string Name;

//    public void SetName(string strName)
//    {
//        Name = strName;
//    }

//    public void ShowCat()
//    {
//        if(Name == null)
//        {
//            Console.WriteLine("名前が設定されていません");
//            return;
//        }
//        Console.WriteLine("猫の名前は{0}で尾の数は{1}です", Name, NoOfTail);
//    }
//    public static void SetCatTail(int no)
//    {
//        //ここではインスタンス変数にアクセスできない
//        //Name= "マイケル";
//        NoOfTail = no;  //静的メンバにはアクセス可能
//    }
//}

//class static03
//{
//    public static void Main()
//    {
//        Cat.SetCatTail(1);

//        Cat mycat = new Cat();
//        Cat yourcat = new Cat();

//        mycat.ShowCat();
//        yourcat.ShowCat();

//        mycat.SetName("マイケル");
//        yourcat.SetName("パトリシア");

//        mycat.ShowCat();
//        yourcat.ShowCat();

//    }
//}

//    class MyClass
//{
//    double bl;
//    public double blprop
//    {
//        get
//        {
//            return bl;
//        }
//        set
//        {
//            bl = value;
//        }
//    }
//}

//class prop01
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();
//        mc.blprop = 165.2;
//        Console.WriteLine("bl = {0}", mc.blprop);
//    }
//}

//    class BMI
//{
//    double bw, bl;

//    public double blprop
//    {   //身長を表すプロパティ
//        get
//        {
//            return bl;
//        }
//        set
//        {
//            if(value <= 0)
//            {
//                Console.WriteLine("身長に0または負の値は設定できません");
//                return;
//            }
//            bl = value;
//        }
//    }

//    public double bwprop
//    {
//        get
//        {
//            return bw;
//        }
//        set
//        {
//            if(bw <= 0)
//            {
//                Console.WriteLine("体重に0または負の値は設定できません");
//                return;
//            }
//            bw = value;
//        }
//    }

//    public double CalcBMI()     //BMIを計算して返すメソッド
//    {
//        if(bl == 0.0 || bw == 0.0)
//        {
//            Console.WriteLine("データがセットされていません");
//            return 0.0;
//        }
//        return bw / Math.Pow(bl, 2.0);
//    }
//}


//    class prop02
//    {
//        public static void Main()
//    {
//        BMI mybmi = new BMI();
//        double bl, bw;

//        do
//        {
//            Console.Write("身長(m)---");
//            string strBl = Console.ReadLine();
//            bl = double.Parse(strBl);
//            mybmi.blprop = bl;
//        } while (bl <= 0.0);

//        do
//        {
//            Console.Write("体重(kg)---");
//            string strBw = Console.ReadLine();
//            bw = double.Parse(strBw);
//            mybmi.bwprop = bw;
//        } while (bw <= 0.0);

//        Console.WriteLine("bi = {0},bw = {1}", mybmi.blprop, mybmi.bwprop);

//        Console.WriteLine("BMI = {0:#.#}", mybmi.CalcBMI());

//        }
//}


//prop03

//    class Test
//{
//    static int x;

//    public static int myprop
//    {
//        get
//        {
//            return x;           //静的メンバxを返す
//        }
//        set
//        {
//            x = value;          //静的メンバxに代入
//        }
//    }
//}

//    class prop03
//{
//    public static void Main()
//    {
//        Test.myprop = 10;
//        Console.WriteLine("Test.myprop = {0}", Test.myprop);
//    }
//}

//    //indexer01.cs
//    class MyClass
//{
//    string[] name = new string[5];

//    public string this[int i]
//    {
//        get { return name[i]; }
//        set { name[i] = value; }
//    }
//}

//class indexer01
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();

//        mc[0] = "一郎";
//        mc[1] = "次郎";
//        mc[2] = "三郎";
//        mc[3] = "四郎";
//        mc[4] = "五郎";

//        for (int i = 0; i < 5; i++)
//            Console.WriteLine(mc[i]);

//    }
//}

//    class MyIndexer
//{
//    int[] array;
//    int nMax;           //配列の要素数

//    public int this[int n]
//    {
//        get
//        {
//            if (n < nMax)   //インデックスnをチェック
//                return array[n];
//            else
//                return 0;
//        }
//        set
//        {
//            if (n < nMax)    //インデックスnをチェック
//                array[n] = value;
//        }
//    }
//    public MyIndexer(int i)
//    {
//        array = new int[i];     //要素数iの配列を生成
//        nMax = i;               //配列の要素数を設定
//    }
//}

//    class indexer02
//{
//    public static void Main()
//    {
//        MyIndexer mi = new MyIndexer(20);

//        for (int i = 0; i < 20; i++)
//            mi[i] = i * i;

//        for (int i = 0; i < 20; i++)
//            Console.WriteLine("{0} * {0} = {1}", i, mi[i]);

//        //わざと配列の範囲を超える
//        mi[30] = 30;
//        Console.WriteLine("mi[30] = {0}", mi[30]);
//    }
//} 

//    class MyIndexer
//{
//    string[] mon = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

//    public int this[string MonthName]
//    { get
//        {
//            for(int i = 0; i < 12; i++)
//            {
//                if (MonthName == mon[i])
//                    return i + 1;
//            }
//            return 0;
//        }
//    }
//}

//    class indexer03
//{
//    public static void Main()
//    {
//        MyIndexer mi = new MyIndexer();
//        Console.WriteLine("Mayは{0}番目の月です", mi["May"]);
//        Console.WriteLine("Decは{0}番目の月です", mi["Dec"]);
//        Console.WriteLine("xは{0}番目の月です", mi["x"]);
//    }
////}

//    class Myindexer01
//{
//    string[] TennisRank = { "Murray", "Djokovic", "Wawrinka", "Nadal", "Federer", "Raonic", "Thiem", "Clic", "Nishikori", "Zverev" };

//    public int this[string TennisPlayer]
//    {
//        get
//        {
//            for(int i = 0; i < TennisRank.Length; i++)
//            {
//                if (TennisPlayer == TennisRank[i])
//                    return i + 1;
//            }
//            return 0;
//        }
//    }
//} 

//class indexer032
//{
//    public static void Main()
//    {
//        Myindexer01 mc1 = new Myindexer01();
//        Console.WriteLine("Nishikoriのランキングは{0}位です", mc1["Nishikori"]);
//        Console.WriteLine("Federerのランキングは{0}位です", mc1["Federer"]);
//        Console.WriteLine("Zverevのランキングは{0}位です", mc1["Zverev"]);
//        Console.WriteLine("kjlkjのランキングは{0}位です", mc1["kjlkj"]);

//    }
//}

//    class MyClass
//{
//    string[,] name;

//    public string this[int i,int j]
//    {
//        get
//        {
//            return name[i, j];
//        }
//    }

//    public MyClass()
//    {
//        name = new string[,] { { "田中", "佐藤", "吉田", "加藤", "粂井" }, { "工藤", "竹中", "斎藤", "太田", "杉本" } };
//    }
//}

//class indexer04
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();

//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 5; j++)
//                Console.WriteLine("{0}組{1}番--{2}", i + 1, j + 1, mc[i, j]);

//    }
//}

//class MyOverLoad
//{
//    int[] a = new int[3] { 1, 2, 3 };
//    int[,] b = new int[2, 2] { { 100, 200 }, { 300, 400 } };

//    //インデックスが1次元のインデクサ
//    public int this[int i]
//    {
//        get
//        {
//            return a[i];
//        }
//    }

//    //インデックスが2次元のインデクサ
//    public int this[int i,int j]
//    {
//        get
//        {
//            return b[i, j];
//        }
//    }
//}

//class indexer05
//{
//    public static void Main()
//    {
//        MyOverLoad mo = new MyOverLoad();

//        for (int i = 0; i < 3; i++)
//            Console.WriteLine("mo[{0}] = {1}", i, mo[i]);

//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 2; j++)
//                Console.WriteLine("mo[{0},{1}] = {2}", i, j, mo[i, j]);
//    }
//}

//　練習問題8章

//class MyClass
//{
//    double a;

//    public double myprop
//    {
//        get
//        {
//            return a;
//        }
//        set
//        {
//            if (value <= 0)
//            {
//                Console.WriteLine("正の数しか格納できません");
//                //return;
//            }
//            else
//            {
//                a = value;

//            }
//        }
//    }
//}

//class renshu81
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();

//        for(double d = 10; d >= -10; d -= 0.5)
//        {
//            Console.WriteLine("mc[{0}] = {1}", d, mc.myprop = d);
//        }

//    }
//}

using System.Collections;
class MyIndexer
{
    int point,nName;
    //string[] Name = { "坂本", "安達", "京田", "倉本", "北条", "茂木", "大引", "中島", "源田", "田中", "中村", "今宮" };
   
    public int this[string indexName]
    {
        get
        {
            return point;
        }
        set
        {
            point = value;
        }
    }

    public MyIndexer(int i)
    {
        ;
    }
    
}