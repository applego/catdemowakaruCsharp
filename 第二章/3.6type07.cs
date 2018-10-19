// type07.cs

using System;

class type07
{
    public static void Main()
    {
        decimal total;

        Console.Write("借入金額---");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("利息（%）---");
        decimal p = decimal.Parse(Console.ReadLine());
        Console.Write("何期間後までの返済金額が知りたい？");
        int n = Convert.ToInt32(Console.ReadLine());


        decimal r = p / 100m;


        //Console.WriteLine("1期間後の元利合計は{0:c}です", total);
        //a = total;
        //total = a * (1m + r);
        //Console.WriteLine("2週間後の元利合計は{0:c}です", total);
        //a = total;
        //total = a * (1m + r);
        //Console.WriteLine("3週間後の元利合計は{0:c}です", total);
        //a = total;
        //total = a * (1m + r);
        //Console.WriteLine("4週間後の元利合計は{0:c}です", total);
        
        //for で書き換え
        for(int i = 0; i < n; i++)
        {
            total = a * (1m + r);
            Console.WriteLine("{0}期間後の元利合計は{1:c}です",i+1, total);
            a = total;
        }
    }
}