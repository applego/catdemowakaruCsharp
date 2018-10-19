using System;

//class average01
//{
//    public static void Main()
//    {
//        //int tanaka = 70, yamada = 80, satoh = 50, sum = 0;
//        //double average;

//        //sum = tanaka + yamada + satoh;
//        //average = sum / 3.0;

//        //Console.WriteLine("合計は{0}点で、平均は{1:##.#}点です", sum, average);

//        //　配列で書き換え
//        int[] point = { 70, 80, 50 };   //配列pointを宣言
//        int sum = 0, no;

//        no = point.Length;              //配列の要素数を代入

//        for (int i = 0; i < no; i++)
//            sum += point[i];
//        double average = (double)sum / no;

//        Console.WriteLine("合計 = {0}, 平均 = {1:##.#}", sum, average);
//    }
//}

//    class array01
//{
//    public static void Main()
//    {
//        //int[,] MyArray = new int[2, 3];
//        //int i, j;

//        //MyArray[0, 0] = 1;
//        //MyArray[0, 1] = 2;
//        //MyArray[0, 2] = 3;
//        //MyArray[1, 0] = 4;
//        //MyArray[1, 1] = 5;
//        //MyArray[1, 2] = 6;

//        //for (i = 0; i < 2; i++)
//        //    for (j = 0; j < 3; j++)
//        //        Console.WriteLine("MyArray[{0},{1}] = {2}", i, j, MyArray[i, j]);

//        int[,] MyArray = { { 1, 2, 3 }, { 4, 5, 6 } };

//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 3; j++)
//                Console.WriteLine("MyArray[{0},{1}] = {2}", i, j, MyArray[i, j]);
        
//    }
//}

//    class array03
//{
//    public static void Main()
//    {
//        string[,] Name = new string[2, 5]
//        {
//            {"田中","佐藤","大竹","大山","佐々木" },{"大城","青木","加藤","新山","黒羽根" }
//        };
//        int MyClass, No;
//        string strClass, strNo;

//        while (true)
//        {
//            Console.Write("クラス---");
//            strClass = Console.ReadLine();
//            if(strClass.Length >= 2)
//            {
//                Console.WriteLine("入力は1桁のみです");
//                continue;
//            }
//            if(Char.IsNumber(strClass,0) != true)
//            {
//                Console.WriteLine("数字を入力してください");
//                continue;
//            }
//            MyClass = int.Parse(strClass);
//            if(MyClass <= 0 || MyClass >= 3)
//            {
//                Console.WriteLine("クラスは1組か2組です");
//                continue;
//            }
//            break;
//        }

//        while (true)
//        {
//            Console.Write("出席番号---");
//            strNo = Console.ReadLine();
//            if (strNo.Length >= 2)
//            {
//                Console.WriteLine("入力は1桁のみです");
//                continue;
//            }
//            if (Char.IsNumber(strNo, 0) != true)
//            {
//                Console.WriteLine("数字を入力してください");
//                continue;
//            }
//            No = int.Parse(strNo);
//            if (No <= 0 || No >= 6)
//            {
//                Console.WriteLine("クラスは1番から5番です");
//                continue;
//            }
//            break;
//        }

//        Console.WriteLine("{0}クラスの出席番号{1}番は{2}さんです", MyClass, No, Name[MyClass - 1, No - 1]);
//    }
//}

//    class array04
//{
//    public static void Main()
//    {
//        int[,,] ar = new int[2, 2, 3]
//        {
//            {{0,1,2 },{3,4,5}},
//            {{6,7,8 },{9,10,11}}
//         };
//        Console.WriteLine("配列の次元 = {0}", ar.Rank);
//        Console.WriteLine("arの個数 = {0}", ar.Length);
//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 2; j++)
//                for (int k = 0; k < 3; k++)
//                    Console.Write("{0},", ar[i, j, k]);
//        Console.WriteLine();
//    }
//}

//    class jagge01
//{
//    public static void Main()
//    {
//        int[][] ar;

//        ar = new int[2][];
//        ar[0] = new int[3];
//        ar[1] = new int[3];

//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 3; j++)
//                ar[i][j] = (i + 1) * (j + 1);
//        for (int i = 0; i < 2; i++)
//            for (int j = 0; j < 3; j++)
//                Console.WriteLine("ar[{0}][{1}] = {2}", i, j, ar[i][j]);

//        //jagged02.cs
//        string[][] name = new string[2][];
//        name[0] = new string[2] { "田中", "工藤" };
//        name[1] = new string[3] { "吉田", "佐藤", "池田" };

//        for (int i = 0; i < name[0].Length; i++)
//            Console.WriteLine(name[0][i]);
//            for(int j = 0;j< name[1].Length;j++)
//            Console.WriteLine(name[1][j]);

//    }
//}

//    class var03
//{
//    public static void Main()
//    {
//        //var name = new[] { "太郎", "次郎", "三郎", "四郎" };

//        //for (var i = 0; i < name.Length; i++)
//        //    Console.WriteLine(name[i]);

//        //var f = new[] { 0.5, 0.9, 1.5, 2.3 };
//        //for (var i = 0; i < f.Length; i++)
//        //    Console.WriteLine(f[i]);

//        ////Console.WriteLine(i);
//        //Console.WriteLine("nameの型は{0}, fの型は{1}", name.GetType(), f.GetType());

//        //sort
//        string[] name = new string[5] { "Ciriaco", "Patton", "Hellera", "Ropez", "Wiiland" };
//        for (int i = 0; i < name.Length; i++)
//            Console.WriteLine(name[i]);
//        Console.WriteLine();

//        Array.Sort(name);
//        Console.WriteLine("sort*****");
//        for (int i = 0; i < name.Length; i++)
//            Console.WriteLine(name[i]);

//        Array.Reverse(name);
//        Console.WriteLine("reverse*****");

//        for (int i = 0; i < name.Length; i++)
//            Console.WriteLine(name[i]);
//    }
//}

//    class foreach01
//{
//    public static void Main()
//    {
//        string[] Animal = new string[] { "犬", "猫", "雉", "猿" };
//        int[] Num = new int[] { 10, 20, 30, 40 };

//        foreach(string str in Animal)
//        {
//            Console.WriteLine(str);
//        }
//        Console.WriteLine();
//        foreach(int i in Num)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

    class 第6章練習問題
{
    public static void Main()
    {
        Console.Write("受験者数--");
        int JyuNum = Convert.ToInt32(Console.ReadLine());

        double[] point = new double[JyuNum];
        double sum=0;

        for(int i = 0;i < JyuNum; i++)
        {
            Console.Write("{0}人目の点数--", i + 1);
           double p= Convert.ToDouble(Console.ReadLine());
           point[i] = p;
            sum += p;
        }

        Console.WriteLine("平均点 = {0}", sum / JyuNum);

        Array.Sort(point);
        Array.Reverse(point);

        foreach(double x in point)
        {
            Console.WriteLine(x);
        }
    }
}