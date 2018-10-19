using System;
using System.Collections;




//class renshu82
//{
//    public static void Main()
//    {
//        string[] SeitoName = new string[n];
//        for (int i = 0; i < 10; i++)
//        {
//        Console.Write("生徒名--");
//            SeitoName[i] = Console.ReadLine();

//        }

//        for(int i = 0; i < SeitoName.Length; i++)
//        Console.WriteLine("SeitoName[{0}] = {1}", i, SeitoName[i]);
//    }
//}

class MyClass
{
    string[] name;
    double[] point;
    int n;

    public double this[string str]
    {
        get
        { for(int i = 0; i < n; i++)
            {
                if (str == name[i])
                    return point[i];
            }
            return -1.0;
        }
        set
        {
            for(int i = 0; i < n; i++)
            {
                if (str == name[i])
                    point[i] = value;
                break;
            }
        }
    }
    public void setname()
    {
        for(int i = 0; i < n; i++)
        {
            Console.Write("name[{0}] = ", i);
            name[i] = Console.ReadLine();
        }
    }
    public void setpoint()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("name[{0}]の点数 = ", name[i]);
            point[i] = double.Parse(Console.ReadLine());
        }
    }
    public string outname(int b)
    {
        return name[b];
    }
    public double outpoint(int c)
    {
        return point[c];
    }


    public MyClass(int a)
    {
        n = a;
        point = new double[a];
        name = new string[a];
        setname();
        setpoint();
    }
}

class reshu82
{
    public static void Main()
    {
        MyClass mc = new MyClass(3);

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine("name[{0}]--point[{1}]", mc.outname(i), mc.outpoint(i));
        }
    }
}