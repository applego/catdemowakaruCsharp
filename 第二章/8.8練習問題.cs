
using System;

class MyClass
{
    double a;

    public double myprop
    {
        get
        {
            return a;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("正の数しか格納できません");
                //return;
            }
            else
            {
                a = value;

            }
        }
    }
}

class renshu81
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        for(double d = 10; d >= -10; d -= 0.5)
        {
            Console.WriteLine("mc[{0}] = {1}", d, mc.myprop = d);
        }

    }
}