﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

// void Sort(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }
// }

void Sort(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1)-1; j ++)
        {
            int minPosition = j;
            for (int m = j + 1; m < matrix.GetLength(1); m++)
            {
                if (matrix[i, m] < matrix[i, minPosition])
                {
                    minPosition = m;
                }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temp;
        }
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
Console.WriteLine("\nМассив случайных чисел: ");
PrintMatrix(matr);

Sort(matr);
Console.WriteLine("\nНовый массив с упорядоченными по возрастанию строками: ");
PrintMatrix(matr);

