//2.5readline01.cs ユーザーの入力を知る

using System;

class readline01
{
    public static void Main()
    {
        string name;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Please choose 1 for men, and 2 for ladies.");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Your name is Mr.{0,-10}?", name);
                break;

            case 2:
                Console.WriteLine("Your name is Ms.{0,-10}?", name);
                break;
        }

        //Console.WriteLine("Your name is {0,10}.", name);
    }
}
