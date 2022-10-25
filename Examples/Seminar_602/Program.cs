/*Задача 42:
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
int GetNumberFromConsole()
{
    Console.WriteLine("Введите число для конвертации:");
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}
int number = GetNumberFromConsole();

string ConversionToBinarySystem (int number)
{
    string numBinary = Convert.ToString(number%2);
    int num = number/2;
    while (num > 0)
    {   
        numBinary += Convert.ToString(num % 2);
        num = num/2;
    }
    int count = 0;
    char [] resultNumBinary = new char [numBinary.Length];
    for (int i = numBinary.Length -1; i >= 0; i--)
    {
        resultNumBinary[count] = numBinary[i];
        count ++;
    }
    return new string (resultNumBinary);
}
string numBinary = ConversionToBinarySystem(number);
Console.WriteLine(numBinary);

/*int [] DoubleSystem(int number)
{
    List <int> array = new List <int>();
    while (number >=1)
    {
        array.Add(number%2);
        number = number/2;
    }
    return array.ToArray();
}
int [] numBinary = DoubleSystem(number);

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
int [] resultBinary = ArrayRevers(numBinary);
void PrintArray(int[] numBinary)
{
    for (int i = 0; i < numBinary.Length; i++)
    {
        Console.Write(numBinary[i]);
    }
}
PrintArray(resultBinary);*/
