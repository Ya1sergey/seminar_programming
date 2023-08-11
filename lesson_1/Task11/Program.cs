// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int result = MinusDigit2(number);
Console.WriteLine($"{number} -> {result}");

int MinusDigit2(int num)
{
    int Digit1 = num / 100;
    int Digit3 = num % 10;

    return Digit1 * 10 + Digit3;
}