// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
QubeTable(num);

void QubeTable(int number)
{
    int qube = Convert.ToInt32(Math.Pow(5, 3));
    Console.WriteLine(qube);
}