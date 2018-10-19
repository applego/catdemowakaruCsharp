
//using System;

//class myclass
//{
//    public int x;
//}

////class simpleclass
////{
////    public static void Main()
////    {
////        myclass mc = new myclass();     //オブジェクトを生成
////        mc.x = 10;                      //インスタンス変数に値を代入
////        Console.WriteLine("mc.x = {0}", mc.x);
////    }
////}

////    class simpleclass02
////{
////    public static void Main()
////    {
////        myclass a, b;
////        a = new myclass();  //オブジェクトを生成
////        //b = new myclass();  //オブジェクトをもう1つ生成

////        //a.x = 10;
////        //b.x = 100;

////        //Console.WriteLine("a.x = {0},b.x = {1}", a.x, b.x);
////        a.x = 10;
////        b = a;

////        Console.WriteLine("b.x = {0}", b.x);
////        b.x = 100;
////        Console.WriteLine("a.x = [0}", a.x);

////    }
////}

//    class simpleclass03
//{
//    public static void Main()
//    {
//        myclass a, b;
//        a = new myclass();
//        a.x = 10;
//        b = a;

//        Console.WriteLine("b.x = {0}", b.x);
//        b.x = 100;
//        Console.WriteLine("a.x = {0}", a.x);
//    }
//}

using System;

//class simpleclass04
//{
//    private int x;  //インスタンス変数

//    public static void Main()
//    {
//        simpleclass04 s;
//        s = new simpleclass04();
//        s.x = 10;
//        Console.WriteLine("s.x = " + s.x);
//    }
//}

//    class MyClass
//{
//    public int Add(int x,int y)
//    {
//        int z;
//        z = x + y;
//        return z;
//    }

//}

//class method01
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();
//        int sum;
//        sum = mc.Add(100, -123);

//        Console.WriteLine( "sum = {0}",sum);
//    }
//}

//    class BMI
//{
//    double blm;
//    public double Calc(double bl,double bw)
//    {
//        blm = bl / 100.0;
//        return bw / Math.Pow(blm, 2.0);
//    } 
//}

//    class bmiclass
//{
//    public static void Main()
//    {
//        string strBl, strBw;
//        double blcm, bwkg;

//        Console.Write("身長(㎝)--");
//        strBl = Console.ReadLine();
//        blcm = double.Parse(strBl);

//        Console.Write("体重(kg)--");
//        strBw = Console.ReadLine();
//        bwkg = double.Parse(strBw);

//        BMI bmi = new BMI();
//        double yourBmi = bmi.Calc(blcm, bwkg);

////        Console.WriteLine("BMI ={0:##.0}", yourBmi);
////    }
////}

//    class kakeibo
//{
//    private int total = 0;

//    public void nyukin(int en)
//    {
//        total += en;
//        Console.WriteLine("{0}円を入金しました", en);
//        return;
//    }

//    public void shishutu(int en)
//    {
//        if(total < en)
//        {
//            Console.WriteLine("{0}円も支出できません", en);
//            return;
//        }else
//        {
//            total -= en;
//            Console.WriteLine("{0}円支出しました", en);
//            return;
//        }
//    }

//    public void gettotal()
//    {
//        if(total == 0)
//        {
//            Console.WriteLine("残高はありません");
//            return;
//        }
//        else
//        {
//            Console.WriteLine("残高は{0}円です", total);
//            return;
//        }
//    }

//}

//class noreturnvalue
//{
//    public static void Main()
//    {
//        kakeibo k = new kakeibo();

//        k.gettotal();
//        k.nyukin(1000);
//        k.gettotal();
//        k.nyukin(2000);
//        k.gettotal();
//        k.shishutu(500);
//        k.gettotal();
//        k.shishutu(10000);
//        k.gettotal();
//    }
//}

//    class MyClass
//{
//    int x;

//    public void showx()
//    {
//        Console.WriteLine("x = " +x);
//    }
//    //コンストラクタ:クラスと同じ名前、復帰型なし

//    public MyClass()
//    {
//        x = 10;
//        Console.WriteLine("xに10を代入しました");
//    }
//}

//class construct01
//{
//    public static void Main()
//    {
//        // newしたときにコンストラクタが呼び出される
//        MyClass mc = new MyClass();
//        mc.showx();
//    }
//}

//    class Myclass
//{
//    private string name;
//    private int age;
//    private string address;

//    public void show()
//    {
//        string toshi;
//        if (age == -1)
//            toshi = "不明";
//        else
//            toshi = age.ToString();

//        Console.WriteLine("氏名:{0}　住所:{1}　年齢:{2}", name, address, toshi);
//    }

//    public Myclass(string str)
//    {
//        name = str;
//        age = -1;
//        address = "不定";
//    }

//    public Myclass(int n)
//    {
//        name = "不明";
//        age = n;
//        address = "不定";
//    }
//    public Myclass(string str1,string str2,int x)
//    {
//        name = str1;
//        age = x;
//        address = str2;
//    }
//}

////class construct01
////{
////    public static void Main()
////    {
////        Myclass mc1 = new Myclass(18);
////        Myclass mc2 = new Myclass("高木");
////        Myclass mc3 = new Myclass("坂巻", "品川", 25);

////        mc1.show();
////        mc2.show();
////        mc3.show();
////    }


////}

//    class DestructTest
//{
//    int x;

//    //デストラクタ
//    ~DestructTest()
//    {
//        Console.WriteLine("デストラクタが呼ばれました");
//        Console.WriteLine("xは{0}です", x);
//    }

//    //引数付きコンストラクタ
//    public DestructTest(int n)
////    {
////        Console.WriteLine("コンストラクタが呼び出されました");
////        x = n;
////        Console.WriteLine("xに{0}を代入しました", n);
////    }
////}

////class destruct
////{
////    public static void Main()
////    {
////        DestructTest dt1 = new DestructTest(1);
////        Console.WriteLine("dt1生成");
////        DestructTest dt2 = new DestructTest(2);
////        Console.WriteLine("dt2生成");
////        DestructTest dt3 = new DestructTest(3);
////        Console.WriteLine("dt3生成");

////    }
////}

//    class MyClass
//{
//    public MyClass m1, m2;

//    public void Test()
//    {
//        m2 = this;
//    }
//    public MyClass()
//    {
//        m1 = this;
//    }
//}

//class this01
//{
//    public static void Main()
//    {
//        MyClass mc = new MyClass();

//        mc.Test();

//        if (mc.m1 == mc.m2)
//            Console.WriteLine("m1とm2は同じです");
//        if(mc == mc.m1)
//            Console.WriteLine("mcとm1は同じです");
//        if (mc == mc.m2)
//            Console.WriteLine("mcとm2は同じです");

//    }
////}

//using System.Collections;       //ArrayList使用するため

//    class arraylist01
//{
//    public static void Main()
//    {
//        bool bEnd = false;
//        string strData;
//        double sum = 0.0;
//        ArrayList al = new ArrayList();

//        while (true)
//        {
//            Console.Write("データ（数値以外入力で終了）--");
//            strData = Console.ReadLine();
//            if (!Char.IsDigit(strData[0]) && strData[0] != '-')
//                bEnd = true;
//            else
//                al.Add(double.Parse(strData));
//            if (bEnd)
//                break;
//        }

//        for(int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine("Data[{0}] = {1}", i + 1, al[i]);
//            sum += (double)al[i];
//        }

//        int count = al.Count;
//        double avr = sum / count;
//        Console.WriteLine("データ個数 = {0}", count);
//        Console.WriteLine("平均値 = {0}", avr);
//    }
//} 

//    class MyClass
//{
//    public int baseball;
//    public int football;
//    public int volleyball;

//    public int show(string str)
//    {
//        if (str == "baseball")
//            return 18;
//        if (str == "football")
//            return 22;
//        if (str == "volleyball")
//            return 12;
//        else
//            return 0;
//    }
//}

//    class renshu71
//    {
//        public static void Main()
//    {
//        MyClass mc = new MyClass();
//        mc.baseball = 9;
//        mc.football = 11;
//        mc.volleyball = 6;

//        Console.WriteLine("mc.baseball = {0}", mc.baseball);
//        Console.WriteLine("mc.football = {0}", mc.football);
//        Console.WriteLine("mc.volleyball = {0}", mc.volleyball);

//        //mc.show("baseball");
//        //mc.show("football");
//        //mc.show("volleyball");

//        Console.WriteLine("mc.baseball = {0}", mc.show("baseball"));
//        Console.WriteLine("mc.football = {0}", mc.show("football"));
//        Console.WriteLine("mc.volleyball = {0}", mc.show("volleyball"));

//    }
//}

    class addclass
{
    public int Add(int a,int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

    class renshu72
{
    public static void Main()
    {
        addclass ac = new addclass();

        Console.WriteLine("{0} + {1} = {2}", 4, 7, ac.Add(4, 7));
        Console.WriteLine("{0} + {1} = {2}", 7.2, 8.5, ac.Add(7.2, 8.5));

    }
} 
