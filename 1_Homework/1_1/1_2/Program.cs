﻿int n_1 = int.Parse(Console.ReadLine());
int n_2 = int.Parse(Console.ReadLine());
int n_3 = int.Parse(Console.ReadLine());

if (n_1 < n_2)
{
    n_1 = n_2;
}
if (n_1 < n_3)
{
    n_1 = n_3;
}
Console.Write($"Номер {n_1} наибольшее");
