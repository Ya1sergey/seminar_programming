// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100); // 99 + 1
Console.WriteLine($"Случайное число из отррезка 10 - 99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");

int result1 = MaxDigit(12);
Console.WriteLine($"Наибольшая цифра числа -> {result1}");

int result2 = MaxDigit(23);
Console.WriteLine($"Наибольшая цифра числа -> {result2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}