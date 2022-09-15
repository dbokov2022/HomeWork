// 38. Задайте массив натуральных чисел чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] GetArray(int size)
{
    int[] arr = new int[size];
    Console.WriteLine("Введите поочередно элементы массива: ");
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Calculation(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            {
                min = array[i];
            }
        else if (array[i] > max)
            {
                max = array[i];
            }
    }
    int res = max - min;
    return res;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);
Console.WriteLine("Массив: [" + string.Join(",", array) + "]");

int result = Calculation(array);
Console.WriteLine("Разница между максимальным и минимальным элементами = " + result);