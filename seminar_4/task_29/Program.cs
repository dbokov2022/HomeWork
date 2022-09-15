// 29. Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = new int[8];
Console.WriteLine("Введите элементы массива:");
   
for (int  n = 0; n < 8; n++)
{
    array[n] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенный массив: [" + string.Join(",", array) + "]");

