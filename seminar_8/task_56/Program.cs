﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int MinSumInRow(int[,] matrix)
{
    int sum = 0;
    int minRow = 0;
    int minSum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSum += matrix[0, j];
            minRow = i;
        }
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    return minRow +1;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
Console.WriteLine("\nМассив случайных чисел: ");
PrintMatrix(matr);

int minSumRow = MinSumInRow(matr);
Console.WriteLine("\nНаименьшая сумма элементов в строке: " + minSumRow);

