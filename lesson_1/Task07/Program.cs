﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num *= -1;
}
if (num >= 100 && num <= 999)
{
    int result1 = num / 100; //Первая цифра трехзначного числа
    int result2 = num / 10 % 10; //Вторая цифра 
    int result3 = num % 10;  //Третья цифра
    Console.WriteLine($"Первая цифра числа: {result1}");
    Console.WriteLine($"Вторая  цифра числа: {result2}");
    Console.WriteLine($"Третья цифра числа: {result3}");
}
else
{
    Console.WriteLine($"Число {num} не трехзначное");
}

