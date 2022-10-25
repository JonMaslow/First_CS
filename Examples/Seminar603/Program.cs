/*Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/
int GetNumberFromConsole()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}
int number = GetNumberFromConsole();
int [] GetFibonachiArray(int number)
{   
    int[] array = new int [number];
    
        array[0] = 0;
        array[1] = 1;
     
    for (int i = 2; i < array.Length; i++)
    {   
       
        array[i] = array[i-1] + array[i-2];
    }
    /*int i = 0;
    int num = 0;
    while (count <= number)
    {
        array[i] = num;
        i++;
        num += 1;
        count++;
    }*/
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int [] fibonachiArray = GetFibonachiArray(number);
PrintArray(fibonachiArray);