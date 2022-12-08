﻿// На вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

bool CheckCoordinate(int[,] matrix, int row, int column)
{
    return row <= matrix.GetLength(0) && column <= matrix.GetLength(1);
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 15);
PrintMatrix(array2D);

Console.Write("Введите координату строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

bool result = CheckCoordinate(array2D, row, column);
if (row <= 0 || column <= 0) Console.WriteLine("Координаты элемента задаются натуральными числами");
else Console.WriteLine(result ? array2D[row - 1, column - 1] : "Такого элемента нет");