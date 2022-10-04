/*Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8*/

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine());

if (1000 > number && 99 < number)
    Console.WriteLine(number % 10);
else
    Console.WriteLine("Вы ввели не трёхзначное число");
