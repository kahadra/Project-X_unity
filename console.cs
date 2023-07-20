using System;

public class ft_console
{
    public void Main(string[] arv)
    {
        bool isTrue = true;
        ConsoleKeyInfo keys;
        while (isTrue)
        {
            keys = Console.ReadKey(true);
            Console.WriteLine("문자를 입력하십시오");
            string name = Console.ReadLine();
            Console.WriteLine("입력된 문자 : " + name);
            if (keys.Key == ConsoleKey.Escape)
                isTrue = false;
        }
    }
}