/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/  
int [] InitRandomArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random ();
    for (int i = 0; i < length; i++)
    {
       resultArray [i] = rnd.Next(-10,10);
    } 
    return resultArray;
}
//Пучать созданного случайного массива

void PrintArray(int [] array)
{   Console.WriteLine("Рандомный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Получение числа с консоли

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int resultArray = int.Parse(Console.ReadLine()??"");
    return resultArray;
}

int lingth = GetNumber("Введите длинну массива:");
int [] array = InitRandomArray(lingth);
PrintArray(array);

int FindNumber(string messege)
{
    Console.WriteLine(messege);
    int findNumber = int.Parse(Console.ReadLine()??"");
    return findNumber;
}

int number = FindNumber("Введите искомое число найти:");


void GetFindNumber (int [] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
        Console.WriteLine($"Массив содержит число {number}");
        return;
        }
    }
    Console.WriteLine($"Массив не содержит число {number}");
}   

GetFindNumber(array, number);
