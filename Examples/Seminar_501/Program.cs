/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int [] InitRandomArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random ();
    for (int i = 0; i < length; i++)
    {
       resultArray [i] = rnd.Next(-100,100);
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

int length = GetNumber("Введите длинну массива:");
int [] arrayOlder = InitRandomArray(length);
PrintArray(arrayOlder);

int [] NewArray(int [] arrayOld)
{   
    int [] newArray = new int [arrayOld.Length];
    for (int i = 0; i < arrayOld.Length; i++)
    {
        newArray[i] = arrayOld[i] * (-1);
    }
    return newArray;
}

void PrintArrayNew(int [] newArray)
{
    Console.WriteLine("Изменённый массив:");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

int [] newArray = NewArray(arrayOlder);
PrintArrayNew(newArray);