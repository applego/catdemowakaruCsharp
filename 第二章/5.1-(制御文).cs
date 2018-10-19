
using System;

//class if01
//{
//    public static void Main()
//    {
//        //int n;
//        //n = 10;

//        //if (n > 5)
//        //{
//        //    Console.WriteLine("nは5より大きい");
//        //}
////        //else
////        //{
////        //    Console.WriteLine("nは5より大きくはない");
////        //}

        
//        Console.WriteLine("所持金---");
//        string strShojikin = Console.ReadLine();
//        int nShojikin = Int32.Parse(strShojikin);
        
//        Console.WriteLine("単価---");
//        string strTanka = Console.ReadLine();
//        int nTanka = Int32.Parse(strTanka);

//        Console.WriteLine("個数---");
//        string strKosu = Console.ReadLine();
//        int nKosu = Int32.Parse(strKosu);

//        int nSogaku = nTanka * nKosu;

//        while (nShojikin > nSogaku)
//        {
//            Console.WriteLine("所持金は{0}円残っています", nShojikin - nSogaku);
//            nShojikin -=  nSogaku;

//            Console.WriteLine("単価---");
//            string strTanka2 = Console.ReadLine();
//            int nTanka2 = Int32.Parse(strTanka2);

//            Console.WriteLine("個数---");
//            string strKosu2 = Console.ReadLine();
//            int nKosu2 = Int32.Parse(strKosu2);
//            nSogaku = nTanka2 * nKosu2;
//        }


//        if (nShojikin < nSogaku)
//        {
//            Console.WriteLine("所持金が足りない");
//        }
//        else
//        {
//            Console.WriteLine("所持金は{0}円残っています", nShojikin - nSogaku);
//        }

//    }
//}

//class bmi01
//{
//    public static void Main()
//    {
//        //Console.Write("Height(cm)--");
//        //double bl = double.Parse(Console.ReadLine());

//        //Console.Write("Weight(Kg)---");
//        //double bw = double.Parse(Console.ReadLine());

//        //double bmi = bw / Math.Pow((bl / 100), 2.0);
//        //Console.WriteLine("BMI = {0:##.#}", bmi);

//        //if(bmi >= 25.0)
//        //{
//        //    Console.ForegroundColor = ConsoleColor.Red;
//        //    Console.WriteLine("BMIが25以上です!!");

//        //    Console.ForegroundColor = ConsoleColor.Black;
//        //}
//        //else
//        //{
//        //    Console.WriteLine("BMIは25未満です");
//        //}

//        while (true) { 
//        string strShow = "BMIは{0:##.#}で{1}です";
//        Console.Write("Height(cm)--");
//            Console.WriteLine("0入力で終了");
            
//            double bl = double.Parse(Console.ReadLine());
//            if (bl == 0)
//            {
//                break;
//            }else { 
//            Console.Write("Weight(Kg)---");
//        double bw = double.Parse(Console.ReadLine());

//        double bmi = bw / Math.Pow((bl / 100), 2.0);

//        if(bmi < 18.5)
//        {
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine(strShow, bmi, "やせすぎ");
//        }
//        else if(18.5<= bmi && bmi < 25.0)
//        {
//            Console.WriteLine(strShow, bmi, "適正体重");
//        }
//        else if(25.0<= bmi && bmi < 30.0)
//        {
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.WriteLine(strShow, bmi, "第1度肥満");
//        }
//        else if (30.0 <= bmi && bmi < 35.0)
//        {
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.WriteLine(strShow, bmi, "第2度肥満");
//        }
//        else if (35.0 <= bmi && bmi < 40.0)
//        {
//            Console.ForegroundColor = ConsoleColor.Magenta;
//            Console.WriteLine(strShow, bmi, "第3度肥満");
//        }
//        else if(40 <= bmi)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(strShow, bmi, "第4度肥満");
//        }
        
//        Console.ForegroundColor = ConsoleColor.Black;
//        }
//    }
//}
//}

//    class switsh01
//{
//    public static void Main()
//    {
//        Console.WriteLine("************Menu******************");
//        Console.WriteLine("1:ファイル");
//        Console.WriteLine("2:編集");
//        Console.WriteLine("3:表示");
//        Console.WriteLine("0:終了");
//        Console.WriteLine("**********************************");

//        Console.Write("\n選択---");
//        string ans = Console.ReadLine();

//        switch (ans)
//        {
//            case "1":
//                Console.WriteLine("ファイルが選択されました");
//                break;

//            case "2":
//                Console.WriteLine("編集が選択されました");
//                break;

//            case "3":
//                Console.WriteLine("表示が選択されました");
//                break;

//            case "0":
//                Console.WriteLine("終了が選択されました");
//                break;

//            default:
//                Console.WriteLine("入力ミスです");
//                break;

//        }
//    }
//}

//    class for01
//{
//    public static void Main()
//    {
//        //int i;
//        //for (i = 0; i < 5; i++)
//        //    Console.WriteLine("i = {0}", i);

//        //for (i = 4; i >= 0; i--)
//        //    Console.WriteLine("\ni = {0}", i);

//        int i = 0;
//        for (;;)
//        {
//            Console.WriteLine("i = {0}", i);
//            i++;
//            if (i > 100)
//                break;
//        }

//        int j;
//        for(j=0; ; j++)
//        {
//            if (j > 100)
//                break;
//            Console.WriteLine("j = {0,8:0.0}", j);
//        }
//    }
//}

//    class kuku01
//{
//    public static void Main()
//    {
//        //for(int i=1;i<=9; i++)
//        //    {
//        //        for (int j = 1; j <= 9; j++)
//        //        {
//        //            Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
//        //        }
//        //        Console.WriteLine("---------------------------------");
//        //     }

//        double s;

//        for(double a=0.0; a <= Math.PI; a += Math.PI / 45.0)
//        {
//            s = Math.Sin(a);
//            Console.Write("{0,7:#.#####}:", s);
//            for(int i = 1; i <= Math.Round(s * 50); i++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//    class while01
//{
//    public static void Main()
//    {
//        //int i = 0;

//        //while(i < 100)
//        //{
//        //    Console.WriteLine("i = {0,3}", i);
//        //    i++;
//        //}

//        bool bEnd = false;

//        while (true)
//        {
//            Console.WriteLine("****Menu*****");
//            Console.WriteLine("0:終了");
//            Console.WriteLine("1:ファイル");
//            Console.WriteLine("2:編集");
//            Console.WriteLine("*************");
//            Console.Write("選択---");

//            string strAns = Console.ReadLine();

//            switch (strAns)
//            {
//                case "0":
//                    bEnd = true;
//                    break;
//                case "1":
//                    Console.WriteLine("ファイルが選択されました");
//                    break;
//                case "2":
//                    Console.WriteLine("編集が選択されました");
//                    break;
//                default:
//                    Console.WriteLine("入力に間違いがあります");
//                    break;

//            }
//            Console.WriteLine();

//            if (bEnd)
//            {
//                Console.WriteLine("それでは、このプログラムを終了します");
//                break;
//            }

//        }
//    }
//}

//    class while02
//{
//    public static void Main()
//    {
//        int i = 10;
//        //while (i > 20)
//        //    Console.WriteLine(i);

//        do
//        {
//            Console.WriteLine("i = {0}", i);
//        } while (i > 20);
//    }
//}

//    class goto01
//{
//    public static void Main()
//    {
//        Console.WriteLine("これからジャンプ");
//        goto jump01;
//        Console.WriteLine("これは、表示されません");

//        jump01:
//        Console.WriteLine("ここまで飛んできました");
//        Console.WriteLine("プログラムを終了します");

//    }
//}

//    class continue01
//{
//    public static void Main()
//    {
//        int sum = 0;

//        for(int i = 0;i < 100; i++)
//        {//iを2で割って余りが0かどうか（偶数かどうか）
//            if(i % 2 == 0)
//            {
//                sum += i;
//            }
//            else
//            {
//                continue;
//            }
//            Console.WriteLine("i ={0,2}, sum = {1,4}", i, sum);
//        }
//        Console.WriteLine("合計は{0}です", sum);
//    }
//}

    class 練習問題5章
{
    public static void Main()
    {
        //Console.WriteLine("BMIが22になる体重");

        //for (double i = 160; i <= 180; i++)
        //{
        //    Console.WriteLine("{0}(cm)---{1,4:##.0}(kg)",i,22* Math.Pow((i/100),2.0));
        //}

        int sum = 0;
        Console.WriteLine("1から入力された値までの整数の合計値を算出する");
        Console.WriteLine("入力値（1以上の整数---）");
        int nyuryoku = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= nyuryoku; i++)
        {
            sum += i;
            Console.WriteLine("{0,4}までの合計{1}", i, sum);
        }
    }
}