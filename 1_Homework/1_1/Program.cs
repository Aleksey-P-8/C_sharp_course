string s_n_1 = Console.ReadLine();
string s_n_2 = Console.ReadLine();

int n_1 = int.Parse(s_n_1);
int n_2 = int.Parse(s_n_2);

if (n_1 > n_2)
{

    Console.Write($"The number {n_1} больше чем {n_2}");
}
else if (n_1 == n_2)
{
    Console.Write($"The number {n_1} равно числу {n_2}");
}
else 
{
    Console.Write($"The number {n_2} больше чем {n_1}");
}