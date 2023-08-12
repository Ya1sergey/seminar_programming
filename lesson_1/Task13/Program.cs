// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 100) Console.WriteLine("Третьей цифры нет");

else Console.WriteLine($"Третья цифра числа: {Digit3(num)}");

int Digit3(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    return number % 10;
}