int Weekend = int.Parse(Console.ReadLine());

if (Weekend > 5)
{
    Console.Write($"День {Weekend} выходной");
}
else
{
    Console.Write($"День {Weekend} будни");
}