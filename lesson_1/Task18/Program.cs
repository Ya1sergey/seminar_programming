// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string num = Console.ReadLine();

Console.WriteLine(Quarter(num));

string Quarter(string number)
{
    if (number == "1") return $"Диапазон четверти {number}: X > 0, Y > 0";
    if (number == "2") return $"Диапазон четверти {number}: X < 0, Y > 0";
    if (number == "3") return $"Диапазон четверти {number}: X < 0, Y < 0";
    if (number == "4") return $"Диапазон четверти {number}: X < 0, Y < 0";
    return "Вы ввели неверный номер четверти";
}