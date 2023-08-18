// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// Не получилось корректно перевернуть число, в конце всегда остается 0

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999 || number <= -10000 && number >= -99999)
    Palindrome(number);
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}

void Palindrome(int num)
{
    int palindrome = 0;
    if (num < 0)
    {
        for (int result = num; palindrome >= result; num = num / 10)
        {
            palindrome = palindrome * 10 + num % 10;

        }
    }
    else
    {
        for (int result = num; palindrome <= result; num = num / 10)
        {
            palindrome = palindrome * 10 + num % 10;
            Console.WriteLine(palindrome);
        }
    }
    if ((palindrome = palindrome % 10) != 0)
        Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}

