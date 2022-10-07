/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/



void CompareNump(int num1, int num2)
{
    int num3 = num1 % num2;
    if (num3 == 0)
        Console.WriteLine("Второе число кратное");
    else
    
        Console.WriteLine($"второе число не кратно первому, остаток от деления: {num3}");
}

Console.WriteLine("Введите два числа:");
CompareNump(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));