﻿// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти:");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter >= 1 && quarter <=4)  // проверяем на правильность ввода четверти
{

    if (quarter == 1)
        {
            Console.WriteLine("Координаты точек первой координатной четверти в диапазоне 'x > 0 && y > 0'");
        }

    if (quarter == 2)
        {
            Console.WriteLine("Координаты точек второй координатной четверти в диапазоне 'x < 0 && y > 0'");
        }

    if (quarter == 3)
        {
            Console.WriteLine("Координаты точек третьей координатной четверти в диапазоне 'x < 0 && y < 0'");
        }

    if (quarter == 4)
        {
            Console.WriteLine("Координаты точек четверой координатной четверти в диапазоне 'x > 0 && y < 0'");
        }

}
else
    {
         Console.WriteLine("Существует только четыре координатные четверти!");
    }
