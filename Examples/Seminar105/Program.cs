/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/


void GetResult(int numberA, int numberB)
{
    if (numberA == numberB * numberB)
        Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
    else
    {
        Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
        if (numberB == numberA * numberA)
            Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
        else
            Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");
    }
}
Console.WriteLine("Введите два числа: ");
GetResult(int.Parse(Console.ReadLine()??""), int.Parse(Console.ReadLine()??""));
