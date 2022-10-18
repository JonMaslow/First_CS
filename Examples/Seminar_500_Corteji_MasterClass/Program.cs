/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

//Инициализация массива рандомными числами от -9 до 9
int [] InitRandomArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random ();
    for (int i = 0; i < length; i++)
    {
       resultArray [i] = rnd.Next(-9,10);
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

//Получение суммы положительных чисел
int GetSummOfPositiv(int [] array)
{   int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] > 0)
        summ += array[i]; //summ = summ + array[i]
    }
    return summ;
}

//Получение суммы отрицательных чисел
int GetSummOfNegative(int [] array)
{   int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] < 0)
        summ += array[i]; 
    }
    return summ;
}

// Для того чтобы не прогонять два раза программу по циклу, можно использовать кортеж.
//Таким образом будет один проход по циклу.
//Первое значение это сумма положительны, второе отрицательных.

(int, int) GetSumms(int[] array)
{
    int summPositiv = 0;
    int summNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summPositiv += array [i];
        else
            summNegative += array [i];
    }
    return (summPositiv, summNegative);
}


int length = GetNumber("Введите длинну массива:");
int [] array = InitRandomArray(length);
PrintArray(array);
int posSum = GetSummOfPositiv(array);
int negSum = GetSummOfNegative(array);
Console.WriteLine($"Сумма положительных чисел в массиве равна {posSum},\nСумма отрицательных чисел в массиве равна {negSum}.");
Console.WriteLine();

(int sumPos, int sumNeg) = GetSumms(array);
Console.WriteLine($"Сумма положительных чисел в массиве равна {sumPos},\nСумма отрицательных чисел в массиве равна {sumNeg}.");
