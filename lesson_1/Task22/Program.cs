// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable(num);

void SquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i,3}{square,5}");
    }
}