// Задача 4: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c)
    {
    Console.WriteLine("Все числа максимальные = " + a);
    }
else if (a == b)
    {
    Console.WriteLine("Максимальные числа №1 и №2 = " + a);
    }
else if (a == c)
    {
    Console.WriteLine("Максимальные числа №1 и №3 = " + a);
    }
else if (b == c)
    {
    Console.WriteLine("Максимальные числа №2 и №3 = " + b);
    }
else if (a >= b && a >= c)
    {
    Console.WriteLine("Максимальное число №1 = " + a);
    }
else if (b >= a && b >= c)
    {
    Console.WriteLine("Максимальное число №2 = " + b);
    }
else if (c >= a && c >= b)
    {
    Console.WriteLine("Максимальное число №3 = " + c);
    }