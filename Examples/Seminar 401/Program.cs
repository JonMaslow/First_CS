/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

int SummNumber(int numberA)
{
    int summ = 0;
    for (int i = 1; i <= numberA; i++)
    {
        summ += i;
    }
    return summ;
}

int numA = GetNumber("Введите число А: ");
int sumDigit = SummNumber(numA);
Console.WriteLine ($"Сумма чисел от 1 до {numA} равна {sumDigit}");