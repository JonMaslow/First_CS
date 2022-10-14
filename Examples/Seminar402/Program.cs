/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}
int DigitNumber (int digit)
{
    int count = 0;
    while (digit % 10 != 0)
    {
        digit = digit / 10;
        count ++;
    } 
    return count;
}
int digit = GetNumber("Введите число А: ");
int count = DigitNumber(digit);
Console.WriteLine($"В числе {digit} содержиться {count} цифр");
