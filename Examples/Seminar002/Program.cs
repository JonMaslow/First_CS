/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.WriteLine("Введите 2 числа:");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
int a = int.Parse(numberA);
int b = int.Parse(numberB);

int result = b * b;

if (result == a)

    Console.WriteLine($"Число a = {a}, является квадратом числа b = {b} ");
else

    Console.WriteLine($"Число a = {a}, не является квдратом числа b = {b}");
