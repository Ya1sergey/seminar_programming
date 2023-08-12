// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());


if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
int num2 = Digit2(num);
Console.WriteLine($"Вторая цифра числа: {num2}");
}
else Console.WriteLine("Вы ввели не трехзначное число");


int Digit2(int number)
{
    int result = number % 100 / 10;
    return result;
}