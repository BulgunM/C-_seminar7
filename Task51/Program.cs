// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// int SumElements(int[,] matrix)
// {
//   int sum = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//   sum += matrix[i, i];
//   // for (int j = 0; j < matrix.GetLength(1); j++)
//             // {
//             //     if (i == j) sum = sum + matrix[i, j];
//             // }
//         }
//     return sum;
// }

int SumElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) // проверяет длину строк и столбцов, и делает проход по наименьшему
    {
        sum += matrix[i, i];
        // for (int j = 0; j < matrix.GetLength(1); j++)
        // {
        //     if (i == j) sum = sum + matrix[i, j];
        // }
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }

}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int result = SumElements(array2D);
Console.WriteLine($"Сумма элементов на главной диагонали равно {result}");