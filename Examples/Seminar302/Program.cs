/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int GetNumber(string message)
{
Console.WriteLine(message);
int result = int.Parse(Console.ReadLine());
return result;
}

int GetSumm(int a)
{
int mult = 1;
for (int i = 1; i <= a; i++)
{
mult *= i;
}
return mult;
}

int a = GetNumber("Введите число А:");
int mult = GetSumm(a);

Console.WriteLine($"Произведение чисел от 1 до {a} = {mult}");
