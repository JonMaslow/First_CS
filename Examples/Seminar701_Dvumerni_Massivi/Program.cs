﻿/*Задача 46: 
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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
            resultMatrix [i,j] = rnd.Next(-10,10);
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