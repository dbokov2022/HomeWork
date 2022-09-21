// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnsCount, double leftRange = -10, double rightRange = 10)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            // matrix[i,j] = rand.Next(leftRange, rightRange + 1);
            matrix[i, j] = rand.NextDouble() * 20 - 10;
            matrix[i, j] = Math.Round(matrix[i, j], 2);

        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[] avgSumColumn(double[,] matrix)
{
    double[] avg = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avg[j] += matrix[i, j];
        }
        avg[j] = Math.Round(avg[j]/matrix.GetLength(0), 2);
    }
    return avg;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");

double[,] matr = GetMatrix(m, n);
Console.WriteLine("\nМатрица случайных вещественных чисел: ");
PrintMatrix(matr);

Console.WriteLine($"\nСреднее арифметическое элементов каждого столбца:\n\t {string.Join("\t", avgSumColumn(matr))}");