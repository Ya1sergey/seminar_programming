// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());


if (Weekday(num))
{
    if (Weekend(num))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}

bool Weekend(int numWeek)
{
    if (numWeek == 6 || numWeek == 7) return true;
    return false;
}

bool Weekday(int number)
{
    if (number >= 1 && number <= 7) return true;
    Console.WriteLine("Вы ввели неверный номер недели");
    return false;
}