/*Задача 49:
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}

double [,] InitMatrix(int m, int n)
{
    double [,] resultMatrix = new double [m,n];
    Random rnd = new Random ();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix [i,j] = rnd.Next(2,10);
        }
    }
    return resultMatrix;
}
double [,] GetMatrixModified (double [,] initialMatrix)
{
    double [,] modifiedMatrix = new double [initialMatrix.GetLength(0), initialMatrix.GetLength(1)];
    for (int i = 0; i < initialMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < initialMatrix.GetLength(1); j++)
        {   
            if (i % 2 != 0 && j % 2 != 0)
                modifiedMatrix [i,j] = Math.Pow(initialMatrix[i,j], 2);
            else
                modifiedMatrix[i,j] = initialMatrix[i,j];
        }
    }
    return modifiedMatrix; 
}

void PrintMatrix(double[,] matrix)
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
double [,] initialMatrix = InitMatrix(m,n);
double [,] modifiedMatrix = GetMatrixModified(initialMatrix);
Console.WriteLine("\nИзначальный массив:\n");
PrintMatrix(initialMatrix);
Console.WriteLine("\nИзменённый массив:\n");
PrintMatrix(modifiedMatrix);
