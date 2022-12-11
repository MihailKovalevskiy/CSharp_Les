//Задача №8


Console.WriteLine("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}
Console.ReadLine();