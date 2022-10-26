/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/


bool stop = false;
int number = 0;
int summ = 0;

while(!stop)// !false = true; !true = false
{
Console.WriteLine("введите число");
number = int.Parse(Console.ReadLine());

if(number > 0)
summ++;

Console.WriteLine("Продолжить вводить числа? y/n");
string result = Console.ReadLine();
if(result == "y")
stop = false;
else
stop = true;
}

Console.WriteLine($"Кол-во чисел, введеных пользователем, которые больше 0 - {summ}");