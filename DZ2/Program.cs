/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.Write("Введите 1-oe число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-oe число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-oe число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a>c)
    Console.Write($"max = {a}");
else if (b > a && b > c)
    Console.Write($"max {b}");
else
    Console.Write($"max = {c}");


