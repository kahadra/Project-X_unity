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
            Console.WriteLine("���ڸ� �Է��Ͻʽÿ�");
            string name = Console.ReadLine();
            Console.WriteLine("�Էµ� ���� : " + name);
            if (keys.Key == ConsoleKey.Escape)
                isTrue = false;
        }
    }
}