// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Число не натуральное");
}
else
{
    if (num % 2 == 0)
    {
        int count = 0;
        while (count <= num - 1)
        {
            count = count + 2;
            Console.Write($"{count}, ");
        }
    }
    else
    {
        num = (num - 1);
        int count = 0;
        while (count <= num - 1)
        {
            count = count + 2;
            Console.Write($"{count}, ");
        }
    }
}