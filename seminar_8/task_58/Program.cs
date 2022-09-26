﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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


int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplyMatr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            multiplyMatr[i, j] = matrix1[i, j] * matrix2[i, j];     
        }
    }
    return multiplyMatr;
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");

int[,] matr1 = GetMatrix(m, n);
Console.WriteLine("\nПервый массив случайных чисел: ");
PrintMatrix(matr1);

int[,] matr2 = GetMatrix(m, n);
Console.WriteLine("\nВторой массив случайных чисел: ");
PrintMatrix(matr2);

int[,] matr3 = MultiplyMatrix(matr1, matr2);
Console.WriteLine("\nПроизведение двух матриц:");
PrintMatrix(matr3);