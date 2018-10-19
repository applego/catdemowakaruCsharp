// type01.cs

using System;

class type01
{
    public static void Main()
    {
        Console.WriteLine("sbyte:{0,15:#,#}～{1,15:#,#}",sbyte.MinValue,sbyte.MaxValue);    //,15:#,#
        Console.WriteLine("short:{0,15:#,#}～{1,15:#,#}", short.MinValue, short.MaxValue);    //,15:#,#
        Console.WriteLine("int:{0,15:#,#}～{1,15:#,#}", int.MinValue, int.MaxValue);    //,15:#,#
        Console.WriteLine("long:{0,15:#,#}～{1,15:#,#}", long.MinValue, long.MaxValue);    //,15:#,#
        Console.WriteLine();
        Console.WriteLine("byte:{0,15:#,#}～{1,15:#,#}", byte.MinValue, byte.MaxValue);    //,15:#,#
        Console.WriteLine("ushort:{0,15:#,#}～{1,15:#,#}", ushort.MinValue, ushort.MaxValue);    //,15:#,#
        Console.WriteLine("uint:{0,15:#,#}～{1,15:#,#}", uint.MinValue, uint.MaxValue);    //,15:#,#
        Console.WriteLine("ulong:{0,15:#,#}～{1,15:#,#}", ulong.MinValue, ulong.MaxValue);    //,15:#,#
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

        Console.WriteLine("sbyte:{0,-20}～{1}", sbyte.MinValue, sbyte.MaxValue);    //,15
        Console.WriteLine("short:{0,-20}～{1}", short.MinValue, short.MaxValue);    //,15
        Console.WriteLine("int:  {0,-20}～{1}", int.MinValue, int.MaxValue);    //,15
        Console.WriteLine("long: {0,-20}～{1}", long.MinValue, long.MaxValue);    //,15
        Console.WriteLine();
        Console.WriteLine("byte:  {0}～{1,-15}", byte.MinValue, byte.MaxValue);    //,15
        Console.WriteLine("ushort:{0}～{1,-15}", ushort.MinValue, ushort.MaxValue);    //,15
        Console.WriteLine("uint:  {0}～{1,-15}", uint.MinValue, uint.MaxValue);    //,15
        Console.WriteLine("ulong: {0}～{1,-15}", ulong.MinValue, ulong.MaxValue);    //,15
    }
}