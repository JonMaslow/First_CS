/*Задача 48: 
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле:
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix [i,j] = i+j;
        }
    }
    return resultMatrix;
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