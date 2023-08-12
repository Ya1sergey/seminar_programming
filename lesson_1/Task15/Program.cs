// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 
Console.WriteLine("Введите номер дня недели");
int numWeek = Convert.ToInt32(Console.ReadLine());

if(numWeek == 6 || numWeek == 7) Console.WriteLine("Да");
else 
{
    if(numWeek > 7 || numWeek < 1) Console.WriteLine("Вы ввели неверный номер недели");
    else Console.WriteLine("Нет");
}