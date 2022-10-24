/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int [] InitRandomArray (int length)
{
    int [] resultArray = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = rnd.Next(-10,10);
    }
    return resultArray;
}

void PrintArray(int [] array)
{   Console.WriteLine("Первоначальный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] SummArray(int[] array)
{

int newArrayLenght = (array.Length / 2);

if(array.Length % 2 != 0)
newArrayLenght += 1;

int[] result = new int[newArrayLenght];
for (int i = 0; i < newArrayLenght; i++)
result[i] = array[i] * array[array.Length - i - 1];

if (array.Length % 2 != 0)
result[newArrayLenght-1] = array[newArrayLenght - 1];

return result;

}
Console.WriteLine("Введите длинну случайного массива: ");
int length = int.Parse(Console.ReadLine()??"");
int [] randomArray = InitRandomArray(length);
PrintArray(randomArray);
int [] newArray = SummArray(randomArray);
PrintArray(newArray);