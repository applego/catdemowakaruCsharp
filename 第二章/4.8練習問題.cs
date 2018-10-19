
/*int 型
    cat  1  000001
    rat  2  000010
    dog  4  000100

    cat|dog 000101
    */

using System;

class renshu04
{
    public static void Main()
    {
        int cat = 1,rat = 2, dog = 4;
        int pet;

        pet = cat | dog;

        Console.WriteLine("pet:{0}",pet);
        //Console.WriteLine("pet:{0}", BitConverter.ToString(pet));
        Console.WriteLine("petにcatが含まれている:{0}",(pet & cat) != 0);
        Console.WriteLine("petにratが含まれている:{0}",(pet & rat) != 0);
        Console.WriteLine("petにdogが含まれている:{0}",(pet & dog) != 0);


    }
}