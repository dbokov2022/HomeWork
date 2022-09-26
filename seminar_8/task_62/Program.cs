// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"\t{matrix[i, j]}");
    }
    Console.WriteLine();
  }
}

int[,] SpiralMatrix(int[] arr)
{
  int n = 4;
  int[,] matr = new int[n, n];
  
  int m = n / 2;
  int len = n;
  int count = 0;

  for (int i = 0; i < m; i++)
  {    
    for (int j = 0; j < len; j++) matr[i, i + j] = arr[count++];  // Cлева направо    
    for (int j = 1; j < len; j++) matr[i + j, n - i - 1] = arr[count++]; // Cверху вниз
    len -= 2;
    
    for (int j = len; j >= 0; j--) matr[n - i - 1, i + j] = arr[count++]; // Cправа налево    
    for (int j = len; j >= 1; j--) matr[i + j, i] = arr[count++]; // Cнизу вверх
  }
  return matr;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int[,] matrix = SpiralMatrix(array);
Console.WriteLine("Спиральный массив: ");
PrintMatrix(matrix);