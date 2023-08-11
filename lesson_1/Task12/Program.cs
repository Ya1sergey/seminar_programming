// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Remains(number, number2);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {result}");

int Remains(int num1, int num2)
{
    return num1 % num2;
}