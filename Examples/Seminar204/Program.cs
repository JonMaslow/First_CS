/*Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void GetNumber (int number)
{  
    if (number >= 1)
    {   
        Console.Write($"Таблица квадратов чисел от 1 до {number}:");
        for (int i = 1; i <= number; i++)    
        {
            double square = Math.Pow(i,2);
            Console.Write($" {square}, ");
        }
    }
    else
    Console.WriteLine("Введите валидное число, больше 1");
    
}
Console.WriteLine("Введите число > 1");
GetNumber(int.Parse(Console.ReadLine()??""));