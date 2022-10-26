/*Задача 51:
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}

int [,] InitMatrix(int m, int n)
{
    int [,] resultMatrix = new int [m,n];
    Random rnd = new Random ();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix [i,j] = rnd.Next(0,10);
        }
    }
    return resultMatrix;
}
int GetSummDiaganalInMatrix(int [,] matrix)
{   
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j)
            summ += matrix[i,j];
        }
    }
    return summ;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите число m:");
int n = GetNumberFromConsole("Введите число n:");
int [,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
int summDiaganalInMatrix = GetSummDiaganalInMatrix(matrix);
Console.WriteLine($"\nСумма значений расположенных по диаганали в матрице равна: {summDiaganalInMatrix}\n");