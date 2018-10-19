
using System;


    class BMI
{
    double bw, bl;

    public double blprop
    {   //身長を表すプロパティ
        get
        {
            return bl;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("身長に0または負の値は設定できません");
                return;
            }
            bl = value;
        }
    }

    public double bwprop
    {
        get
        {
            return bw;
        }
        set
        {
            if(bw <= 0)
            {
                Console.WriteLine("体重に0または負の値は設定できません");
                return;
            }
            bw = value;
        }
    }

    public double CalcBMI()     //BMIを計算して返すメソッド
    {
        if(bl == 0.0 || bw == 0.0)
        {
            Console.WriteLine("データがセットされていません");
            return 0.0;
        }
        return bw / Math.Pow(bl, 2.0);
    }
}


    class prop02
    {
        public static void Main()
    {
        BMI mybmi = new BMI();
        double bl, bw;

        do
        {
            Console.Write("身長(m)---");
            string strBl = Console.ReadLine();
            bl = double.Parse(strBl);
            mybmi.blprop = bl;
        } while (bl <= 0.0);

        do
        {
            Console.Write("体重(kg)---");
            string strBw = Console.ReadLine();
            bw = double.Parse(strBw);
            mybmi.bwprop = bw;
        } while (bw <= 0.0);

        Console.WriteLine("bi = {0},bw = {1}", mybmi.blprop, mybmi.bwprop);

        Console.WriteLine("BMI = {0:#.#}", mybmi.CalcBMI());

        }
}

    