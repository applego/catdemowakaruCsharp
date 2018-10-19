
using System;

//inheritance継承　はクラスを引き継ぐこと　元のクラスを基本クラス、新しく作成されたクラスを派生クラスという

//inherihance01.cs

//基本クラス
//    class MyBase
//{
//    public int a = 10;
//    public void BaseMethod()
//    {
//        Console.WriteLine("ここは基本クラスです");
//    }
//}

////派生クラス
//class MyDerived: MyBase
//{
//    public int b = 20;
//    public void DerivedMethod()
//    {
//        Console.WriteLine("ここは派生クラスです");
//    }
//}

//class inheritance01
//{
//    public static void Main()
//    {
//        MyDerived md = new MyDerived();     //派生クラスのインスタンス
//        md.BaseMethod();
//        md.DerivedMethod();
//        Console.WriteLine("md.a ={0}", md.a);
//        Console.WriteLine("md.b = {0}", md.b);

//        MyBase mb = new MyBase();           //基本クラスのインスタンス
//        mb.BaseMethod();
////        Console.WriteLine("mb.a = {0}", mb.a);
////    }
////}

//    class Base
//{
//    protected int x = 20;
//}

//class Derived : Base
//{
//    int y = 10;
//    public void showYX()
//    {
//        //このクラスからはBaseクラスのxが見える
//        Console.WriteLine("x = {0}, y = {1}", x, y);
//    }
//}

//class inheritance02
//{
//    public static void Main()
//    {
//        Derived md = new Derived();
//        //Console.WriteLine(m);

//        md.showYX();
//    }
//}

//    class Base
//{
//    public int x = 10;
//    public void BaseMethod()
//    {
//        Console.WriteLine("Baseクラスです");
//    }
//}

//class Derived : Base
//{
//    new public int x = 20;  //基本クラスのメンバと同名
//    new public void BaseMethod()    //基本クラスのメソッドと同名
//    {
//        Console.WriteLine("Derivedクラスです");
//    }
//    public void Show()
//    {
//        Console.WriteLine("base.x = {0}, x = {1}", base.x, x);
//    }
//}

//class inheritance03
//{
//    public static void Main()
//    {
//        Derived d = new Derived();
//        //Console.WriteLine("x = {0}", d.x);
//        //d.BaseMethod();
//        d.Show();
//////    }
////}

//    class MyBase
//{
//    public virtual void Method()
//    {
//        Console.WriteLine("MyBase");
//    }
//}

//class Derived1 : MyBase
//{
//    public override void Method()
//    {
//        Console.WriteLine("Derived1");
//    }
//}

//class Derived2 : MyBase
//{
//    public override void Method()
//    {
//        Console.WriteLine("Derived2");
//    }
//}

//class override01
//{
//    public static void Main()
//    {
//        Derived1 d1 = new Derived1();
//        Derived2 d2 = new Derived2();

//        d1.Method();
//        d2.Method();
//    }
//}

//    class Mammal
//{
//    protected const int LegNo = 4;
//    protected string Koe;

//    public virtual string Nakigoe() //仮想メソッド
//    {
//        Koe = "...";
//        return Koe;
//    }
//    public int leg()
//    {
//        return LegNo;
//    }
//}

//class Cat : Mammal
//{
//    public override string Nakigoe()    //オーバーライドメソッド
//    {
//        Koe = "にゃおにゃお";
//        return Koe;
//    }
//}

//class Dog : Mammal
//{
//    public override string Nakigoe()
//    {
//        Koe = "わんわん";
//        return Koe;
//    }
//}

//class override02
//{
//    public static void Main()
//    {
//        Mammal m;
//        Cat cat = new Cat();
//        Dog dog = new Dog();

//        m = cat;
//        Console.WriteLine("ねこの脚は{0}で鳴き声は「{1}」です", m.leg(), m.Nakigoe());

//        m = dog;
//        Console.WriteLine("いぬの脚は{0}で鳴き声は「{1}」です", m.leg(), m.Nakigoe());

//    }
////}

//class Mammal
//{
//    protected const int LegNo = 4;

//    public virtual string Nakigoe
//    {
//        get
//        {
//            return "...";
//        }
//    }

//    public int Leg()
//    {
//        return LegNo;
//    }
//}

//class Cat : Mammal
//{
//    public override string Nakigoe
//    {
//        get
//        {
//            return "にゃーにゃー";
//        }
////    }
////}

////class Dog: Mammal
////{
////    public override string Nakigoe 
////    {
////        get
////        {
////            return "わんわんわん";
////        }
////    }
////}

////class override03
////{
////    public static void Main()
////    {
////        Mammal m;
////        Cat cat = new Cat();
////        Dog dog = new Dog();

////        m = cat;
////        Console.WriteLine("猫の脚の数は{0}本で鳴き声は{1}です", m.Leg(), m.Nakigoe);

////        m = dog;
////        Console.WriteLine("犬の脚の数は{0}本で鳴き声は{1}です", m.Leg(), m.Nakigoe);

////    }
////}

//class Mammal
//{
//    protected const int LegNo = 4;

//    public virtual string Nakigoe
//    {
//        get
//        {
//            return "...";
//        }
//    }

//    public int Leg()
//    {
//        return LegNo;
//    }
//}

//class Cat: Mammal
//{
//    public override string Nakigoe
//    {
//        get
//        {
//            return "にゃーにゃー";
//        }
//    }
//}

//class Dog : Mammal
//{
//    public override string Nakigoe
//    {
//        get
//        {
//            return "わんわんわん";
//        }
//    }
//}

//class override03
//{
//    public static void Main()
//    {
//        Mammal m;
//        Cat cat = new Cat();
//        Dog dog = new Dog();

//        m = cat;
//        Console.WriteLine("猫の脚の数は{0}で鳴き声は{1}です", m.Leg(), m.Nakigoe);

//        m = dog;
//        Console.WriteLine("犬の脚の数は{0}で鳴き声は{1}です", m.Leg(), m.Nakigoe);
//    }
//}

    //インデクサのオーバーライド

//class Mammal
//{
//    protected const int LegNo = 4;
//    protected string Tail, Gei, Food, Koe;

//    public virtual string this[string index]
//    {
//        get
//        {
//            return "...";
//        }
//    }
//    public int Leg()
//    {
//        return LegNo;
//    }
//}

//class Cat : Mammal
//{
//    public override string this[string index]
//    {
//        get
//        {
//            switch (index)
//            {
//                case "尾":
//                    Tail = "1本";
//                    return Tail;
//                case "芸":
//                    Gei = "こたつで丸く";
//                    return Gei;
//                case "食べ物":
//                    Food = "鰹節";
//                    return Food;
//                case "鳴き声":
//                    Koe = "にゃーにゃー";
//                    return Koe;

//                default:
//                    return "";
//            }
//        }
//    }
//}
//class Dog : Mammal
//{
//    public override string this[string index]
//    {
//        get
//        {
//            switch (index)
//            {
//                case "尾":
//                    Tail = "1本";
//                    return Tail;
//                case "芸":
//                    Gei = "庭駆け回る";
//                    return Gei;
//                case "食べ物":
//                    Food = "骨";
//                    return Food;
//                case "鳴き声":
//                    Koe = "わんわん";
//                    return Koe;

//                default:
//                    return "";
//            }
//        }
//    }
//}

//class override04
//{
//    public static void Main()
//    {
//        Mammal m;

//        Cat cat = new Cat();
//        Dog dog = new Dog();

//        m = cat;
//        Console.WriteLine("猫の脚は{0}本　尾は{1}　芸は{2}　食べ物は{3}", m.Leg(), m["尾"], m["芸"], m["食べ物"]);

//        m = dog;
//        Console.WriteLine("犬の脚は{0}本　尾は{1}　芸は{2}　食べ物は{3}", m.Leg(), m["尾"], m["芸"], m["食べ物"]);

//    }
//}

//class MyBase
//{
//    protected int x = 10;
//    public virtual void show()
//    {
//        Console.WriteLine("x = {0}", x);
//    }
//}

//class Derived1: MyBase
//{
//    protected int y = 20;
//}

//class Derived2 : Derived1
//{
//    int z = 30;
//    public override void show()
//    {
//        Console.WriteLine("z = {0}", z);
//    }
//}

//class inheritance05
//{
//    public static void Main()
//    {
//        MyBase mb;
//        Derived1 d1 = new Derived1();
//        Derived2 d2 = new Derived2();

//        mb = d1;
//        mb.show();

//        mb = d2;
//        mb.show();
//    }
//}

//クラスの継承とコンストラクタ
//class MyBase
//{
//    protected int x;

//    public MyBase()
//    {
//        Console.WriteLine("ここはMyBase");
//        x = 10;
//    }
//}

//class Derived1: MyBase
//{
//    public Derived1()
//    {
//        Console.WriteLine("ここはDerived1");
//            x = 20;
//    }
//}

//class Derived2 : Derived1
//{
//    public Derived2()
//    {
//        Console.WriteLine("ここはDerived2");
//        x = 30;
//    }

//    public void show()
//    {
//        Console.WriteLine("x = {0}", x);
//    }
//}

//class inheritance06
//{
//    public static void Main()
//    {
//        Derived2 d2 = new Derived2();
//        d2.show();
//    }
//}

//    class MyBase
//{
//    protected double d;
//    public MyBase(double a,double b,double c)
//    {
//        d = Math.Pow(b, 2.0) - 4 * a * c;
//    }
//}

//class MyJudge : MyBase
//{
//    public bool bJudge;

//    public MyJudge(double p,double q,double r)
//    :base(p,q,r)    //MyBaseクラスのコンストラクタに引数を渡す
//    {
//        Console.WriteLine("判別式 = {0}", d);
//        if (d < 0.0)
//            bJudge = false;
//        else
//            bJudge = true;
//    }
//}

//class inharitance07
//{
//    public static void Main()
//    {
//        MyJudge mj = new MyJudge(1,2,3);
//        Console.WriteLine(mj.bJudge);

//        MyJudge mk = new MyJudge(1, 4, 0);
//        Console.WriteLine(mk.bJudge);

//    }
//}
        
    //1. 2つのintがtの引数をとりｍこの引数の和を返す仮想メソッド（calc）を持つクラスA1を作ってください。クラスA1からクラスA2を派生させ、仮想メソッドcalcをオーバーライドしてください。
    //このオーバーライドしたメソッドは、2つの引数の差を返すようにします。クラスA2のインスタンスを作成し、calcメソッドを呼び出して、引数の差が返されることを確認してください。
    //次に、A1型変数を宣言して、A2への参照をこの変数に代入します。そして、calcメソッドを呼び出します。このとき、返されるのは引数の和と差のどちらでしょうか。
    //2. 前問で、メソッドのオーバーライドではなく、名前の隠蔽で同様のことをしてみてください。

//class A1
//{
//    public virtual int calc(int a,int b)
//    {
//        return a + b;
//    }
//}

//class A2 : A1
//{
//    public override int calc(int a, int b)
//    {
//        return a - b;
//    }
//}

    class A1
{
    public int calc(int a, int b)
    {
        return a + b;
    }
}

class A2 : A1
{
    new public int calc(int a, int b)
    {
        return a - b;
    }
}

class renshu91
{
    public static void Main()
    {
        A2 a2 = new A2();


        Console.WriteLine("a2.calc(100,99) = {0}", a2.calc(100, 99));

        A1 a1;
        a1 = a2;

        //このとき、返されるのは引数の和と差のどちらでしょうか。 →オーバーライドの時は差、名前の隠蔽では和
        Console.WriteLine("a1.calc(100,99) = {0}", a1.calc(100, 99));
        
    }
}