/*Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int [] CreateArray(int n)
{
    int [] array = new int [n];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
     array[i] = rnd.Next(0,2);   
    }
    return array;
}
int[] arr = CreateArray (8);
void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
}
Console.Write("[");
PrintArray(arr);
Console.Write("]");