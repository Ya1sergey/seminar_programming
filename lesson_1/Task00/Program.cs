﻿// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// int number = Int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите целое число возводимое в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
// Console.WriteLine($"Квадрат числа {number} = {square}");
Console.WriteLine("Квадрат числа " + number + " = " + square);