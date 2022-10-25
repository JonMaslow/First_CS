/*Задача 45: 
Напишите программу, которая будет создавать копию заданного массива
с помощью поэлементного копирования.
*/

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
void PrintArray(int [] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] CopyArray(int[] array)
{
    int [] copyArr = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}
int number = GetDimensionFromConsole();
int [] array = InitArray(number);
int [] copyArr = CopyArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(copyArr);
