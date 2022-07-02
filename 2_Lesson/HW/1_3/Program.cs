void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("нет 3 цифр");
        return;
    }

    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));
