using System;

class Program
{
    static void Main()
    {
        Five();
        Console.ReadKey();
    }

    static int EnterANumber()
    {
        string cucumber;
        Console.Write("Введите число:");
        cucumber = Console.ReadLine();
        int number = Convert.ToInt32(cucumber);

        return number;
    }

    static void One()
    {
        int number = EnterANumber();
        if (number % 3 == 0)
            Console.WriteLine($"Число {number} кратно 3.");
        else
            Console.WriteLine($"Число {number} не кратно 3.");
    }

    static void Two()
    {
        int number = EnterANumber();
        if (number % 5 == 2 || number % 7 == 1)
            Console.WriteLine($"Число {number} делится на 5 с " +
                $"остатком 2 или на 7 с остатком 1.");
        else
            Console.WriteLine($"Число {number} не делится на 5 " +
                $"с остатком 2 или на 7 с остатком 1.");
    }

    static void Three()
    {
        int number = EnterANumber();
        if (number % 4 == 0 && !(number < 10))
            Console.WriteLine("Число удовлетворяет условию:" +
                " \"число делится на 4, и при этом оно не меньше 10\"");
        else
            Console.WriteLine("Число не удовлетворяет условию:" +
                " \"число делится на 4, и при этом оно не меньше 10\"");
    }

    static void Four()
    {
        int number = EnterANumber();
        if (number >= 5 && number <= 10)
            Console.WriteLine($"Число {number} в диапозоне от 5 до 10");
        else
            Console.WriteLine($"Число {number} НЕ        в диапозоне от 5 до 10");

    }

    static void Five()
    {
        int number = EnterANumber();
        if (number > 999)
        {
            int chmonya = number / 1000 % 10;
            Console.WriteLine($"Вот тысячи:{chmonya}");
        }
        else
        {
            Console.WriteLine("Число не имеет разряда тысяч :( ");
        }

    }
}