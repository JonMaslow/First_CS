/*Задача 39: 
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

void PrintArray(int [] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int [] InitArray(int dimension)
{
    int[] arr = new int [dimension];
    Random rnd =new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1,10);
    }
    return arr;
}

int GetDimensionFromConsole()
{
    Console.WriteLine("Введите размер массива:");
    int dimension = int.Parse(Console.ReadLine()??"");
    return dimension;
}
int [] ArrayRevers(int[] arr)
{
    int [] resultArray = new int [arr.Length];
    int count = 0;
    for (int i = arr.Length -1 ; i >= 0; i--)
    {
        resultArray[count] = arr[i];
        count++;
    }
    return resultArray;
}

int length = GetDimensionFromConsole();
int [] array = InitArray(length);
Console.WriteLine("Изначальный массив:");
PrintArray(array);
int [] reversArr = ArrayRevers(array);
Console.WriteLine("Перевёрнутый массив:");
PrintArray(reversArr);