// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void getMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
            Console.Write($"\t{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void searchFromMatrix(int[,] matrix)
{
    bool flag = true ;

    int searchRow = ReadNumber("Введите индекс строки для поиска элемента :");
    int searchColumn = ReadNumber("Введите индекс столбца для поиска элемента: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == searchRow && j == searchColumn)
            {
                Console.WriteLine($"Значение элемента с индексом строки {i} и индексом столбца {j}  =  {matrix[i, j]}");
                flag = false;
                break;
            }
        }
    }
    if (flag) Console.WriteLine("Такая позиция не существует");
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

int[,] matrix = new int[m, n];
Console.WriteLine("\nМатрица случайных чисел: ");
getMatrix(matrix);
Console.WriteLine();
searchFromMatrix(matrix);