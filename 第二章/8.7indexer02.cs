
using System;

class MyIndexer
{
    int[] array;
    int nMax;

    public int this[int n]
    {
        get
        {
            if(n < nMax)
            {
                return array[n];
            }
            else
            {
                return 0;
            }
        }
        set
        {
            if(n< nMax)
            {
                array[n] = value;
            }
        }
        
    }

    public MyIndexer(int i)
    {
        nMax = i;
        array = new int[i];
    }
}

class indexer02
{
    public static void Main()
    {
        MyIndexer mi = new MyIndexer(20);

        for (int i = 0; i < 20; i++)
            mi[i] = i * i;

        for (int i = 0; i < 20; i++)
            Console.WriteLine("m[{0}] = {1}", i, mi[i]);

        for (int i = 0; i < 22; i++)
            Console.WriteLine("m[{0}] = {1}", i, mi[i]);


    }
}