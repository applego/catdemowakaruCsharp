//2.5readline01.cs ユーザーの入力を知る

using System;

class readline01
{
    public static void Main()
    {
        string name;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Your name is {0,10}.", name);
        DateTime dt = DateTime.Now;
        dt.ToString("yyyy/mm/dd hh:MM");
        int zan = 5;
        int tetuduki = 2;
        string.Format("残り{0}日,{1}日以内に手続き必要", zan, tetuduki);
        
    }
}
