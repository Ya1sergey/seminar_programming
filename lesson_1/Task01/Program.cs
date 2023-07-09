// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.WriteLine("Введите возводимое число в квадрат");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите квадрат возмодивого числа");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == numA * numA)
{
    Console.WriteLine($"Да, число {numB} является квадратом числа {numA}");
}
else
{
    Console.WriteLine($"Нет, число {numB} не является квадратом числа {numA}");
}